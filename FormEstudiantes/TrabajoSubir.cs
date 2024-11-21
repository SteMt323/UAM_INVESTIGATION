using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Helpers;
using System.IO;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class TrabajoSubir : UserControl
    {
        private ControlTrabajos controlTrabajos;
        private string rutaArchivoSeleccionado;
        private int IdEstudiante;
        public TrabajoSubir(int idEstudiante)

        {
            InitializeComponent();
            controlTrabajos = new ControlTrabajos();
            rutaArchivoSeleccionado = null;
            IdEstudiante = idEstudiante;
        }

        private void CargarTrabajos()
        {

            var trabajos = controlTrabajos.ObtenerTrabajos()
                .Where(t => t.IdUsuario == IdEstudiante)
                .ToList();


            dataGridViewTrabajos.Rows.Clear();


            foreach (var trabajo in trabajos)
            {
                dataGridViewTrabajos.Rows.Add(trabajo.Titulo, trabajo.Categoria, trabajo.Descripcion);
            }

            if(trabajos.Count == 0)
            {
                msgError("No tienes trabajos registrados...");
            }
            else
            {
                lblErrorMessage.Text = "";
                lblErrorMessage.Visible = false;
                iconPictureBox1.Visible = false;
            }
        }

        private void msgError(string message)
        {
            lblErrorMessage.Text = message;
            lblErrorMessage.Visible = true;
            iconPictureBox1.Visible = true;
        }

        private void BuscarTrabajo(string titulo)
        {

            var trabajos = controlTrabajos.ObtenerTrabajos();

            //Filtrar los trabajos por título
            var filtrados = trabajos.Where(t => t.Titulo.Contains(titulo)).ToList();


            dataGridViewTrabajos.Rows.Clear();

            //Cargar los trabajos filtrados
            foreach (var trabajo in filtrados)
            {
                dataGridViewTrabajos.Rows.Add(trabajo.Titulo, trabajo.Categoria, trabajo.Descripcion);
            }


            if (filtrados.Count == 0)
            {
                MessageBox.Show("No se encontró ningún trabajo con el título proporcionado.", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btn_AdjuntarArchivo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                openFileDialog.Title = "Seleccionar archivo PDF";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivoSeleccionado = openFileDialog.FileName;
                    lbl_ArchivoAdjunto.Text = Path.GetFileName(rutaArchivoSeleccionado); // Mostrar el nombre del archivo en una etiqueta
                
                }
            }
        }

        private void btn_SubirTrabajo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rutaArchivoSeleccionado))
            {
                MessageBox.Show("Por favor, adjunta un archivo antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titulo = txt_Titulo.Text;
            string descripcion = txt_Descripcion.Text;
            string categoria = cmb_Categoria.SelectedItem?.ToString() ?? "Sin categoría";

            if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool exito = controlTrabajos.GuardarTrabajo(
                idUsuario: IdEstudiante, 
                titulo: titulo,
                descripcion: descripcion,
                categoria: categoria,
                archivoPdf: rutaArchivoSeleccionado
            );

            if (exito)
            {
                MessageBox.Show("Trabajo subido exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Actualizar el DataGridView
                CargarTrabajos();

                //Limpiar los campos
                txt_Titulo.Clear();
                txt_Descripcion.Clear();
                cmb_Categoria.SelectedIndex = -1;
                lbl_ArchivoAdjunto.Text = "Ningún archivo adjunto";
                rutaArchivoSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Ocurrió un error al subir el trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TrabajoSubir_Load(object sender, EventArgs e)
        {
            CargarTrabajos();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string titulo = txt_TituloBusqueda.Text.Trim(); // TextBox para ingresar el título

            if (!string.IsNullOrEmpty(titulo))
            {
                BuscarTrabajo(titulo);
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un título para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_DeshacerFiltrado_Click(object sender, EventArgs e)
        {
            txt_TituloBusqueda.Clear();
            CargarTrabajos();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
