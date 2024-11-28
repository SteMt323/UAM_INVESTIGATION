using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using Spire.PdfViewer.Forms;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class ArchivosTrabajos : Form
    {
        private string rutaArchivo;
        private int IdTrabajo;
        public ArchivosTrabajos(int idTrabajo)
        {
            InitializeComponent();
            this.IdTrabajo = idTrabajo;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarArchivo()
        {
            ControlTrabajos controlTrabajos = new ControlTrabajos();
            rutaArchivo = controlTrabajos.ObtenerRutaArchivo(IdTrabajo);

            if (string.IsNullOrEmpty(rutaArchivo) || !File.Exists(rutaArchivo))
            {
                MessageBox.Show("No se encontro el archivo del trabajo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MostrarVistaPrevia(rutaArchivo);
        }

        private void MostrarVistaPrevia(string rutaArchivo)
        {
            Spire.PdfViewer.Forms.PdfViewer pdfViewer = new Spire.PdfViewer.Forms.PdfViewer
            {
                Dock = DockStyle.Fill,
            };

            pdfViewer.LoadFromFile(rutaArchivo); // Cargar el archivo
            pnlVistaPrevia.Controls.Clear(); // Asegúrate de limpiar antes
            pnlVistaPrevia.Controls.Add(pdfViewer); // Añade al panel
        }

        private void ArchivosTrabajos_Load(object sender, EventArgs e)
        {
            CargarArchivo();
        }

        private void Btn_Descargar_Click(object sender, EventArgs e)
        {
            // Verificar que la ruta del archivo es válida
            if (string.IsNullOrEmpty(rutaArchivo) || !File.Exists(rutaArchivo))
            {
                MessageBox.Show("No se encontró el archivo del trabajo para descargar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el cuadro de diálogo para guardar el archivo
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
                saveFileDialog.FileName = $"Trabajo_{IdTrabajo}.pdf"; // Nombre sugerido para el archivo
                saveFileDialog.Title = "Guardar archivo del trabajo";

                // Mostrar el diálogo al usuario
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Copiar el archivo a la ubicación seleccionada
                        File.Copy(rutaArchivo, saveFileDialog.FileName, true);
                        MessageBox.Show("El archivo se descargó correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ocurrió un error al descargar el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
