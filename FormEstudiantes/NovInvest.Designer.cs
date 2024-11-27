namespace UAM_INVESTIGATION.FormEstudiantes
{
    partial class NovInvest
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Buscar = new FontAwesome.Sharp.IconButton();
            this.txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_NovInvest = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valoracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Valoracion = new FontAwesome.Sharp.IconButton();
            this.Btn_Comentar = new FontAwesome.Sharp.IconButton();
            this.lbl_Descripcion = new MetroFramework.Controls.MetroLabel();
            this.lbl_Categoria = new MetroFramework.Controls.MetroLabel();
            this.lbl_Titulo = new MetroFramework.Controls.MetroLabel();
            this.dgv_Comentarios = new System.Windows.Forms.DataGridView();
            this.UsuarioComentar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NovInvest)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Comentarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Controls.Add(this.txt_Busqueda);
            this.panel1.Controls.Add(this.Btn_Salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 40);
            this.panel1.TabIndex = 0;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btn_Buscar.IconColor = System.Drawing.Color.Gainsboro;
            this.btn_Buscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Buscar.IconSize = 20;
            this.btn_Buscar.Location = new System.Drawing.Point(611, 13);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(15, 15);
            this.btn_Buscar.TabIndex = 42;
            this.btn_Buscar.TabStop = false;
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // txt_Busqueda
            // 
            this.txt_Busqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_Busqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Busqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Busqueda.ForeColor = System.Drawing.Color.DimGray;
            this.txt_Busqueda.Location = new System.Drawing.Point(234, 10);
            this.txt_Busqueda.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.txt_Busqueda.Name = "txt_Busqueda";
            this.txt_Busqueda.Size = new System.Drawing.Size(372, 20);
            this.txt_Busqueda.TabIndex = 41;
            this.txt_Busqueda.Text = "Buscar Trabajos...";
            this.txt_Busqueda.Enter += new System.EventHandler(this.txt_Busqueda_Enter);
            this.txt_Busqueda.Leave += new System.EventHandler(this.txt_Busqueda_Leave);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.dgv_NovInvest);
            this.panel2.Location = new System.Drawing.Point(10, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 404);
            this.panel2.TabIndex = 1;
            // 
            // dgv_NovInvest
            // 
            this.dgv_NovInvest.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgv_NovInvest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_NovInvest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NovInvest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NovInvest.ColumnHeadersHeight = 30;
            this.dgv_NovInvest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_NovInvest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Descripcion,
            this.Autor,
            this.Valoracion});
            this.dgv_NovInvest.EnableHeadersVisualStyles = false;
            this.dgv_NovInvest.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_NovInvest.Location = new System.Drawing.Point(4, 3);
            this.dgv_NovInvest.Name = "dgv_NovInvest";
            this.dgv_NovInvest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NovInvest.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_NovInvest.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NovInvest.RowTemplate.Height = 60;
            this.dgv_NovInvest.Size = new System.Drawing.Size(550, 398);
            this.dgv_NovInvest.TabIndex = 3;
            this.dgv_NovInvest.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            this.Titulo.Width = 108;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 210;
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Publicado Por";
            this.Autor.Name = "Autor";
            this.Autor.Width = 110;
            // 
            // Valoracion
            // 
            this.Valoracion.HeaderText = "Valoración";
            this.Valoracion.Name = "Valoracion";
            this.Valoracion.Width = 80;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.btn_Valoracion);
            this.panel3.Controls.Add(this.Btn_Comentar);
            this.panel3.Controls.Add(this.lbl_Descripcion);
            this.panel3.Controls.Add(this.lbl_Categoria);
            this.panel3.Controls.Add(this.lbl_Titulo);
            this.panel3.Controls.Add(this.dgv_Comentarios);
            this.panel3.Location = new System.Drawing.Point(573, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 404);
            this.panel3.TabIndex = 2;
            // 
            // btn_Valoracion
            // 
            this.btn_Valoracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(95)))));
            this.btn_Valoracion.FlatAppearance.BorderSize = 0;
            this.btn_Valoracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Valoracion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Valoracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Valoracion.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btn_Valoracion.IconColor = System.Drawing.Color.MediumPurple;
            this.btn_Valoracion.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btn_Valoracion.IconSize = 20;
            this.btn_Valoracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Valoracion.Location = new System.Drawing.Point(13, 354);
            this.btn_Valoracion.Name = "btn_Valoracion";
            this.btn_Valoracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Valoracion.Size = new System.Drawing.Size(138, 26);
            this.btn_Valoracion.TabIndex = 40;
            this.btn_Valoracion.Text = "Valorar";
            this.btn_Valoracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Valoracion.UseVisualStyleBackColor = false;
            this.btn_Valoracion.Click += new System.EventHandler(this.btn_Valoracion_Click);
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
            this.Btn_Comentar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Btn_Comentar.IconSize = 20;
            this.Btn_Comentar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Comentar.Location = new System.Drawing.Point(157, 354);
            this.Btn_Comentar.Name = "Btn_Comentar";
            this.Btn_Comentar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Comentar.Size = new System.Drawing.Size(138, 26);
            this.Btn_Comentar.TabIndex = 39;
            this.Btn_Comentar.Text = "Comentar";
            this.Btn_Comentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Comentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Comentar.UseVisualStyleBackColor = false;
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.BackColor = System.Drawing.Color.White;
            this.lbl_Descripcion.Location = new System.Drawing.Point(14, 94);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(281, 84);
            this.lbl_Descripcion.TabIndex = 38;
            this.lbl_Descripcion.Text = "Descripción...";
            // 
            // lbl_Categoria
            // 
            this.lbl_Categoria.BackColor = System.Drawing.Color.White;
            this.lbl_Categoria.Location = new System.Drawing.Point(14, 57);
            this.lbl_Categoria.Name = "lbl_Categoria";
            this.lbl_Categoria.Size = new System.Drawing.Size(281, 20);
            this.lbl_Categoria.TabIndex = 37;
            this.lbl_Categoria.Text = "Categoría...";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.BackColor = System.Drawing.Color.White;
            this.lbl_Titulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_Titulo.Location = new System.Drawing.Point(14, 12);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(281, 26);
            this.lbl_Titulo.TabIndex = 36;
            this.lbl_Titulo.Text = "Título...";
            // 
            // dgv_Comentarios
            // 
            this.dgv_Comentarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Comentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Comentarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Comentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Comentarios.ColumnHeadersHeight = 30;
            this.dgv_Comentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Comentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioComentar,
            this.Comentario});
            this.dgv_Comentarios.EnableHeadersVisualStyles = false;
            this.dgv_Comentarios.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_Comentarios.Location = new System.Drawing.Point(14, 196);
            this.dgv_Comentarios.Name = "dgv_Comentarios";
            this.dgv_Comentarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Comentarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Comentarios.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Comentarios.RowTemplate.Height = 60;
            this.dgv_Comentarios.Size = new System.Drawing.Size(281, 123);
            this.dgv_Comentarios.TabIndex = 4;
            this.dgv_Comentarios.TabStop = false;
            // 
            // UsuarioComentar
            // 
            this.UsuarioComentar.HeaderText = "Usuario";
            this.UsuarioComentar.Name = "UsuarioComentar";
            this.UsuarioComentar.Width = 75;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentarios";
            this.Comentario.Name = "Comentario";
            this.Comentario.Width = 165;
            // 
            // NovInvest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "NovInvest";
            this.Size = new System.Drawing.Size(890, 477);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NovInvest)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Comentarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.TextBox txt_Busqueda;
        private FontAwesome.Sharp.IconButton btn_Buscar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_NovInvest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoracion;
        private System.Windows.Forms.DataGridView dgv_Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioComentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private MetroFramework.Controls.MetroLabel lbl_Categoria;
        private MetroFramework.Controls.MetroLabel lbl_Titulo;
        private MetroFramework.Controls.MetroLabel lbl_Descripcion;
        private FontAwesome.Sharp.IconButton Btn_Comentar;
        private FontAwesome.Sharp.IconButton btn_Valoracion;
    }
}
