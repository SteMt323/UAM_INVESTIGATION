using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Estructuras;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class NovInvest : UserControl
    {
        private ValorarTrabajos valorarTrabajos;
        private InitRegis gestionUsuarios;
        private ControlTrabajos controlTrabajos;
        private ComentarTrabajos comentarTrabajos;

        private int idTrabajoCV;
        private int idUsuarioCV;
        public NovInvest(int idUsuario)
        {
            InitializeComponent();
            this.idUsuarioCV = idUsuario;
            valorarTrabajos = new ValorarTrabajos();
            gestionUsuarios = new InitRegis();
            controlTrabajos = new ControlTrabajos();
            comentarTrabajos = new ComentarTrabajos();
        }

        private void txt_Busqueda_Enter(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text == "Buscar Trabajos...")
            {
                txt_Busqueda.Text = "";
                txt_Busqueda.ForeColor = Color.Black;
            }
        }

        private void txt_Busqueda_Leave(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text == "")
            {
                txt_Busqueda.Text = "Buscar Trabajos...";
                txt_Busqueda.ForeColor = Color.DimGray;
            }
        }

        private void btn_Valoracion_Click(object sender, EventArgs e)
        {
            Calificar calificar = new Calificar(idTrabajoCV, idUsuarioCV);
            calificar.ShowDialog();
        }

        private void Btn_Comentar_Click(object sender, EventArgs e)
        {
            Comentarios comentarios = new Comentarios(idTrabajoCV, idUsuarioCV);
            comentarios.ShowDialog();
        }

        private void NovInvest_Load(object sender, EventArgs e)
        {
            //Cargar los datos
            CargarDataTrabajos();
        }

        private string ObtenerUsuario(int id)
        {
            var usuario = gestionUsuarios.LeerUsuariosEst();
            foreach (var est in usuario)
            {
                if (est.Id == id)
                {
                    return est.Nombre;
                }
            }
            return "";
        }

        private List<int> ObtenerValoraciones (int idTrabajo)
        {
            var valoraciones = valorarTrabajos.LeerValoraciones();
            var listaValoraciones = new List<int>();

            foreach (var calificacion in valoraciones)
            {
                if (calificacion.IdTrabajo == idTrabajo)
                {
                    listaValoraciones.Add(calificacion.Calificacion);
                }
            }
            return listaValoraciones;
        }

        private double CalcularPromedio(int idTrabajo)
        {
            var valoraciones = ObtenerValoraciones(idTrabajo);

            if (valoraciones.Count == 0)
                return 0;
            double suma = valoraciones.Sum();
            return suma / valoraciones.Count();
        }

        private void CargarDataTrabajos()
        {
            var trabajos = controlTrabajos.ObtenerTrabajos();
            dgv_NovInvest.Rows.Clear();
            foreach (var  trabajo in trabajos)
            {
                string name = ObtenerUsuario(trabajo.IdUsuario);
                double valoracion = CalcularPromedio(trabajo.IdTrabajo);
                dgv_NovInvest.Rows.Add(trabajo.Titulo, trabajo.Descripcion, name, valoracion.ToString("N1"), trabajo.Categoria, trabajo.IdTrabajo);
            }
        }

        private void dgv_NovInvest_SelectionChanged(object sender, EventArgs e)
        {
            if(dgv_NovInvest.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dgv_NovInvest.SelectedRows[0];
                lbl_Titulo.Text = filaSeleccionada.Cells[0].Value != null ? filaSeleccionada.Cells[0].Value.ToString() : "N/A";
                lbl_Descripcion.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[1].Value.ToString() : "N/A";
                lbl_Categoria.Text = filaSeleccionada.Cells["Categoria"].Value != null ? filaSeleccionada.Cells["Categoria"].Value.ToString() : "N/A";
                //Validar IdUsuario e IdTrabajo antes de convertir
                if (int.TryParse(filaSeleccionada.Cells["IdTrab"]?.Value?.ToString(), out int idTrabajo))
                {
                    CargarComentarios(idTrabajo);
                    idTrabajoCV = idTrabajo;
                }
                else
                {
                    MessageBox.Show("Error al obtener los IDs del trabajo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CargarComentarios(int idTrabajo)
        {
            var comentarios = comentarTrabajos.LeerComenarios().Where(c => c.IdTrabajo == idTrabajo).ToList();
            dgv_Comentarios.Rows.Clear();
            if (!comentarios.Any())
            {
                dgv_Comentarios.Rows.Add("N/A", "Sin comentarios");
            }
            foreach (var comentario in comentarios)
            {
                string name = ObtenerUsuario(comentario.IdUsuario);
                dgv_Comentarios.Rows.Add(name, comentario.TextoComentario);
            }
        }
    }
}
