namespace UAM_INVESTIGATION.Forms
{
    partial class InicioSesionUserEst
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_CorreoCif = new System.Windows.Forms.TextBox();
            this.txt_Contrasenia = new System.Windows.Forms.TextBox();
            this.btn_InicioSesion = new System.Windows.Forms.Button();
            this.cb_MostrarContrasenia = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Lnk_Registro = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio de Sesión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo o Cif:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña:";
            // 
            // txt_CorreoCif
            // 
            this.txt_CorreoCif.BackColor = System.Drawing.Color.DarkGray;
            this.txt_CorreoCif.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CorreoCif.ForeColor = System.Drawing.Color.White;
            this.txt_CorreoCif.Location = new System.Drawing.Point(111, 100);
            this.txt_CorreoCif.Name = "txt_CorreoCif";
            this.txt_CorreoCif.Size = new System.Drawing.Size(179, 13);
            this.txt_CorreoCif.TabIndex = 3;
            // 
            // txt_Contrasenia
            // 
            this.txt_Contrasenia.BackColor = System.Drawing.Color.DarkGray;
            this.txt_Contrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Contrasenia.ForeColor = System.Drawing.Color.White;
            this.txt_Contrasenia.Location = new System.Drawing.Point(111, 144);
            this.txt_Contrasenia.Name = "txt_Contrasenia";
            this.txt_Contrasenia.Size = new System.Drawing.Size(179, 13);
            this.txt_Contrasenia.TabIndex = 4;
            // 
            // btn_InicioSesion
            // 
            this.btn_InicioSesion.BackColor = System.Drawing.Color.DarkGray;
            this.btn_InicioSesion.Location = new System.Drawing.Point(44, 196);
            this.btn_InicioSesion.Name = "btn_InicioSesion";
            this.btn_InicioSesion.Size = new System.Drawing.Size(229, 23);
            this.btn_InicioSesion.TabIndex = 5;
            this.btn_InicioSesion.Text = "Iniciar Sesión";
            this.btn_InicioSesion.UseVisualStyleBackColor = false;
            this.btn_InicioSesion.Click += new System.EventHandler(this.btn_InicioSesion_Click);
            // 
            // cb_MostrarContrasenia
            // 
            this.cb_MostrarContrasenia.AutoSize = true;
            this.cb_MostrarContrasenia.Location = new System.Drawing.Point(296, 144);
            this.cb_MostrarContrasenia.Name = "cb_MostrarContrasenia";
            this.cb_MostrarContrasenia.Size = new System.Drawing.Size(15, 14);
            this.cb_MostrarContrasenia.TabIndex = 6;
            this.cb_MostrarContrasenia.UseVisualStyleBackColor = true;
            this.cb_MostrarContrasenia.CheckedChanged += new System.EventHandler(this.cb_MostrarContrasenia_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "¿No tienes una cuenta?";
            // 
            // Lnk_Registro
            // 
            this.Lnk_Registro.AutoSize = true;
            this.Lnk_Registro.LinkColor = System.Drawing.Color.Blue;
            this.Lnk_Registro.Location = new System.Drawing.Point(181, 244);
            this.Lnk_Registro.Name = "Lnk_Registro";
            this.Lnk_Registro.Size = new System.Drawing.Size(62, 13);
            this.Lnk_Registro.TabIndex = 8;
            this.Lnk_Registro.TabStop = true;
            this.Lnk_Registro.Text = "Regístrarse";
            this.Lnk_Registro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Lnk_Registro_LinkClicked);
            // 
            // InicioSesionUserEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(324, 266);
            this.Controls.Add(this.Lnk_Registro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_MostrarContrasenia);
            this.Controls.Add(this.btn_InicioSesion);
            this.Controls.Add(this.txt_Contrasenia);
            this.Controls.Add(this.txt_CorreoCif);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InicioSesionUserEst";
            this.Load += new System.EventHandler(this.InicioSesionUserEst_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_CorreoCif;
        private System.Windows.Forms.TextBox txt_Contrasenia;
        private System.Windows.Forms.Button btn_InicioSesion;
        private System.Windows.Forms.CheckBox cb_MostrarContrasenia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel Lnk_Registro;
    }
}