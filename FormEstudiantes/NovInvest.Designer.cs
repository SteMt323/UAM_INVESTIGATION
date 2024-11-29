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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTrab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_Categoria = new System.Windows.Forms.TextBox();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.btn_VerArchivo = new System.Windows.Forms.Button();
            this.btn_Valoracion = new FontAwesome.Sharp.IconButton();
            this.Btn_Comentar = new FontAwesome.Sharp.IconButton();
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
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
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
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
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
            this.dgv_NovInvest.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
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
            this.Valoracion,
            this.Categoria,
            this.IdTrab});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NovInvest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NovInvest.EnableHeadersVisualStyles = false;
            this.dgv_NovInvest.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_NovInvest.Location = new System.Drawing.Point(4, 3);
            this.dgv_NovInvest.Name = "dgv_NovInvest";
            this.dgv_NovInvest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NovInvest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_NovInvest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_NovInvest.RowTemplate.Height = 60;
            this.dgv_NovInvest.Size = new System.Drawing.Size(550, 353);
            this.dgv_NovInvest.TabIndex = 3;
            this.dgv_NovInvest.TabStop = false;
            this.dgv_NovInvest.SelectionChanged += new System.EventHandler(this.dgv_NovInvest_SelectionChanged);
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
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.Visible = false;
            // 
            // IdTrab
            // 
            this.IdTrab.HeaderText = "IdTrab";
            this.IdTrab.Name = "IdTrab";
            this.IdTrab.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.txt_Categoria);
            this.panel3.Controls.Add(this.txt_Titulo);
            this.panel3.Controls.Add(this.txt_Descripcion);
            this.panel3.Controls.Add(this.btn_VerArchivo);
            this.panel3.Controls.Add(this.btn_Valoracion);
            this.panel3.Controls.Add(this.Btn_Comentar);
            this.panel3.Controls.Add(this.dgv_Comentarios);
            this.panel3.Location = new System.Drawing.Point(573, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 404);
            this.panel3.TabIndex = 2;
            // 
            // txt_Categoria
            // 
            this.txt_Categoria.BackColor = System.Drawing.Color.White;
            this.txt_Categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Categoria.ForeColor = System.Drawing.Color.Black;
            this.txt_Categoria.Location = new System.Drawing.Point(14, 50);
            this.txt_Categoria.Multiline = true;
            this.txt_Categoria.Name = "txt_Categoria";
            this.txt_Categoria.ReadOnly = true;
            this.txt_Categoria.Size = new System.Drawing.Size(281, 22);
            this.txt_Categoria.TabIndex = 5;
            this.txt_Categoria.Text = "Categoría...";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.Color.White;
            this.txt_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.ForeColor = System.Drawing.Color.Black;
            this.txt_Titulo.Location = new System.Drawing.Point(14, 17);
            this.txt_Titulo.Multiline = true;
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.ReadOnly = true;
            this.txt_Titulo.Size = new System.Drawing.Size(281, 21);
            this.txt_Titulo.TabIndex = 5;
            this.txt_Titulo.Text = "Título...";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.Color.White;
            this.txt_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.ForeColor = System.Drawing.Color.Black;
            this.txt_Descripcion.Location = new System.Drawing.Point(14, 84);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.ReadOnly = true;
            this.txt_Descripcion.Size = new System.Drawing.Size(281, 90);
            this.txt_Descripcion.TabIndex = 4;
            this.txt_Descripcion.Text = "Descripcion...";
            // 
            // btn_VerArchivo
            // 
            this.btn_VerArchivo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_VerArchivo.FlatAppearance.BorderSize = 0;
            this.btn_VerArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_VerArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_VerArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerArchivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerArchivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_VerArchivo.Location = new System.Drawing.Point(18, 316);
            this.btn_VerArchivo.Name = "btn_VerArchivo";
            this.btn_VerArchivo.Size = new System.Drawing.Size(270, 40);
            this.btn_VerArchivo.TabIndex = 41;
            this.btn_VerArchivo.Text = "Ver Trabajo";
            this.btn_VerArchivo.UseVisualStyleBackColor = false;
            this.btn_VerArchivo.Click += new System.EventHandler(this.btn_VerArchivo_Click);
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
            this.btn_Valoracion.Location = new System.Drawing.Point(13, 369);
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
            this.Btn_Comentar.Location = new System.Drawing.Point(157, 369);
            this.Btn_Comentar.Name = "Btn_Comentar";
            this.Btn_Comentar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Btn_Comentar.Size = new System.Drawing.Size(138, 26);
            this.Btn_Comentar.TabIndex = 39;
            this.Btn_Comentar.Text = "Comentar";
            this.Btn_Comentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Comentar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Comentar.UseVisualStyleBackColor = false;
            this.Btn_Comentar.Click += new System.EventHandler(this.Btn_Comentar_Click);
            // 
            // dgv_Comentarios
            // 
            this.dgv_Comentarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgv_Comentarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_Comentarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Comentarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Comentarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Comentarios.ColumnHeadersHeight = 30;
            this.dgv_Comentarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Comentarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UsuarioComentar,
            this.Comentario});
            this.dgv_Comentarios.EnableHeadersVisualStyles = false;
            this.dgv_Comentarios.GridColor = System.Drawing.Color.SlateBlue;
            this.dgv_Comentarios.Location = new System.Drawing.Point(14, 184);
            this.dgv_Comentarios.Name = "dgv_Comentarios";
            this.dgv_Comentarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Comentarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Comentarios.RowsDefaultCellStyle = dataGridViewCellStyle7;
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
            this.Load += new System.EventHandler(this.NovInvest_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NovInvest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgv_Comentarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioComentar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private FontAwesome.Sharp.IconButton Btn_Comentar;
        private FontAwesome.Sharp.IconButton btn_Valoracion;
        private System.Windows.Forms.Button btn_VerArchivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valoracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTrab;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.TextBox txt_Categoria;
    }
}
