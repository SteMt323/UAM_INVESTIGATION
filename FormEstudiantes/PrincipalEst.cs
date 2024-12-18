﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UAM_INVESTIGATION.FormAdmin;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class PrincipalEst : Form
    {
        private string nombreUsuario;
        private string correoUsuario;
        private string cifUsuario;
        private int idUsuario;
        public PrincipalEst(string nombreUsuario, string correoUsuario, string cifUsuario, int idUsuario)
        {
            InitializeComponent();
            this.nombreUsuario = nombreUsuario;
            this.correoUsuario = correoUsuario;
            this.cifUsuario = cifUsuario;
            this.idUsuario = idUsuario;
        }

        private void btn_minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PrincipalEst_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"{nombreUsuario}";
            lblCorreo.Text = $"{correoUsuario}";
            lblCif.Text = $"{cifUsuario}";
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que deseas cerrar sesión?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                pantalla_Principal pantalla_Principal = new pantalla_Principal();
                pantalla_Principal.Show();
            }
                
        }

        private void Btn_Perfil_Click(object sender, EventArgs e)
        {
            EditarPerfilEst editarPerfilEst = new EditarPerfilEst(correoUsuario);
            pnl_Content.Controls.Clear();

            //Agregar el UserControl al Panel
            editarPerfilEst.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(editarPerfilEst);
        }

        private void Btn_SubirTrabajos_Click(object sender, EventArgs e)
        {
            TrabajoSubir trabajoSubir = new TrabajoSubir(idUsuario);
            pnl_Content.Controls.Clear();

            trabajoSubir.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(trabajoSubir);
        }

        private void Btn_EditarTrabajos_Click(object sender, EventArgs e)
        {
            TrabajoEditar trabajoEditar = new TrabajoEditar(idUsuario);
            pnl_Content.Controls.Clear();

            trabajoEditar.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(trabajoEditar);
        }

        private void Btn_NovInvest_Click(object sender, EventArgs e)
        {
            NovInvest novInvest  = new NovInvest(idUsuario);
            pnl_Content.Controls.Clear();

            novInvest.Dock = DockStyle.Fill;
            pnl_Content.Controls.Add(novInvest);
        }
    }
}
