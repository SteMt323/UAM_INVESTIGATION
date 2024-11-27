using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAM_INVESTIGATION.FormEstudiantes
{
    public partial class NovInvest : UserControl
    {
        private int idTrabajo;
        private int idUsuario;
        public NovInvest(int idUsuario)
        {
            InitializeComponent();
            this.idUsuario = idUsuario;
        }

        private void txt_Busqueda_Enter(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text == "Buscar Trabajos...")
            {
                txt_Busqueda.Text = "";
                txt_Busqueda.ForeColor = Color.Black;
            }
        }

        private void txt_Busqueda_Leave(object sender, EventArgs e)
        {
            if (txt_Busqueda.Text == "")
            {
                txt_Busqueda.Text = "Buscar Trabajos...";
                txt_Busqueda.ForeColor = Color.DimGray;
            }
        }

        private void btn_Valoracion_Click(object sender, EventArgs e)
        {
            Calificar calificar = new Calificar(idTrabajo, idUsuario);
            calificar.ShowDialog();
        }

        private void Btn_Comentar_Click(object sender, EventArgs e)
        {
            Comentarios comentarios = new Comentarios(idTrabajo, idUsuario);
            comentarios.ShowDialog();
        }
    }
}
