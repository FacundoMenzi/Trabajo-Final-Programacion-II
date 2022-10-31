namespace TpProgramacion.Presentacion
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTecNro
            // 
            this.lblTecNro.AutoSize = true;
            this.lblTecNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecNro.Location = new System.Drawing.Point(28, 15);
            this.lblTecNro.Name = "lblTecNro";
            this.lblTecNro.Size = new System.Drawing.Size(150, 22);
            this.lblTecNro.TabIndex = 0;
            this.lblTecNro.Text = "Tecnicatura Nº:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(52, 56);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(20, 134);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(50, 13);
            this.lblMaterias.TabIndex = 5;
            this.lblMaterias.Text = "Materias:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(103, 54);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(197, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(103, 90);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(197, 20);
            this.txtTitulo.TabIndex = 4;
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(23, 158);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(185, 21);
            this.cboMaterias.TabIndex = 6;
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(213, 162);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(68, 13);
            this.lblCuatrimestre.TabIndex = 7;
            this.lblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // rbtCuatr1
            // 
            this.rbtCuatr1.AutoSize = true;
            this.rbtCuatr1.Location = new System.Drawing.Point(283, 161);
            this.rbtCuatr1.Name = "rbtCuatr1";
            this.rbtCuatr1.Size = new System.Drawing.Size(35, 17);
            this.rbtCuatr1.TabIndex = 8;
            this.rbtCuatr1.TabStop = true;
            this.rbtCuatr1.Text = "1º";
            this.rbtCuatr1.UseVisualStyleBackColor = true;
            // 
            // rbtCuatr2
            // 
            this.rbtCuatr2.AutoSize = true;
            this.rbtCuatr2.Location = new System.Drawing.Point(319, 161);
            this.rbtCuatr2.Name = "rbtCuatr2";
            this.rbtCuatr2.Size = new System.Drawing.Size(35, 17);
            this.rbtCuatr2.TabIndex = 9;
            this.rbtCuatr2.TabStop = true;
            this.rbtCuatr2.Text = "2º";
            this.rbtCuatr2.UseVisualStyleBackColor = true;
            // 
            // lblAnioCursado
            // 
            this.lblAnioCursado.AutoSize = true;
            this.lblAnioCursado.Location = new System.Drawing.Point(362, 162);
            this.lblAnioCursado.Name = "lblAnioCursado";
            this.lblAnioCursado.Size = new System.Drawing.Size(71, 13);
            this.lblAnioCursado.TabIndex = 10;
            this.lblAnioCursado.Text = "Año Cursado:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(502, 155);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ClmMateria,
            this.ClmCuatrimestre,
            this.ClmAño,
            this.ClmAcciones});
            this.dgvMaterias.Location = new System.Drawing.Point(22, 186);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.Size = new System.Drawing.Size(555, 150);
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
            this.ClmMateria.HeaderText = "Materia";
            this.ClmMateria.MinimumWidth = 6;
            this.ClmMateria.Name = "ClmMateria";
            this.ClmMateria.ReadOnly = true;
            this.ClmMateria.Width = 125;
            // 
            // ClmCuatrimestre
            // 
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 125;
            // 
            // ClmAño
            // 
            this.ClmAño.HeaderText = "Año";
            this.ClmAño.MinimumWidth = 6;
            this.ClmAño.Name = "ClmAño";
            this.ClmAño.ReadOnly = true;
            this.ClmAño.Width = 125;
            // 
            // ClmAcciones
            // 
            this.ClmAcciones.HeaderText = "Acciones";
            this.ClmAcciones.MinimumWidth = 6;
            this.ClmAcciones.Name = "ClmAcciones";
            this.ClmAcciones.ReadOnly = true;
            this.ClmAcciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClmAcciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ClmAcciones.Text = "Quitar";
            this.ClmAcciones.UseColumnTextForButtonValue = true;
            this.ClmAcciones.Width = 125;
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(215, 362);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(78, 27);
            this.btnAniadir.TabIndex = 0;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(321, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 27);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // nudAnioCursado
            // 
            this.nudAnioCursado.Location = new System.Drawing.Point(434, 159);
            this.nudAnioCursado.Name = "nudAnioCursado";
            this.nudAnioCursado.Size = new System.Drawing.Size(50, 20);
            this.nudAnioCursado.TabIndex = 12;
            // 
            // lblTotalMaterias
            // 
            this.lblTotalMaterias.AutoSize = true;
            this.lblTotalMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalMaterias.Location = new System.Drawing.Point(452, 340);
            this.lblTotalMaterias.Name = "lblTotalMaterias";
            this.lblTotalMaterias.Size = new System.Drawing.Size(105, 15);
            this.lblTotalMaterias.TabIndex = 15;
            this.lblTotalMaterias.Text = "Total de Materias:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(64, 95);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 17;
            this.lblTitulo.Text = "Titulo:";
            // 
            // FrmNuevaTecnicatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(600, 405);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmNuevaTecnicatura";
            this.Text = "Nueva Tecnicatura";
            this.Load += new System.EventHandler(this.FrmTecnicatura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAño;
        private System.Windows.Forms.DataGridViewButtonColumn ClmAcciones;
        private System.Windows.Forms.Label lblTitulo;
    }
}