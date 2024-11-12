using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using UAM_INVESTIGATION.Estructuras;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.Forms
{
    public partial class RegistroUserAdmin : Form
    {
        public RegistroUserAdmin()
        {
            InitializeComponent();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            string code = txt_code_access.Text;
            string correo = txt_Correo.Text;
            string contrasenia = txt_Contrasenia.Text;
            string nombre = txt_Nombre.Text;

            if (string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(code) || string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Todos los campos deben de llenarse, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(code.Equals("UAM_INVESTIGATION")))
            {
                MessageBox.Show("El código de acceso es inválido, por favor vuelva a intentarlo...",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!(correo.Contains("@") && (correo.EndsWith(".com") || correo.EndsWith(".ni"))))
            {
                MessageBox.Show("El correo electrónico es inválido, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (contrasenia.Length < 8)
            {
                MessageBox.Show("La contraseña es demasiado débil, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (char c in nombre)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("El nombre no puede contener carácteres alfanuméricos, por favor vuelva a intentarlo.",
                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Crear Nuevo Usuario
            UsuarioAdmin admin = new UsuarioAdmin(nombre, correo, contrasenia);
            //Registrarlo
            InitRegis initRegis = new InitRegis();
            initRegis.RegistrarUsuarioAdmin(admin);
            MessageBox.Show("Usuario registrado exitosamente!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void RegistroUserAdmin_Load(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;
            txt_code_access.UseSystemPasswordChar = true;
        }

        private void show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (show_Password.Checked)
            {
                txt_Contrasenia.UseSystemPasswordChar = false; //Mostrar la contraseña
            }
            else
            {
                txt_Contrasenia.UseSystemPasswordChar = true; //Ocultar Contraseña
            }
        }

        private void show_code_CheckedChanged(object sender, EventArgs e)
        {
            if (show_code.Checked)
            {
                txt_code_access.UseSystemPasswordChar = false; //Mostrar la contraseña
            }
            else
            {
                txt_code_access.UseSystemPasswordChar = true; //Ocultar Contraseña
            }
        }

        private void Lnk_SesionAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Mostrar Formulario Inicio Sesion Admin
            InicioSesionUserAdmin inicioSesionUserAdmin = new InicioSesionUserAdmin();
            inicioSesionUserAdmin.ShowDialog();
            this.Hide();
        }
    }
}
