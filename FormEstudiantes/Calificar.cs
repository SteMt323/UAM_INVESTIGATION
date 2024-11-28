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

                    starButton.Click += StarButton_Click;
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

            // Obtener la calificación seleccionada desde el botón clickeado
            currentRating = int.Parse(clickedButton.Tag.ToString());

            // Actualizar la apariencia de todas las estrellas
            for (int i = 1; i <= 5; i++)
            {
                // Encuentra el botón correspondiente
                var starButton = this.Controls.Find($"btn_Star{i}", true).FirstOrDefault() as FontAwesome.Sharp.IconButton;
                if (starButton != null)
                {
                    // Si el índice es menor o igual a la calificación seleccionada, se rellena
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
            try
            {
                bool valoracionExistente = ExisteValoracion(idTrabajo, idUsuario);
                if (valoracionExistente)
                {
                    ActualizarValoracion(idTrabajo, idUsuario, currentRating);
                }
                else
                {
                    AgregarNuevaValoracion(idTrabajo, idUsuario, currentRating);
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            MessageBox.Show($"Calificación guardada: {currentRating} estrellas.");

        }


        //__________________________________________________________________________________________________________________
        private void StarButton_MouseEnter(object sender, EventArgs e)
        {
            // Solo actualizar el estado si aún no se ha seleccionado una calificación
            if (currentRating == 0)
            {
                var hoveredButton = sender as FontAwesome.Sharp.IconButton;
                if (hoveredButton == null) return;

                int hoverRating = int.Parse(hoveredButton.Tag.ToString());

                // Cambia la apariencia temporalmente (solo si no se ha seleccionado una calificación)
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
        }

        private void StarButton_MouseLeave(object sender, EventArgs e)
        {
            // Solo volver al estado original si no se ha seleccionado una calificación
            if (currentRating == 0)
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
        }

        //_____________________________________________________________________________________________
        //Método para implementar la lógica
        private bool ExisteValoracion(int idTrabajo, int idUsuario)
        {
            ValorarTrabajos valorarTrabajos = new ValorarTrabajos();
            var valoraciones = valorarTrabajos.LeerValoraciones();

            // Comprobamos si existe alguna valoración con el idTrabajo y idUsuario
            foreach (var valoracion in valoraciones)
            {
                if (valoracion.IdTrabajo == idTrabajo && valoracion.IdUsuario == idUsuario)
                {
                    return true;  // Si se encuentra la valoración, retornamos verdadero
                }
            }
            return false;  // Si no se encuentra, retornamos falso
        }


        private void ActualizarValoracion(int idTrabajo, int idUsuario, int nuevaCalificacion)
        {
            ValorarTrabajos valorarTrabajos = new ValorarTrabajos();
            valorarTrabajos.ActualizarValoraciones(idTrabajo, idUsuario, currentRating);
            MessageBox.Show("Valoración actualizada correctamente.");
        }

        private void AgregarNuevaValoracion(int idTrabajo, int idUsuario, int nuevaCalificacion)
        {
            Random random = new Random();
            var valoracionNueva = new Valoracion
            {
                IdCalificacion = random.Next(1000, 9999),
                IdTrabajo = idTrabajo,
                IdUsuario = idUsuario,
                Calificacion = nuevaCalificacion
            };
            ValorarTrabajos valorarTrabajos = new ValorarTrabajos();
            valorarTrabajos.AgregarValoracion(valoracionNueva);
            MessageBox.Show("Nueva valoración guardada correctamente.");
        }

    }
}
