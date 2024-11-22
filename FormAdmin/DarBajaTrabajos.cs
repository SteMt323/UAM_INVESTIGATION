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

namespace UAM_INVESTIGATION.FormAdmin
{
    public partial class DarBajaTrabajos : UserControl
    {
        private ControlTrabajos controlTrabajos;
        public DarBajaTrabajos()
        {
            InitializeComponent();
            controlTrabajos = new ControlTrabajos();
        }

        private void CargarTrabajos()
        {

            var trabajos = controlTrabajos.ObtenerTrabajos();
                
            dataGridViewTrabajos.Rows.Clear();


            foreach (var trabajo in trabajos)
            {
                dataGridViewTrabajos.Rows.Add(trabajo.IdTrabajo, trabajo.Titulo, trabajo.Categoria, trabajo.Descripcion, trabajo.Estado ? "Vigente" : "Dado de Baja");
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
            lbl_IdTrabajo.Text = "";
            lbl_Titulo.Text = "";
            lbl_Categoria.Text = "";
            lbl_Descripcion.Text = "";
            lbl_Estado.Text = "";
            dataGridViewTrabajos.ClearSelection();
        }

        private void dataGridViewTrabajos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTrabajos.SelectedRows.Count > 0)
            {
                var filaSeleccionada = dataGridViewTrabajos.SelectedRows[0];

                lbl_IdTrabajo.Text = filaSeleccionada.Cells[0].Value != null ? filaSeleccionada.Cells[0].Value.ToString() : "N/A";
                lbl_Titulo.Text = filaSeleccionada.Cells[1].Value != null ? filaSeleccionada.Cells[1].Value.ToString() : "N/A";
                lbl_Categoria.Text = filaSeleccionada.Cells[2].Value != null ? filaSeleccionada.Cells[2].Value.ToString() : "N/A";
                lbl_Descripcion.Text = filaSeleccionada.Cells[2].Value != null ? filaSeleccionada.Cells[3].Value.ToString() : "N/A";
                lbl_Estado.Text = filaSeleccionada.Cells[2].Value != null ? filaSeleccionada.Cells[4].Value.ToString() : "N/A";
            }
        }

        private void DarBajaTrabajos_Load(object sender, EventArgs e)
        {
            CargarTrabajos();
        }

        private void btn_DarDeBaja_Click(object sender, EventArgs e)
        {
            if (dataGridViewTrabajos.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas dar de baja a este trabajo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string tituloSeleccionado = dataGridViewTrabajos.SelectedRows[0].Cells[0].Value?.ToString();
                    if (!string.IsNullOrEmpty(tituloSeleccionado))
                    {
                        var trabajo = controlTrabajos.ObtenerTrabajos()
                            .FirstOrDefault(t => t.Titulo == tituloSeleccionado);
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
    }
}
