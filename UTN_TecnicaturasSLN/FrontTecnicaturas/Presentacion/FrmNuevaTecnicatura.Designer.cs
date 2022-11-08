namespace FrontTecnicaturas.Presentacion
{
    partial class FrmNuevaTecnicatura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaTecnicatura));
            this.lblTecNro = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.rbtCuatr1 = new System.Windows.Forms.RadioButton();
            this.rbtCuatr2 = new System.Windows.Forms.RadioButton();
            this.lblAnioCursado = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAcciones = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.nudAnioCursado = new System.Windows.Forms.NumericUpDown();
            this.lblTotalMaterias = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTecNro
            // 
            this.lblTecNro.AutoSize = true;
            this.lblTecNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTecNro.Location = new System.Drawing.Point(29, 24);
            this.lblTecNro.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTecNro.Name = "lblTecNro";
            this.lblTecNro.Size = new System.Drawing.Size(175, 26);
            this.lblTecNro.TabIndex = 0;
            this.lblTecNro.Text = "Tecnicatura Nº:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(42, 84);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(29, 171);
            this.lblMaterias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(69, 20);
            this.lblMaterias.TabIndex = 5;
            this.lblMaterias.Text = "Materias:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 80);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 27);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(111, 121);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(5);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(261, 27);
            this.txtTitulo.TabIndex = 4;
            // 
            // cboMaterias
            // 
            this.cboMaterias.BackColor = System.Drawing.Color.Azure;
            this.cboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(31, 196);
            this.cboMaterias.Margin = new System.Windows.Forms.Padding(5);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(245, 28);
            this.cboMaterias.TabIndex = 6;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(283, 203);
            this.lblCuatrimestre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(96, 20);
            this.lblCuatrimestre.TabIndex = 7;
            this.lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // rbtCuatr1
            // 
            this.rbtCuatr1.AutoSize = true;
            this.rbtCuatr1.Location = new System.Drawing.Point(377, 201);
            this.rbtCuatr1.Margin = new System.Windows.Forms.Padding(5);
            this.rbtCuatr1.Name = "rbtCuatr1";
            this.rbtCuatr1.Size = new System.Drawing.Size(44, 24);
            this.rbtCuatr1.TabIndex = 8;
            this.rbtCuatr1.TabStop = true;
            this.rbtCuatr1.Text = "1º";
            this.rbtCuatr1.UseVisualStyleBackColor = true;
            // 
            // rbtCuatr2
            // 
            this.rbtCuatr2.AutoSize = true;
            this.rbtCuatr2.Location = new System.Drawing.Point(425, 201);
            this.rbtCuatr2.Margin = new System.Windows.Forms.Padding(5);
            this.rbtCuatr2.Name = "rbtCuatr2";
            this.rbtCuatr2.Size = new System.Drawing.Size(44, 24);
            this.rbtCuatr2.TabIndex = 9;
            this.rbtCuatr2.TabStop = true;
            this.rbtCuatr2.Text = "2º";
            this.rbtCuatr2.UseVisualStyleBackColor = true;
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Location = new System.Drawing.Point(483, 203);
            this.lblAnioCursado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(97, 20);
            this.lblAnioCursado.TabIndex = 10;
            this.lblAnioCursado.Text = "Año Cursado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(669, 192);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(101, 35);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClmMateria,
            this.ClmCuatrimestre,
            this.ClmAño,
            this.ClmAcciones});
            this.dgvMaterias.Location = new System.Drawing.Point(29, 240);
            this.dgvMaterias.Margin = new System.Windows.Forms.Padding(5);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.Size = new System.Drawing.Size(741, 295);
            this.dgvMaterias.TabIndex = 14;
            this.dgvMaterias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // ClmMateria
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Azure;
            this.ClmMateria.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClmMateria.HeaderText = "Materia";
            this.ClmMateria.MinimumWidth = 6;
            this.ClmMateria.Name = "ClmMateria";
            this.ClmMateria.ReadOnly = true;
            this.ClmMateria.Width = 250;
            // 
            // ClmCuatrimestre
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            this.ClmCuatrimestre.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 120;
            // 
            // ClmAño
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            this.ClmAño.DefaultCellStyle = dataGridViewCellStyle3;
            this.ClmAño.HeaderText = "Año";
            this.ClmAño.MinimumWidth = 6;
            this.ClmAño.Name = "ClmAño";
            this.ClmAño.ReadOnly = true;
            this.ClmAño.Width = 125;
            // 
            // ClmAcciones
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            this.ClmAcciones.DefaultCellStyle = dataGridViewCellStyle4;
            this.ClmAcciones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClmAcciones.HeaderText = "Acciones";
            this.ClmAcciones.MinimumWidth = 6;
            this.ClmAcciones.Name = "ClmAcciones";
            this.ClmAcciones.ReadOnly = true;
            this.ClmAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmAcciones.Text = "Quitar";
            this.ClmAcciones.UseColumnTextForButtonValue = true;
            this.ClmAcciones.Width = 193;
            // 
            // btnAniadir
            // 
            this.btnAniadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAniadir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAniadir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAniadir.ForeColor = System.Drawing.Color.White;
            this.btnAniadir.Location = new System.Drawing.Point(283, 545);
            this.btnAniadir.Margin = new System.Windows.Forms.Padding(5);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(104, 43);
            this.btnAniadir.TabIndex = 0;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = false;
            this.btnAniadir.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(425, 545);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 43);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudAnioCursado
            // 
            this.nudAnioCursado.Location = new System.Drawing.Point(587, 199);
            this.nudAnioCursado.Margin = new System.Windows.Forms.Padding(5);
            this.nudAnioCursado.Name = "nudAnioCursado";
            this.nudAnioCursado.Size = new System.Drawing.Size(67, 27);
            this.nudAnioCursado.TabIndex = 12;
            // 
            // lblTotalMaterias
            // 
            this.lblTotalMaterias.AutoSize = true;
            this.lblTotalMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTotalMaterias.Location = new System.Drawing.Point(603, 540);
            this.lblTotalMaterias.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTotalMaterias.Name = "lblTotalMaterias";
            this.lblTotalMaterias.Size = new System.Drawing.Size(126, 18);
            this.lblTotalMaterias.TabIndex = 15;
            this.lblTotalMaterias.Text = "Total de Materias:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(58, 125);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 20);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Titulo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::FrontTecnicaturas.Properties.Resources.transaccion;
            this.pictureBox1.Location = new System.Drawing.Point(639, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // FrmNuevaTecnicatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblTotalMaterias);
            this.Controls.Add(this.nudAnioCursado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblAnioCursado);
            this.Controls.Add(this.rbtCuatr2);
            this.Controls.Add(this.rbtCuatr1);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTecNro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmNuevaTecnicatura";
            this.Text = "Nueva Tecnicatura";
            this.Load += new System.EventHandler(this.FrmTecnicatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecNro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.RadioButton rbtCuatr1;
        private System.Windows.Forms.RadioButton rbtCuatr2;
        private System.Windows.Forms.Label lblAnioCursado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudAnioCursado;
        private System.Windows.Forms.Label lblTotalMaterias;
        private System.Windows.Forms.Label lblTitulo;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ClmMateria;
        private DataGridViewTextBoxColumn ClmCuatrimestre;
        private DataGridViewTextBoxColumn ClmAño;
        private DataGridViewButtonColumn ClmAcciones;
    }
}