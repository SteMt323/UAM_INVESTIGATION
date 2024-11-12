using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Estructuras;
using UAM_INVESTIGATION.Helpers;

namespace UAM_INVESTIGATION.Forms
{
    public partial class RegistroUserEst : Form
    {
        public RegistroUserEst()
        {
            InitializeComponent();
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            string correo = txt_Correo.Text;
            string cif = txt_Cif.Text;
            string contrasenia = txt_Contrasenia.Text;
            string nombre = txt_Nombre.Text;
            string carrera = txt_Carrera.Text;

            if(string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(cif) || string.IsNullOrEmpty(contrasenia) || string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(carrera))
            {
                MessageBox.Show("Todos los campos deben de llenarse, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(correo.Contains("@") && (correo.EndsWith(".com") || correo.EndsWith(".ni"))))
            {
                MessageBox.Show("El correo electrónico es inválido, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cif.Length != 8 || !(cif.All(char.IsDigit)))
            {
                MessageBox.Show("El cif es inválido (8 dígitos númericos), por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (contrasenia.Length < 8)
            {
                MessageBox.Show("La contraseña es demasiado débil, por favor vuelva a intentarlo.",
                        "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach(char c in nombre)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("El nombre no puede contener carácteres alfanuméricos, por favor vuelva a intentarlo.",
                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            foreach (char c in carrera)
            {
                if (char.IsDigit(c))
                {
                    MessageBox.Show("La carrera no puede contener carácteres alfanuméricos, por favor vuelva a intentarlo.",
                            "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            //Crear nuevo Usuario
            UsuarioEst nuevoUsuarioEst = new UsuarioEst(nombre, correo, cif, contrasenia, carrera);

            //Registrarlo
            InitRegis regis = new InitRegis();
            regis.RegistrarUsuarioEst(nuevoUsuarioEst);

            MessageBox.Show("Usuario registrado exitosamente!", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
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

        private void RegistroUserEst_Load(object sender, EventArgs e)
        {
            txt_Contrasenia.UseSystemPasswordChar = true;
        }

        private void Lnk_SesionEst_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InicioSesionUserEst inicioSesionUserEst = new InicioSesionUserEst();
            inicioSesionUserEst.ShowDialog();
            this.Hide();
        }
    }
}
