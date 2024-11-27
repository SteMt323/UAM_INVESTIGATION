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
using UAM_INVESTIGATION.Estructuras;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class Comentarios : Form
    {
        private int idTrabajo;
        private int idUsuario;
        public Comentarios(int idTrabajo, int idUsuario)
        {
            InitializeComponent();
            this.idTrabajo = idTrabajo;
            this.idUsuario = idUsuario;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Btn_Comentar_Click(object sender, EventArgs e)
        {
            if (txt_Comentario.Text == "")
            {
                MessageBox.Show("Por favor, escribe algo antes de publicar tu comentario.");
                return;
            }
            //Aquí Guardar
            GuardarOActualizarComentario(idTrabajo, idUsuario, txt_Comentario.Text);

        }

        private void GuardarOActualizarComentario(int idTrabajo, int idUsuario, string nuevoComentario)
        {
            try
            {
                Random random = new Random();

                //Leer comentarios
                ComentarTrabajos comentarTrabajos = new ComentarTrabajos();
                var comentarios = comentarTrabajos.LeerComenarios();
                var comentarioExistente = comentarios.FirstOrDefault(v => v.IdTrabajo == idTrabajo && v.IdUsuario == idUsuario);

                if (!comentarioExistente.Equals(default(Comentario)))
                {
                    if (comentarioExistente.TextoComentario != null)
                    {
                        //Si el comentario existe, actualizamos
                        comentarioExistente.TextoComentario = nuevoComentario;
                        comentarTrabajos.ActualizarComentarios(idUsuario, idTrabajo, nuevoComentario);
                        MessageBox.Show("Comentario actualizado exitosamente.");
                    }
                }
                else
                {
                    //Sino existe el comentario, se agrega...
                    var comentarioNuevo = new Comentario
                    {
                        IdComentario = random.Next(1000, 9999),
                        IdUsuario = idUsuario,
                        IdTrabajo = idTrabajo,
                        TextoComentario = nuevoComentario
                    };
                    comentarTrabajos.AgregarComentario(comentarioNuevo);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }

        private void txt_Comentario_Enter(object sender, EventArgs e)
        {
            if (txt_Comentario.Text == "Escribe algo...")
            {
                txt_Comentario.Text = "";
                txt_Comentario.ForeColor = Color.Black;
            }
        }

        private void txt_Comentario_Leave(object sender, EventArgs e)
        {
            if (txt_Comentario.Text == "")
            {
                txt_Comentario.Text = "Escribe algo...";
                txt_Comentario.ForeColor = Color.DimGray;
            }
        }
    }
}
