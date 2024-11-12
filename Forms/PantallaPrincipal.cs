using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.Forms;

namespace UAM_INVESTIGATION
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Btn_UserRegis_Click(object sender, EventArgs e)
        {
            //Mostrar Formulario Inicio Sesion Estudiantes
            InicioSesionUserEst inicioSesionUserEst = new InicioSesionUserEst();
            inicioSesionUserEst.ShowDialog();
        }

        private void btn_AdminRegis_Click(object sender, EventArgs e)
        {
            InicioSesionUserAdmin inicioSesionUserAdmin = new InicioSesionUserAdmin();
            inicioSesionUserAdmin.ShowDialog();
        }
    }
}
