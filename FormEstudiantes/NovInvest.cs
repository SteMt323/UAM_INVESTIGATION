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
            if (idTrabajoCV != 0)  // Verifica si se ha seleccionado un trabajo
            {
                Calificar calificar = new Calificar(idTrabajoCV, idUsuarioCV);
                calificar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un trabajo antes de valorar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Btn_Comentar_Click(object sender, EventArgs e)
        {
            if (idTrabajoCV != 0)  // Verifica si se ha seleccionado un trabajo
            {
                Comentarios comentarios = new Comentarios(idTrabajoCV, idUsuarioCV);
                comentarios.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un trabajo antes de comentar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                txt_Titulo.Text = filaSeleccionada.Cells[0].Value != null ? filaSeleccionada.Cells[0].Value.ToString() : "N/A";
                txt_Descripcion.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[1].Value.ToString() : "N/A";
                txt_Categoria.Text = filaSeleccionada.Cells["Categoria"].Value != null ? filaSeleccionada.Cells["Categoria"].Value.ToString() : "N/A";
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

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_VerArchivo_Click(object sender, EventArgs e)
        {
            if (idTrabajoCV != 0)  // Verifica si se ha seleccionado un trabajo
            {
                ArchivosTrabajos archivosTrabajos = new ArchivosTrabajos(idTrabajoCV);
                archivosTrabajos.ShowDialog();

            }
            else
            {
                MessageBox.Show("Por favor, selecciona un trabajo antes de visualizar el trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        //FILTROS
        private Dictionary<string, List<string>> palabrasClavePorCategoria = new Dictionary<string, List<string>>()
        {
            { "Arte y Cultura", new List<string> { "pintura", "escultura", "literatura", "música", "cine", "patrimonio", "danza", "teatro", "estética", "fotografía" } },
            { "Agronomía y Ciencias Agropecuarias", new List<string> { "agricultura", "agroecología", "cultivos", "fertilizantes", "ganadería", "irrigación", "biotecnología agrícola", "agroindustria", "sistemas de riego", "producción sostenible" } },
            { "Ciencias Computacionales", new List<string> { "algoritmos", "inteligencia artificial", "big data", "seguridad informática", "programación", "aprendizaje automático", "desarrollo web", "blockchain", "sistemas operativos", "redes" } },
            { "Ciencias de la Salud", new List<string> { "medicina", "enfermería", "epidemiología", "salud pública", "farmacología", "nutrición", "psicología clínica", "biomedicina", "terapia física", "diagnóstico" } },
            { "Ciencias Espaciales", new List<string> { "astronomía", "astrofísica", "exploración espacial", "satélites", "misiones espaciales", "telescopios", "meteoritos", "planetología", "cosmología", "colonización espacial" } },
            { "Ciencias Naturales", new List<string> { "biología", "química", "física", "ecología", "geología", "oceanografía", "botánica", "zoología", "genética", "energía renovable" } },
            { "Ciencias Sociales", new List<string> { "sociología", "antropología", "política", "comunicación", "psicología social", "demografía", "cultura popular", "economía social", "globalización", "conflictos sociales" } },
            { "Desarrollo Sostenible", new List<string> { "energías renovables", "economía circular", "cambio climático", "biodiversidad", "desarrollo comunitario", "responsabilidad social", "educación ambiental", "reciclaje", "conservación", "recursos hídricos" } },
            { "Derecho y Legislación", new List<string> { "constitucional", "penal", "civil", "derechos humanos", "propiedad intelectual", "legislación ambiental", "arbitraje", "contratos", "derecho internacional", "normas jurídicas" } },
            { "Economía y Negocios", new List<string> { "finanzas", "mercados", "marketing", "comercio internacional", "emprendimiento", "macroeconomía", "microeconomía", "innovación empresarial", "recursos humanos", "gestión de proyectos" } },
            { "Educación", new List<string> { "pedagogía", "didáctica", "innovación educativa", "educación inclusiva", "tecnología educativa", "metodología", "evaluación", "alfabetización digital", "políticas educativas", "formación docente" } },
            { "Historia y Humanidades", new List<string> { "historia antigua", "filosofía", "arqueología", "arte clásico", "historia moderna", "lingüística", "religión", "cultura popular", "ética", "literatura histórica" } },
            { "Ingeniería", new List<string> { "diseño estructural", "mecánica", "energía", "robótica", "automatización", "innovación tecnológica", "ingeniería eléctrica", "ingeniería civil", "nanotecnología", "materiales" } },
            { "Transporte y Logística", new List<string> { "transporte marítimo", "logística inversa", "cadena de suministro", "movilidad urbana", "infraestructura", "transporte sostenible", "automatización logística", "transporte aéreo", "comercio internacional", "sistemas ferroviarios" } },
            { "Tecnología e Innovación", new List<string> { "internet de las cosas", "realidad aumentada", "inteligencia artificial", "impresión 3D", "ciberseguridad", "innovación digital", "tecnología verde", "automatización", "computación cuántica", "startups" } }

        };

        private bool PalabraClaveEnCategoria(string busquedaTexto, string categoria)
        {
            if (palabrasClavePorCategoria.ContainsKey(categoria))
            {
                // Buscamos si alguna palabra clave de la categoría coincide con la búsqueda
                return palabrasClavePorCategoria[categoria]
                        .Any(palabra => busquedaTexto.Contains(palabra.ToLower()));
            }
            return false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            string busquedaTexto = txt_Busqueda.Text.ToLower(); //Convertir a minúsculas para hacer una búsqueda insensible

            var trabajos = controlTrabajos.ObtenerTrabajos();  

            var trabajosFiltrados = trabajos.Where(t =>
                //Filtro por título
                t.Titulo.ToLower().Contains(busquedaTexto) ||

                //Filtro por nombre de usuario (usamos el método ObtenerUsuario para obtener el nombre)
                ObtenerUsuario(t.IdUsuario).ToLower().Contains(busquedaTexto) ||

                //Filtro por categoría (se verifica si el texto de búsqueda está contenido en la categoría)
                t.Categoria.ToLower().Contains(busquedaTexto) ||

                //Filtro por palabras clave asociadas a la categoría
                PalabraClaveEnCategoria(busquedaTexto, t.Categoria)
            ).ToList();

            //Actualizamos la vista con los trabajos filtrados
            dgv_NovInvest.Rows.Clear();
            foreach (var trabajo in trabajosFiltrados)
            {
                string nombreUsuario = ObtenerUsuario(trabajo.IdUsuario);
                double valoracion = CalcularPromedio(trabajo.IdTrabajo);
                dgv_NovInvest.Rows.Add(trabajo.Titulo, trabajo.Descripcion, nombreUsuario, valoracion.ToString("N1"), trabajo.Categoria, trabajo.IdTrabajo);
            }
        }
    }
}
