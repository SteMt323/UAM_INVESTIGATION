﻿namespace UAM_INVESTIGATION.FormAdmin
{
    partial class PrincipalAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minisize = new FontAwesome.Sharp.IconButton();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_GestionarUser = new FontAwesome.Sharp.IconButton();
            this.Btn_Reportes = new FontAwesome.Sharp.IconButton();
            this.Btn_Perfil = new FontAwesome.Sharp.IconButton();
            this.Btn_LogOut = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnl_Content = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.btn_minisize);
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 34);
            this.panel1.TabIndex = 0;
            // 
            // btn_minisize
            // 
            this.btn_minisize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btn_minisize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minisize.FlatAppearance.BorderSize = 0;
            this.btn_minisize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minisize.IconChar = FontAwesome.Sharp.IconChar.Compress;
            this.btn_minisize.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_minisize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minisize.IconSize = 20;
            this.btn_minisize.Location = new System.Drawing.Point(1050, 3);
            this.btn_minisize.Name = "btn_minisize";
            this.btn_minisize.Size = new System.Drawing.Size(15, 15);
            this.btn_minisize.TabIndex = 18;
            this.btn_minisize.TabStop = false;
            this.btn_minisize.UseVisualStyleBackColor = false;
            this.btn_minisize.Click += new System.EventHandler(this.btn_minisize_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_Salir.FlatAppearance.BorderSize = 0;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.IconChar = FontAwesome.Sharp.IconChar.X;
            this.Btn_Salir.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_Salir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Salir.IconSize = 15;
            this.Btn_Salir.Location = new System.Drawing.Point(1071, 3);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 17;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menú Principal";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.panel2.Controls.Add(this.Btn_GestionarUser);
            this.panel2.Controls.Add(this.Btn_Reportes);
            this.panel2.Controls.Add(this.Btn_Perfil);
            this.panel2.Controls.Add(this.Btn_LogOut);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 427);
            this.panel2.TabIndex = 1;
            // 
            // Btn_GestionarUser
            // 
            this.Btn_GestionarUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_GestionarUser.FlatAppearance.BorderSize = 0;
            this.Btn_GestionarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GestionarUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GestionarUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_GestionarUser.IconChar = FontAwesome.Sharp.IconChar.UsersRectangle;
            this.Btn_GestionarUser.IconColor = System.Drawing.Color.MediumPurple;
            this.Btn_GestionarUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_GestionarUser.IconSize = 30;
            this.Btn_GestionarUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GestionarUser.Location = new System.Drawing.Point(0, 201);
            this.Btn_GestionarUser.Name = "Btn_GestionarUser";
            this.Btn_GestionarUser.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_GestionarUser.Size = new System.Drawing.Size(200, 60);
            this.Btn_GestionarUser.TabIndex = 3;
            this.Btn_GestionarUser.Text = "Monitorear Usuarios";
            this.Btn_GestionarUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_GestionarUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_GestionarUser.UseVisualStyleBackColor = true;
            this.Btn_GestionarUser.Click += new System.EventHandler(this.btn_GestionarUsuarios);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Reportes.FlatAppearance.BorderSize = 0;
            this.Btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reportes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Reportes.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Reportes.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.Btn_Reportes.IconColor = System.Drawing.Color.MediumPurple;
            this.Btn_Reportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Reportes.IconSize = 30;
            this.Btn_Reportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reportes.Location = new System.Drawing.Point(0, 141);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Reportes.Size = new System.Drawing.Size(200, 60);
            this.Btn_Reportes.TabIndex = 2;
            this.Btn_Reportes.Text = "Monitorear Trabajos";
            this.Btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Reportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Reportes.UseVisualStyleBackColor = true;
            this.Btn_Reportes.Click += new System.EventHandler(this.Btn_Reportes_Click);
            // 
            // Btn_Perfil
            // 
            this.Btn_Perfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btn_Perfil.FlatAppearance.BorderSize = 0;
            this.Btn_Perfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Perfil.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Perfil.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Perfil.IconChar = FontAwesome.Sharp.IconChar.User;
            this.Btn_Perfil.IconColor = System.Drawing.Color.MediumPurple;
            this.Btn_Perfil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Perfil.IconSize = 30;
            this.Btn_Perfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Perfil.Location = new System.Drawing.Point(0, 81);
            this.Btn_Perfil.Name = "Btn_Perfil";
            this.Btn_Perfil.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Perfil.Size = new System.Drawing.Size(200, 60);
            this.Btn_Perfil.TabIndex = 1;
            this.Btn_Perfil.Text = "Perfil";
            this.Btn_Perfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Perfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Perfil.UseVisualStyleBackColor = true;
            this.Btn_Perfil.Click += new System.EventHandler(this.Btn_Perfil_Click);
            // 
            // Btn_LogOut
            // 
            this.Btn_LogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Btn_LogOut.FlatAppearance.BorderSize = 0;
            this.Btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LogOut.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_LogOut.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_LogOut.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.Btn_LogOut.IconColor = System.Drawing.Color.Gainsboro;
            this.Btn_LogOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_LogOut.IconSize = 30;
            this.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.Location = new System.Drawing.Point(0, 391);
            this.Btn_LogOut.Name = "Btn_LogOut";
            this.Btn_LogOut.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_LogOut.Size = new System.Drawing.Size(200, 36);
            this.Btn_LogOut.TabIndex = 4;
            this.Btn_LogOut.Text = "Log out";
            this.Btn_LogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_LogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_LogOut.UseVisualStyleBackColor = true;
            this.Btn_LogOut.Click += new System.EventHandler(this.Btn_LogOut_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.lblCorreo);
            this.panel3.Controls.Add(this.lblNombre);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.iconPictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 81);
            this.panel3.TabIndex = 0;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCorreo.Location = new System.Drawing.Point(47, 47);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(43, 15);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNombre.Location = new System.Drawing.Point(47, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(38, 15);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(47, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Administrador";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(41, 81);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // pnl_Content
            // 
            this.pnl_Content.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.pnl_Content.BackgroundImage = global::UAM_INVESTIGATION.Properties.Resources.U_I_Logo;
            this.pnl_Content.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnl_Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Content.Location = new System.Drawing.Point(200, 34);
            this.pnl_Content.Name = "pnl_Content";
            this.pnl_Content.Size = new System.Drawing.Size(890, 427);
            this.pnl_Content.TabIndex = 2;
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1090, 461);
            this.Controls.Add(this.pnl_Content);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrincipalAdmin";
            this.Opacity = 0.99D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PrincipalAdmin";
            this.Load += new System.EventHandler(this.PrincipalAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private FontAwesome.Sharp.IconButton btn_minisize;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton Btn_Reportes;
        private FontAwesome.Sharp.IconButton Btn_Perfil;
        private FontAwesome.Sharp.IconButton Btn_LogOut;
        private FontAwesome.Sharp.IconButton Btn_GestionarUser;
        private System.Windows.Forms.Panel pnl_Content;
    }
}