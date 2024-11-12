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
    public partial class InicioSesionUserEst : Form
    {
        public InicioSesionUserEst()
        {
            InitializeComponent();
        }

        private void btn_InicioSesion_Click(object sender, EventArgs e)
        {
            string entrada = txt_CorreoCif.Text;
            string contrasenia = txt_Contrasenia.Text;
            string correo = null;
            string cif = null;
            int type = 0;

            //Validación si es correo
            if (entrada.Contains("@") && (entrada.EndsWith(".com") || entrada.EndsWith(".ni")))
            {
                correo = entrada; //Si es correo se guarda como correo
                type = 1;
            }
            else if (entrada.Length == 8 && entrada.All(char.IsDigit))
            {
                cif = entrada; //Si son 8 carácteres alfanuméricos, se guarda como cif
                type = 2;
            }

            InitRegis initRegis = new InitRegis();
            bool inicioValido = false;
            if(type == 1)
            {
                if (!inicioValido && !string.IsNullOrEmpty(correo))
                {
                    inicioValido = initRegis.IniciarSesionEstCorreo(correo, contrasenia);
                }
            }
            if(type == 2)
            {
                if (!inicioValido && !string.IsNullOrEmpty(cif))
                {
                    inicioValido = initRegis.IniciarSesionEstCif(cif, contrasenia);
                }
            }

            if (inicioValido)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Redirigir a la pantalla principal de Estudiantes

            }
            else
            {
                MessageBox.Show("Correo/cif o contraseña son inválidas", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void InicioSesionUserEst_Load(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;
        }

        private void Lnk_Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUserEst registroUserEst = new RegistroUserEst();
            registroUserEst.ShowDialog();
        }
    }
}
