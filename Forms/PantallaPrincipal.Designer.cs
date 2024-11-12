namespace UAM_INVESTIGATION
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_AdminRegis = new FontAwesome.Sharp.IconButton();
            this.Btn_UserRegis = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_AdminRegis);
            this.panel1.Controls.Add(this.Btn_UserRegis);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 450);
            this.panel1.TabIndex = 0;
            // 
            // btn_AdminRegis
            // 
            this.btn_AdminRegis.AutoSize = true;
            this.btn_AdminRegis.BackColor = System.Drawing.Color.Teal;
            this.btn_AdminRegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AdminRegis.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdminRegis.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.btn_AdminRegis.IconColor = System.Drawing.Color.Black;
            this.btn_AdminRegis.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_AdminRegis.IconSize = 38;
            this.btn_AdminRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AdminRegis.Location = new System.Drawing.Point(3, 245);
            this.btn_AdminRegis.Name = "btn_AdminRegis";
            this.btn_AdminRegis.Size = new System.Drawing.Size(185, 54);
            this.btn_AdminRegis.TabIndex = 2;
            this.btn_AdminRegis.Text = "Admin";
            this.btn_AdminRegis.UseVisualStyleBackColor = false;
            this.btn_AdminRegis.Click += new System.EventHandler(this.btn_AdminRegis_Click);
            // 
            // Btn_UserRegis
            // 
            this.Btn_UserRegis.AutoSize = true;
            this.Btn_UserRegis.BackColor = System.Drawing.Color.Teal;
            this.Btn_UserRegis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_UserRegis.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UserRegis.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btn_UserRegis.IconColor = System.Drawing.Color.Black;
            this.Btn_UserRegis.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_UserRegis.IconSize = 30;
            this.Btn_UserRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserRegis.Location = new System.Drawing.Point(3, 185);
            this.Btn_UserRegis.Name = "Btn_UserRegis";
            this.Btn_UserRegis.Size = new System.Drawing.Size(185, 54);
            this.Btn_UserRegis.TabIndex = 1;
            this.Btn_UserRegis.Text = "Usuario";
            this.Btn_UserRegis.UseVisualStyleBackColor = false;
            this.Btn_UserRegis.Click += new System.EventHandler(this.Btn_UserRegis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::UAM_INVESTIGATION.Properties.Resources.logo_uam_1png;
            this.pictureBox1.Location = new System.Drawing.Point(11, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel1.Location = new System.Drawing.Point(147, 131);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(209, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "UAM INVESTIGATIONS";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Enabled = false;
            this.pictureBox2.Image = global::UAM_INVESTIGATION.Properties.Resources.uam_internacional_portada;
            this.pictureBox2.Location = new System.Drawing.Point(195, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(688, 459);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::UAM_INVESTIGATION.Properties.Resources.logo_uam_2;
            this.pictureBox3.Location = new System.Drawing.Point(147, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(216, 69);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.metroLabel1);
            this.panel2.Location = new System.Drawing.Point(247, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(498, 175);
            this.panel2.TabIndex = 3;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private FontAwesome.Sharp.IconButton Btn_UserRegis;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btn_AdminRegis;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
    }
}

