using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Estructuras;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class Calificar : Form
    {
        private int idTrabajo;
        private int idUsuario;
        private int currentRating = 0; // Variable para guardar la calificación seleccionada
        public Calificar(int idTrabajo, int idUsuario)
        {
            InitializeComponent();
            this.idTrabajo = idTrabajo;
            this.idUsuario = idUsuario;
            // Asociar eventos a las estrellas
            for (int i = 1; i <= 5; i++)
            {
                var starButton = this.Controls.Find($"btn_Star{i}", true).FirstOrDefault() as FontAwesome.Sharp.IconButton;
                if (starButton != null)
                {
                    starButton.MouseEnter += StarButton_MouseEnter;
                    starButton.MouseLeave += StarButton_MouseLeave;
                }
            }
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void StarButton_Click(object sender, EventArgs e)
        {
            var clickedButton = sender as FontAwesome.Sharp.IconButton;
            if (clickedButton == null) return;

            //Obtener la calificación seleccionada desde el botón clickeado
            currentRating = int.Parse(clickedButton.Tag.ToString());

            //Actualizar la apariencia de todas las estrellas
            for (int i = 1; i <= 5; i++)
            {
                //Encuentra el botón correspondiente
                var starButton = this.Controls.Find($"btn_Star{i}", true).FirstOrDefault() as FontAwesome.Sharp.IconButton;
                if (starButton != null)
                {
                    //Si el índice es menor o igual a la calificación seleccionada, se rellena
                    starButton.IconFont = i <= currentRating
                        ? FontAwesome.Sharp.IconFont.Solid
                        : FontAwesome.Sharp.IconFont.Regular;
                }
            }
        }

        private void Btn_Valorar_Click(object sender, EventArgs e)
        {
            if (currentRating == 0)
            {
                MessageBox.Show("Por favor, selecciona una calificación antes de guardar.");
                return;
            }

            //Aquí Guardar
            GuardarOActualizarValoracion(idTrabajo, idUsuario, currentRating);
            MessageBox.Show($"Calificación guardada: {currentRating} estrellas.");

        }


        //__________________________________________________________________________________________________________________
        private void StarButton_MouseEnter(object sender, EventArgs e)
        {
            var hoveredButton = sender as FontAwesome.Sharp.IconButton;
            if (hoveredButton == null) return;

            int hoverRating = int.Parse(hoveredButton.Tag.ToString());

            // Cambia la apariencia temporalmente
            for (int i = 1; i <= 5; i++)
            {
                var starButton = this.Controls.Find($"btn_Star{i}", true).FirstOrDefault() as FontAwesome.Sharp.IconButton;
                if (starButton != null)
                {
                    starButton.IconFont = i <= hoverRating
                        ? FontAwesome.Sharp.IconFont.Solid
                        : FontAwesome.Sharp.IconFont.Regular;
                }
            }
        }

        private void StarButton_MouseLeave(object sender, EventArgs e)
        {
            // Vuelve a mostrar el estado según la calificación actual
            for (int i = 1; i <= 5; i++)
            {
                var starButton = this.Controls.Find($"btn_Star{i}", true).FirstOrDefault() as FontAwesome.Sharp.IconButton;
                if (starButton != null)
                {
                    starButton.IconFont = i <= currentRating
                        ? FontAwesome.Sharp.IconFont.Solid
                        : FontAwesome.Sharp.IconFont.Regular;
                }
            }
        }

        //_____________________________________________________________________________________________
        //Método para implementar la lógica
        private void GuardarOActualizarValoracion(int idTrabajo, int idUsuario, int nuevaCalificacion)
        {
            try
            {
                Random random = new Random();
                //Leer todas las valoraciones
                ValorarTrabajos valorarTrabajos = new ValorarTrabajos();
                var valoraciones = valorarTrabajos.LeerValoraciones();
                var valoracionExistente = valoraciones.FirstOrDefault(v => v.IdTrabajo == idTrabajo && v.IdUsuario == idUsuario);

                if(!valoracionExistente.Equals(default(Valoracion)))
                {
                    if (valoracionExistente.Calificacion != 0)
                    {
                        //Si la valoracion existe, actualizamos
                        valoracionExistente.Calificacion = nuevaCalificacion;
                        valorarTrabajos.ActualizarValoraciones(idTrabajo, idUsuario, nuevaCalificacion);
                        MessageBox.Show("Valoración actualizada correctamente.");
                    }
                    
                }
                else
                {
                    //Si no existe la valoración, agregamos una nueva
                    var valoracionNueva = new Valoracion
                    {
                        IdCalificacion = random.Next(1000, 9999),
                        IdTrabajo = idTrabajo,
                        IdUsuario = idUsuario,
                        Calificacion = nuevaCalificacion
                    };
                    valorarTrabajos.AgregarValoracion(valoracionNueva);
                    MessageBox.Show("Nueva valoración guardada correctamente.");
                }

            }catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

    }
}
