namespace UAM_INVESTIGATION.FormEstudiantes
{
    partial class TrabajoSubir
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_ArchivoAdjunto = new MetroFramework.Controls.MetroLabel();
            this.btn_AdjuntarArchivo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Categoria = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Titulo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SubirTrabajo = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_DeshacerFiltrado = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewTrabajos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_TituloBusqueda = new System.Windows.Forms.TextBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.Btn_Salir = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(566, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 477);
            this.panel1.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 477);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(25)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.lbl_ArchivoAdjunto);
            this.panel3.Controls.Add(this.btn_AdjuntarArchivo);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txt_Descripcion);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.cmb_Categoria);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txt_Titulo);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.btn_SubirTrabajo);
            this.panel3.Controls.Add(this.btn_Cancelar);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 477);
            this.panel3.TabIndex = 30;
            // 
            // lbl_ArchivoAdjunto
            // 
            this.lbl_ArchivoAdjunto.BackColor = System.Drawing.Color.White;
            this.lbl_ArchivoAdjunto.Location = new System.Drawing.Point(25, 366);
            this.lbl_ArchivoAdjunto.Name = "lbl_ArchivoAdjunto";
            this.lbl_ArchivoAdjunto.Size = new System.Drawing.Size(270, 19);
            this.lbl_ArchivoAdjunto.TabIndex = 36;
            // 
            // btn_AdjuntarArchivo
            // 
            this.btn_AdjuntarArchivo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_AdjuntarArchivo.FlatAppearance.BorderSize = 0;
            this.btn_AdjuntarArchivo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_AdjuntarArchivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_AdjuntarArchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AdjuntarArchivo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdjuntarArchivo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_AdjuntarArchivo.Location = new System.Drawing.Point(25, 319);
            this.btn_AdjuntarArchivo.Name = "btn_AdjuntarArchivo";
            this.btn_AdjuntarArchivo.Size = new System.Drawing.Size(270, 40);
            this.btn_AdjuntarArchivo.TabIndex = 20;
            this.btn_AdjuntarArchivo.Text = "Adjuntar";
            this.btn_AdjuntarArchivo.UseVisualStyleBackColor = false;
            this.btn_AdjuntarArchivo.Click += new System.EventHandler(this.btn_AdjuntarArchivo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(21, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Adjuntar Archivo";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_Descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Descripcion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Descripcion.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_Descripcion.Location = new System.Drawing.Point(25, 182);
            this.txt_Descripcion.Multiline = true;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(270, 95);
            this.txt_Descripcion.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(21, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Descripción";
            // 
            // cmb_Categoria
            // 
            this.cmb_Categoria.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.cmb_Categoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Categoria.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Categoria.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmb_Categoria.FormattingEnabled = true;
            this.cmb_Categoria.Items.AddRange(new object[] {
            "Arte y Cultura",
            "Agronomía y Ciencias Agropecuarias",
            "Ciencias Computacionales",
            "Ciencias de la Salud",
            "Ciencias Espaciales",
            "Ciencias Naturales",
            "Ciencias Sociales",
            "Desarrollo Sostenible",
            "Derecho y Legislación",
            "Economía y Negocios",
            "Educación",
            "Historia y Humanidades",
            "Ingeniería",
            "Transporte y Logística",
            "Tecnología e Innovación"});
            this.cmb_Categoria.Location = new System.Drawing.Point(25, 120);
            this.cmb_Categoria.Name = "cmb_Categoria";
            this.cmb_Categoria.Size = new System.Drawing.Size(270, 29);
            this.cmb_Categoria.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Categoria";
            // 
            // txt_Titulo
            // 
            this.txt_Titulo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.txt_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Titulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_Titulo.Location = new System.Drawing.Point(25, 64);
            this.txt_Titulo.Name = "txt_Titulo";
            this.txt_Titulo.Size = new System.Drawing.Size(270, 20);
            this.txt_Titulo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(21, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Titulo";
            // 
            // btn_SubirTrabajo
            // 
            this.btn_SubirTrabajo.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_SubirTrabajo.FlatAppearance.BorderSize = 0;
            this.btn_SubirTrabajo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_SubirTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_SubirTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubirTrabajo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubirTrabajo.ForeColor = System.Drawing.Color.LightGray;
            this.btn_SubirTrabajo.Location = new System.Drawing.Point(181, 422);
            this.btn_SubirTrabajo.Name = "btn_SubirTrabajo";
            this.btn_SubirTrabajo.Size = new System.Drawing.Size(98, 40);
            this.btn_SubirTrabajo.TabIndex = 4;
            this.btn_SubirTrabajo.Text = "Publicar";
            this.btn_SubirTrabajo.UseVisualStyleBackColor = false;
            this.btn_SubirTrabajo.Click += new System.EventHandler(this.btn_SubirTrabajo_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.DimGray;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.Color.LightGray;
            this.btn_Cancelar.Location = new System.Drawing.Point(41, 422);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(98, 40);
            this.btn_Cancelar.TabIndex = 5;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(79, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Subir Trabajo";
            // 
            // btn_DeshacerFiltrado
            // 
            this.btn_DeshacerFiltrado.BackColor = System.Drawing.Color.DimGray;
            this.btn_DeshacerFiltrado.FlatAppearance.BorderSize = 0;
            this.btn_DeshacerFiltrado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_DeshacerFiltrado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_DeshacerFiltrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeshacerFiltrado.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeshacerFiltrado.ForeColor = System.Drawing.Color.LightGray;
            this.btn_DeshacerFiltrado.Location = new System.Drawing.Point(84, 391);
            this.btn_DeshacerFiltrado.Name = "btn_DeshacerFiltrado";
            this.btn_DeshacerFiltrado.Size = new System.Drawing.Size(98, 40);
            this.btn_DeshacerFiltrado.TabIndex = 34;
            this.btn_DeshacerFiltrado.Text = "Deshacer";
            this.btn_DeshacerFiltrado.UseVisualStyleBackColor = false;
            this.btn_DeshacerFiltrado.Click += new System.EventHandler(this.btn_DeshacerFiltrado_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(35, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "Trabajos Publicados";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(200, 391);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(98, 40);
            this.btnBuscar.TabIndex = 32;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(5, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Buscar Titulos:";
            // 
            // dataGridViewTrabajos
            // 
            this.dataGridViewTrabajos.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dataGridViewTrabajos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTrabajos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTrabajos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTrabajos.ColumnHeadersHeight = 30;
            this.dataGridViewTrabajos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTrabajos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Categoria,
            this.Descripcion});
            this.dataGridViewTrabajos.EnableHeadersVisualStyles = false;
            this.dataGridViewTrabajos.GridColor = System.Drawing.Color.SlateBlue;
            this.dataGridViewTrabajos.Location = new System.Drawing.Point(13, 75);
            this.dataGridViewTrabajos.Name = "dataGridViewTrabajos";
            this.dataGridViewTrabajos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTrabajos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewTrabajos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTrabajos.Size = new System.Drawing.Size(542, 213);
            this.dataGridViewTrabajos.TabIndex = 33;
            this.dataGridViewTrabajos.TabStop = false;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // txt_TituloBusqueda
            // 
            this.txt_TituloBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_TituloBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_TituloBusqueda.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TituloBusqueda.ForeColor = System.Drawing.Color.Black;
            this.txt_TituloBusqueda.Location = new System.Drawing.Point(57, 365);
            this.txt_TituloBusqueda.Name = "txt_TituloBusqueda";
            this.txt_TituloBusqueda.Size = new System.Drawing.Size(270, 20);
            this.txt_TituloBusqueda.TabIndex = 31;
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorMessage.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblErrorMessage.Location = new System.Drawing.Point(53, 293);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(102, 19);
            this.lblErrorMessage.TabIndex = 37;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.Visible = false;
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
            this.Btn_Salir.TabIndex = 39;
            this.Btn_Salir.TabStop = false;
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ExclamationTriangle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Red;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 26;
            this.iconPictureBox1.Location = new System.Drawing.Point(27, 290);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(29, 26);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconPictureBox1.TabIndex = 38;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Visible = false;
            // 
            // TrabajoSubir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(75)))));
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btn_DeshacerFiltrado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewTrabajos);
            this.Controls.Add(this.txt_TituloBusqueda);
            this.Controls.Add(this.panel1);
            this.Name = "TrabajoSubir";
            this.Size = new System.Drawing.Size(890, 477);
            this.Load += new System.EventHandler(this.TrabajoSubir_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrabajos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Categoria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Titulo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SubirTrabajo;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_AdjuntarArchivo;
        private System.Windows.Forms.Button btn_DeshacerFiltrado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewTrabajos;
        private System.Windows.Forms.TextBox txt_TituloBusqueda;
        private MetroFramework.Controls.MetroLabel lbl_ArchivoAdjunto;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblErrorMessage;
        private FontAwesome.Sharp.IconButton Btn_Salir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}
