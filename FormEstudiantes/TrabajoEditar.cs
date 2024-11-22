using FontAwesome.Sharp;
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

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class TrabajoEditar : UserControl
    {
        private ControlTrabajos controlTrabajos;
        private int IdEstudiante;
        public TrabajoEditar(int idEstudiante)
        {
            InitializeComponent();
            controlTrabajos = new ControlTrabajos();
            IdEstudiante = idEstudiante;
        }

        private void CargarTrabajos()
        {

            var trabajos = controlTrabajos.ObtenerTrabajos()
                .Where(t => t.IdUsuario == IdEstudiante && t.Estado)
                .ToList();


            dataGridViewTrabajos.Rows.Clear();


            foreach (var trabajo in trabajos)
            {
                dataGridViewTrabajos.Rows.Add(trabajo.Titulo, trabajo.Categoria, trabajo.Descripcion);
            }
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

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Titulo.Clear();
            cmb_Categoria.SelectedIndex = -1;
            txt_Descripcion.Clear();
            dataGridViewTrabajos.ClearSelection();
        }

        private void dataGridViewTrabajos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTrabajos.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridViewTrabajos.SelectedRows[0];

                txt_Titulo.Text = filaSeleccionada.Cells[0].Value != null ? filaSeleccionada.Cells[0].Value.ToString() : "N/A";
                cmb_Categoria.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[1].Value.ToString() : "N/A";
                txt_Descripcion.Text = filaSeleccionada.Cells[2].Value != null ? filaSeleccionada.Cells[2].Value.ToString() : "N/A";
            }
        }

        private void TrabajoEditar_Load(object sender, EventArgs e)
        {
            CargarTrabajos();
        }

        private void btn_DarDeBaja_Click(object sender, EventArgs e)
        {
            if(dataGridViewTrabajos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas dar de baja a este trabajo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tituloSeleccionado = dataGridViewTrabajos.SelectedRows[0].Cells[0].Value?.ToString();
                    if (!string.IsNullOrEmpty(tituloSeleccionado))
                    {
                        var trabajo = controlTrabajos.ObtenerTrabajos()
                            .FirstOrDefault(t => t.Titulo == tituloSeleccionado && t.IdUsuario == IdEstudiante);
                        try
                        {
                            
                            controlTrabajos.EliminarTrabajo(trabajo.IdTrabajo);  

                            MessageBox.Show("El trabajo ha sido dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarTrabajos();  
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hubo un error al dar de baja el trabajo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Por favor, seleccione un trabajo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrabajos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas actualizar este trabajo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tituloOriginal = dataGridViewTrabajos.SelectedRows[0].Cells[0].Value?.ToString();

                    if (!string.IsNullOrEmpty(tituloOriginal)){
                        var trabajo = controlTrabajos.ObtenerTrabajos()
                            .FirstOrDefault(t => t.Titulo == tituloOriginal && t.IdUsuario == IdEstudiante);

                        string nuevoTitulo = txt_Titulo.Text.Trim();
                        string nuevaCategoria = cmb_Categoria.Text.Trim();
                        string nuevaDescripcion = txt_Descripcion.Text.Trim();

                        if (string.IsNullOrEmpty(nuevoTitulo) || string.IsNullOrEmpty(nuevaCategoria) || string.IsNullOrEmpty(nuevaDescripcion))
                        {
                            MessageBox.Show("Todos los campos deben estar llenos para actualizar el trabajo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        try
                        {
                            controlTrabajos.ActualizarTrabajo(
                                trabajo.IdTrabajo,
                                nuevoTitulo,
                                nuevaDescripcion,
                                nuevaCategoria
                            );
                            MessageBox.Show("El trabajo ha sido actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarTrabajos();  // Recargar la lista de trabajos
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hubo un error al actualizar el trabajo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un trabajo para actualizar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
