namespace UAM_INVESTIGATION.FormEstudiantes
{
    partial class Comentarios
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
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.txt_Comentario = new System.Windows.Forms.TextBox();
            this.Btn_Comentar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
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
            this.Btn_Salir.Location = new System.Drawing.Point(414, 2);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(15, 15);
            this.Btn_Salir.TabIndex = 42;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(128, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Comenta este Trabajo";
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.icon.ForeColor = System.Drawing.Color.MediumPurple;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.icon.IconColor = System.Drawing.Color.MediumPurple;
            this.icon.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.icon.IconSize = 45;
            this.icon.Location = new System.Drawing.Point(192, 46);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(48, 45);
            this.icon.TabIndex = 44;
            this.icon.TabStop = false;
            this.icon.Tag = "5";
            // 
            // txt_Comentario
            // 
            this.txt_Comentario.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Comentario.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Comentario.Location = new System.Drawing.Point(98, 97);
            this.txt_Comentario.Multiline = true;
            this.txt_Comentario.Name = "txt_Comentario";
            this.txt_Comentario.Size = new System.Drawing.Size(230, 100);
            this.txt_Comentario.TabIndex = 45;
            this.txt_Comentario.Text = "Escribe algo...";
            this.txt_Comentario.Enter += new System.EventHandler(this.txt_Comentario_Enter);
            this.txt_Comentario.Leave += new System.EventHandler(this.txt_Comentario_Leave);
            // 
            // Btn_Comentar
            // 
            this.Btn_Comentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.Btn_Comentar.FlatAppearance.BorderSize = 0;
            this.Btn_Comentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Comentar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Comentar.ForeColor = System.Drawing.Color.Gainsboro;
            this.Btn_Comentar.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.Btn_Comentar.IconColor = System.Drawing.Color.MediumPurple;
            this.Btn_Comentar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.Btn_Comentar.IconSize = 20;
            this.Btn_Comentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Comentar.Location = new System.Drawing.Point(143, 214);
            this.Btn_Comentar.Name = "Btn_Comentar";
            this.Btn_Comentar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Comentar.Size = new System.Drawing.Size(138, 26);
            this.Btn_Comentar.TabIndex = 46;
            this.Btn_Comentar.Text = "Comentar";
            this.Btn_Comentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Comentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Comentar.UseVisualStyleBackColor = false;
            this.Btn_Comentar.Click += new System.EventHandler(this.Btn_Comentar_Click);
            // 
            // Comentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(432, 252);
            this.Controls.Add(this.Btn_Comentar);
            this.Controls.Add(this.txt_Comentario);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Comentarios";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.TextBox txt_Comentario;
        private FontAwesome.Sharp.IconButton Btn_Comentar;
    }
}