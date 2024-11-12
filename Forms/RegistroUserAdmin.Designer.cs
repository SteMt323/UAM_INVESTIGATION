namespace UAM_INVESTIGATION.Forms
{
    partial class RegistroUserAdmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Correo = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.show_Password = new System.Windows.Forms.CheckBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_code_access = new System.Windows.Forms.TextBox();
            this.show_code = new System.Windows.Forms.CheckBox();
            this.btn_Registrarse = new System.Windows.Forms.Button();
            this.Lnk_SesionAdmin = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Registro de Admin";
            // 
            // txt_Correo
            // 
            this.txt_Correo.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Correo.ForeColor = System.Drawing.Color.White;
            this.txt_Correo.Location = new System.Drawing.Point(110, 143);
            this.txt_Correo.Name = "txt_Correo";
            this.txt_Correo.Size = new System.Drawing.Size(179, 13);
            this.txt_Correo.TabIndex = 10;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.White;
            this.txt_Contrasenia.Location = new System.Drawing.Point(110, 190);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(179, 13);
            this.txt_Contrasenia.TabIndex = 11;
            // 
            // show_Password
            // 
            this.show_Password.AutoSize = true;
            this.show_Password.Location = new System.Drawing.Point(295, 190);
            this.show_Password.Name = "show_Password";
            this.show_Password.Size = new System.Drawing.Size(15, 14);
            this.show_Password.TabIndex = 21;
            this.show_Password.UseVisualStyleBackColor = true;
            this.show_Password.CheckedChanged += new System.EventHandler(this.show_Password_CheckedChanged);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Nombre.ForeColor = System.Drawing.Color.White;
            this.txt_Nombre.Location = new System.Drawing.Point(110, 237);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(179, 13);
            this.txt_Nombre.TabIndex = 22;
            // 
            // txt_code_access
            // 
            this.txt_code_access.BackColor = System.Drawing.Color.DarkGray;
            this.txt_code_access.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_code_access.ForeColor = System.Drawing.Color.White;
            this.txt_code_access.Location = new System.Drawing.Point(110, 96);
            this.txt_code_access.Name = "txt_code_access";
            this.txt_code_access.Size = new System.Drawing.Size(179, 13);
            this.txt_code_access.TabIndex = 23;
            // 
            // show_code
            // 
            this.show_code.AutoSize = true;
            this.show_code.Location = new System.Drawing.Point(295, 95);
            this.show_code.Name = "show_code";
            this.show_code.Size = new System.Drawing.Size(15, 14);
            this.show_code.TabIndex = 24;
            this.show_code.UseVisualStyleBackColor = true;
            this.show_code.CheckedChanged += new System.EventHandler(this.show_code_CheckedChanged);
            // 
            // btn_Registrarse
            // 
            this.btn_Registrarse.BackColor = System.Drawing.Color.Silver;
            this.btn_Registrarse.Location = new System.Drawing.Point(72, 302);
            this.btn_Registrarse.Name = "btn_Registrarse";
            this.btn_Registrarse.Size = new System.Drawing.Size(161, 23);
            this.btn_Registrarse.TabIndex = 25;
            this.btn_Registrarse.Text = "Regístrarse";
            this.btn_Registrarse.UseVisualStyleBackColor = false;
            this.btn_Registrarse.Click += new System.EventHandler(this.btn_Registrarse_Click);
            // 
            // Lnk_SesionAdmin
            // 
            this.Lnk_SesionAdmin.AutoSize = true;
            this.Lnk_SesionAdmin.LinkColor = System.Drawing.Color.Blue;
            this.Lnk_SesionAdmin.Location = new System.Drawing.Point(163, 365);
            this.Lnk_SesionAdmin.Name = "Lnk_SesionAdmin";
            this.Lnk_SesionAdmin.Size = new System.Drawing.Size(70, 13);
            this.Lnk_SesionAdmin.TabIndex = 27;
            this.Lnk_SesionAdmin.TabStop = true;
            this.Lnk_SesionAdmin.Text = "Iniciar Sesión";
            this.Lnk_SesionAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_SesionAdmin_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(79, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "¿Tienes cuenta?";
            // 
            // RegistroUserAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(324, 387);
            this.Controls.Add(this.Lnk_SesionAdmin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Registrarse);
            this.Controls.Add(this.show_code);
            this.Controls.Add(this.txt_code_access);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.show_Password);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_Correo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RegistroUserAdmin";
            this.Load += new System.EventHandler(this.RegistroUserAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Correo;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.CheckBox show_Password;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_code_access;
        private System.Windows.Forms.CheckBox show_code;
        private System.Windows.Forms.Button btn_Registrarse;
        private System.Windows.Forms.LinkLabel Lnk_SesionAdmin;
        private System.Windows.Forms.Label label7;
    }
}