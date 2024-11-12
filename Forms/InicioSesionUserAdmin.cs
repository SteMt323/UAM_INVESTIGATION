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

namespace UAM_INVESTIGATION.Forms
{
    public partial class InicioSesionUserAdmin : Form
    {
        public InicioSesionUserAdmin()
        {
            InitializeComponent();
        }

        private void btn_InicioSesion_Click(object sender, EventArgs e)
        {
            string entrada = txt_Correo.Text;
            string contrasenia = txt_Contrasenia.Text;
            string correo = entrada;

            InitRegis initRegis = new InitRegis();
            bool inicioValido = false;
            if (!inicioValido && !string.IsNullOrEmpty(correo))
            {
                inicioValido = initRegis.IniciarSesionAdmin(correo, contrasenia);
            }

            if (inicioValido)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Redirigir a la pantalla principal de Admins

            }
            else
            {
                MessageBox.Show("Correo o contraseña son inválidas", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_MostrarContrasenia_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_MostrarContrasenia.Checked)
            {
                txt_Contrasenia.UseSystemPasswordChar = false; //Mostrar la contraseña
            }
            else
            {
                txt_Contrasenia.UseSystemPasswordChar = true; //Ocultar Contraseña
            }
        }

        private void InicioSesionUserAdmin_Load(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;
        }

        private void Lnk_Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUserAdmin registroUserAdmin = new RegistroUserAdmin();
            registroUserAdmin.ShowDialog();
        }
    }
}
