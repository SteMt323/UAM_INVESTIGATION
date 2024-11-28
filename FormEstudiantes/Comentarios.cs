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
            try
            {
                bool comentariosExistentes = ExisteComentario(idTrabajo, idUsuario);
                if (comentariosExistentes)
                {
                    ActualizarComentario(idTrabajo, idUsuario, txt_Comentario.Text);
                }
                else
                {
                    AgregarNuevoComentario(idTrabajo, idUsuario, txt_Comentario.Text);
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            MessageBox.Show("Comentario Guardado");
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

        private bool ExisteComentario(int idTrabajo, int idUsuario)
        {
            ComentarTrabajos comentarTrabajos = new ComentarTrabajos();
            var comentarios = comentarTrabajos.LeerComenarios();

            foreach (var comentario in comentarios)
            {
                if (comentario.IdTrabajo ==  idTrabajo && comentario.IdUsuario == idUsuario)
                {
                    return true;
                }
            }
            return false;
        }

        private void ActualizarComentario (int idTrabajo, int idUsuario, string nuevoComentario)
        {
            ComentarTrabajos comentarTrabajos = new ComentarTrabajos();
            comentarTrabajos.ActualizarComentarios(idUsuario, idTrabajo, nuevoComentario);
            MessageBox.Show("Comentario actualizado correctamente.");
        }

        private void AgregarNuevoComentario(int idTrabajo, int idUsuario, string nuevoComentario)
        {
            Random random = new Random();
            var comentario = new Comentario
            {
                IdComentario = idTrabajo,
                IdUsuario = idUsuario,
                IdTrabajo = idTrabajo,
                TextoComentario = nuevoComentario
            };
            ComentarTrabajos comentarTrabajos = new ComentarTrabajos();
            comentarTrabajos.AgregarComentario(comentario);
            MessageBox.Show("Comentario actualizado correctamente.");
        }
    }
}
