namespace UAM_INVESTIGATION.FormEstudiantes
{
    partial class ArchivosTrabajos
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
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnl_Descargar = new System.Windows.Forms.Panel();
            this.Btn_Descargar = new System.Windows.Forms.Button();
            this.pnlVistaPrevia = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnl_Descargar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 40);
            this.panel1.TabIndex = 1;
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
            this.Btn_Salir.Location = new System.Drawing.Point(3, 3);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 40;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnl_Descargar);
            this.panel2.Controls.Add(this.pnlVistaPrevia);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 560);
            this.panel2.TabIndex = 2;
            // 
            // pnl_Descargar
            // 
            this.pnl_Descargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.pnl_Descargar.Controls.Add(this.Btn_Descargar);
            this.pnl_Descargar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Descargar.Location = new System.Drawing.Point(0, 488);
            this.pnl_Descargar.Name = "pnl_Descargar";
            this.pnl_Descargar.Size = new System.Drawing.Size(900, 72);
            this.pnl_Descargar.TabIndex = 2;
            // 
            // Btn_Descargar
            // 
            this.Btn_Descargar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Btn_Descargar.FlatAppearance.BorderSize = 0;
            this.Btn_Descargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Btn_Descargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Btn_Descargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Descargar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Descargar.ForeColor = System.Drawing.Color.LightGray;
            this.Btn_Descargar.Location = new System.Drawing.Point(291, 16);
            this.Btn_Descargar.Name = "Btn_Descargar";
            this.Btn_Descargar.Size = new System.Drawing.Size(270, 40);
            this.Btn_Descargar.TabIndex = 42;
            this.Btn_Descargar.Text = "Descargar";
            this.Btn_Descargar.UseVisualStyleBackColor = false;
            this.Btn_Descargar.Click += new System.EventHandler(this.Btn_Descargar_Click);
            // 
            // pnlVistaPrevia
            // 
            this.pnlVistaPrevia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.pnlVistaPrevia.Location = new System.Drawing.Point(12, 6);
            this.pnlVistaPrevia.Name = "pnlVistaPrevia";
            this.pnlVistaPrevia.Size = new System.Drawing.Size(876, 476);
            this.pnlVistaPrevia.TabIndex = 0;
            // 
            // ArchivosTrabajos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ArchivosTrabajos";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchivosTrabajos";
            this.Load += new System.EventHandler(this.ArchivosTrabajos_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnl_Descargar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_Descargar;
        private System.Windows.Forms.Panel pnlVistaPrevia;
        private System.Windows.Forms.Button Btn_Descargar;
    }
}