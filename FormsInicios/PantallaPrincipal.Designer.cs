namespace UAM_INVESTIGATION
{
    partial class pantalla_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pantalla_Principal));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Btn_Us = new FontAwesome.Sharp.IconButton();
            this.Btn_Help = new FontAwesome.Sharp.IconButton();
            this.Btn_AdminRegis = new FontAwesome.Sharp.IconButton();
            this.Btn_UserRegis = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.img_Home = new System.Windows.Forms.PictureBox();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icon_form_home = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_form_tittle = new System.Windows.Forms.Label();
            this.Panel_Tittle = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_form_home)).BeginInit();
            this.Panel_Tittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.Btn_Us);
            this.PanelMenu.Controls.Add(this.Btn_Help);
            this.PanelMenu.Controls.Add(this.Btn_AdminRegis);
            this.PanelMenu.Controls.Add(this.Btn_UserRegis);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(238, 506);
            this.PanelMenu.TabIndex = 3;
            // 
            // Btn_Us
            // 
            this.Btn_Us.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Us.FlatAppearance.BorderSize = 0;
            this.Btn_Us.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Us.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Us.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Us.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.Btn_Us.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Us.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Us.IconSize = 20;
            this.Btn_Us.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Us.Location = new System.Drawing.Point(0, 446);
            this.Btn_Us.Name = "Btn_Us";
            this.Btn_Us.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Us.Size = new System.Drawing.Size(238, 30);
            this.Btn_Us.TabIndex = 3;
            this.Btn_Us.Text = "Sobre Nosotros";
            this.Btn_Us.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Us.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Us.UseVisualStyleBackColor = true;
            this.Btn_Us.Click += new System.EventHandler(this.Btn_Us_Click);
            // 
            // Btn_Help
            // 
            this.Btn_Help.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_Help.FlatAppearance.BorderSize = 0;
            this.Btn_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Help.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Help.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Help.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.Btn_Help.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Help.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Help.IconSize = 20;
            this.Btn_Help.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Help.Location = new System.Drawing.Point(0, 476);
            this.Btn_Help.Name = "Btn_Help";
            this.Btn_Help.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Help.Size = new System.Drawing.Size(238, 30);
            this.Btn_Help.TabIndex = 4;
            this.Btn_Help.Text = "Ayuda";
            this.Btn_Help.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Help.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Help.UseVisualStyleBackColor = true;
            this.Btn_Help.Click += new System.EventHandler(this.Btn_Help_Click);
            // 
            // Btn_AdminRegis
            // 
            this.Btn_AdminRegis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_AdminRegis.FlatAppearance.BorderSize = 0;
            this.Btn_AdminRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_AdminRegis.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_AdminRegis.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_AdminRegis.IconChar = FontAwesome.Sharp.IconChar.UsersGear;
            this.Btn_AdminRegis.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_AdminRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_AdminRegis.IconSize = 30;
            this.Btn_AdminRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AdminRegis.Location = new System.Drawing.Point(0, 280);
            this.Btn_AdminRegis.Name = "Btn_AdminRegis";
            this.Btn_AdminRegis.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_AdminRegis.Size = new System.Drawing.Size(238, 60);
            this.Btn_AdminRegis.TabIndex = 2;
            this.Btn_AdminRegis.Text = "ADMIN";
            this.Btn_AdminRegis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_AdminRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_AdminRegis.UseVisualStyleBackColor = true;
            this.Btn_AdminRegis.Click += new System.EventHandler(this.Btn_AdminRegis_Click_1);
            // 
            // Btn_UserRegis
            // 
            this.Btn_UserRegis.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_UserRegis.FlatAppearance.BorderSize = 0;
            this.Btn_UserRegis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_UserRegis.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_UserRegis.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_UserRegis.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btn_UserRegis.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_UserRegis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_UserRegis.IconSize = 30;
            this.Btn_UserRegis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserRegis.Location = new System.Drawing.Point(0, 220);
            this.Btn_UserRegis.Name = "Btn_UserRegis";
            this.Btn_UserRegis.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_UserRegis.Size = new System.Drawing.Size(238, 60);
            this.Btn_UserRegis.TabIndex = 1;
            this.Btn_UserRegis.Text = "ESTUDIANTE";
            this.Btn_UserRegis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_UserRegis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_UserRegis.UseVisualStyleBackColor = true;
            this.Btn_UserRegis.Click += new System.EventHandler(this.Btn_UserRegis_Click_1);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.textBox2);
            this.PanelLogo.Controls.Add(this.textBox1);
            this.PanelLogo.Controls.Add(this.img_Home);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(238, 220);
            this.PanelLogo.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Century", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(-4, 153);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 20);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = "\"Impulsando el conocimiento, compartiendo investigaciones\"";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 135);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 20);
            this.textBox1.TabIndex = 31;
            this.textBox1.Text = "UAM INVESTIGATIONS";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // img_Home
            // 
            this.img_Home.Image = ((System.Drawing.Image)(resources.GetObject("img_Home.Image")));
            this.img_Home.Location = new System.Drawing.Point(0, 0);
            this.img_Home.Name = "img_Home";
            this.img_Home.Size = new System.Drawing.Size(238, 220);
            this.img_Home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Home.TabIndex = 0;
            this.img_Home.TabStop = false;
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btn_minisize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minisize.IconSize = 20;
            this.btn_minisize.Location = new System.Drawing.Point(641, 3);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(15, 15);
            this.btn_minisize.TabIndex = 0;
            this.btn_minisize.TabStop = false;
            this.btn_minisize.UseVisualStyleBackColor = false;
            this.btn_minisize.Click += new System.EventHandler(this.btn_minisize_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Btn_Salir.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 15;
            this.Btn_Salir.Location = new System.Drawing.Point(662, 3);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(62)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::UAM_INVESTIGATION.Properties.Resources.uam_internacional_portada;
            this.pictureBox1.Location = new System.Drawing.Point(238, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 463);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // icon_form_home
            // 
            this.icon_form_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icon_form_home.ForeColor = System.Drawing.Color.MediumPurple;
            this.icon_form_home.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.icon_form_home.IconColor = System.Drawing.Color.MediumPurple;
            this.icon_form_home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icon_form_home.Location = new System.Drawing.Point(15, 6);
            this.icon_form_home.Name = "icon_form_home";
            this.icon_form_home.Size = new System.Drawing.Size(32, 32);
            this.icon_form_home.TabIndex = 0;
            this.icon_form_home.TabStop = false;
            // 
            // lbl_form_tittle
            // 
            this.lbl_form_tittle.AutoSize = true;
            this.lbl_form_tittle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_form_tittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbl_form_tittle.Location = new System.Drawing.Point(53, 15);
            this.lbl_form_tittle.Name = "lbl_form_tittle";
            this.lbl_form_tittle.Size = new System.Drawing.Size(39, 16);
            this.lbl_form_tittle.TabIndex = 0;
            this.lbl_form_tittle.Text = "Home";
            // 
            // Panel_Tittle
            // 
            this.Panel_Tittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Panel_Tittle.Controls.Add(this.btn_minisize);
            this.Panel_Tittle.Controls.Add(this.lbl_form_tittle);
            this.Panel_Tittle.Controls.Add(this.Btn_Salir);
            this.Panel_Tittle.Controls.Add(this.icon_form_home);
            this.Panel_Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Tittle.Location = new System.Drawing.Point(238, 0);
            this.Panel_Tittle.Name = "Panel_Tittle";
            this.Panel_Tittle.Size = new System.Drawing.Size(680, 43);
            this.Panel_Tittle.TabIndex = 20;
            // 
            // pantalla_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(918, 506);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel_Tittle);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "pantalla_Principal";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelMenu.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            this.PanelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_Home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon_form_home)).EndInit();
            this.Panel_Tittle.ResumeLayout(false);
            this.Panel_Tittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton Btn_UserRegis;
        private System.Windows.Forms.PictureBox img_Home;
        private FontAwesome.Sharp.IconButton Btn_Us;
        private FontAwesome.Sharp.IconButton Btn_Help;
        private FontAwesome.Sharp.IconButton Btn_AdminRegis;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox icon_form_home;
        private System.Windows.Forms.Label lbl_form_tittle;
        private System.Windows.Forms.Panel Panel_Tittle;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

