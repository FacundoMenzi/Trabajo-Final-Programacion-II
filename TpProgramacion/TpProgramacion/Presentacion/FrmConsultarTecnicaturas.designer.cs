namespace TpProgramacion.Presentacion
{
    partial class FrmConsultarTecnicaturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarTecnicaturas));
            this.lblTecnicaturas = new System.Windows.Forms.Label();
            this.lstTecnicaturas = new System.Windows.Forms.ListBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAnioCursado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmQuitar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBorrarTec = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblCantTecnicaturas = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.rbtSegundo = new System.Windows.Forms.RadioButton();
            this.rbtPrimero = new System.Windows.Forms.RadioButton();
            this.LblAnio = new System.Windows.Forms.Label();
            this.LblCuatrimestre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.nudAnioCursado = new System.Windows.Forms.NumericUpDown();
            this.btnTecBajas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTecnicaturas
            // 
            this.lblTecnicaturas.AutoSize = true;
            this.lblTecnicaturas.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTecnicaturas.Location = new System.Drawing.Point(14, 14);
            this.lblTecnicaturas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTecnicaturas.Name = "lblTecnicaturas";
            this.lblTecnicaturas.Size = new System.Drawing.Size(117, 30);
            this.lblTecnicaturas.TabIndex = 0;
            this.lblTecnicaturas.Text = "Tecnicaturas:";
            // 
            // lstTecnicaturas
            // 
            this.lstTecnicaturas.FormattingEnabled = true;
            this.lstTecnicaturas.Location = new System.Drawing.Point(17, 62);
            this.lstTecnicaturas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstTecnicaturas.Name = "lstTecnicaturas";
            this.lstTecnicaturas.Size = new System.Drawing.Size(180, 329);
            this.lstTecnicaturas.TabIndex = 0;
            this.lstTecnicaturas.SelectedIndexChanged += new System.EventHandler(this.lstCarreras_SelectedIndexChanged);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmID,
            this.ClmMateria,
            this.ClmCuatrimestre,
            this.ClmAnioCursado,
            this.ClmQuitar});
            this.dgvDetalle.Location = new System.Drawing.Point(228, 201);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(492, 223);
            this.dgvDetalle.TabIndex = 11;
            this.dgvDetalle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellContentClick);
            // 
            // ClmID
            // 
            this.ClmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClmID.Visible = false;
            // 
            // ClmMateria
            // 
            this.ClmMateria.HeaderText = "Materia";
            this.ClmMateria.MinimumWidth = 6;
            this.ClmMateria.Name = "ClmMateria";
            this.ClmMateria.ReadOnly = true;
            this.ClmMateria.Width = 160;
            // 
            // ClmCuatrimestre
            // 
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 90;
            // 
            // ClmAnioCursado
            // 
            this.ClmAnioCursado.HeaderText = "Año";
            this.ClmAnioCursado.MinimumWidth = 6;
            this.ClmAnioCursado.Name = "ClmAnioCursado";
            this.ClmAnioCursado.ReadOnly = true;
            this.ClmAnioCursado.Width = 60;
            // 
            // ClmQuitar
            // 
            this.ClmQuitar.HeaderText = "Acciones";
            this.ClmQuitar.MinimumWidth = 6;
            this.ClmQuitar.Name = "ClmQuitar";
            this.ClmQuitar.ReadOnly = true;
            this.ClmQuitar.Text = "Quitar";
            this.ClmQuitar.UseColumnTextForButtonValue = true;
            this.ClmQuitar.Width = 128;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(226, 75);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(238, 104);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(36, 13);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(284, 72);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(219, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(284, 102);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(219, 20);
            this.txtTitulo.TabIndex = 5;
            // 
            // lblDetalles
            // 
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Location = new System.Drawing.Point(226, 152);
            this.lblDetalles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(48, 13);
            this.lblDetalles.TabIndex = 7;
            this.lblDetalles.Text = "Detalles:";
            this.lblDetalles.Click += new System.EventHandler(this.lblDetalles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(655, 433);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 28);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBorrarTec
            // 
            this.btnBorrarTec.Location = new System.Drawing.Point(107, 433);
            this.btnBorrarTec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrarTec.Name = "btnBorrarTec";
            this.btnBorrarTec.Size = new System.Drawing.Size(89, 28);
            this.btnBorrarTec.TabIndex = 2;
            this.btnBorrarTec.Text = "Dar de baja";
            this.btnBorrarTec.UseVisualStyleBackColor = true;
            this.btnBorrarTec.Click += new System.EventHandler(this.btnBorrarC_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 433);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(65, 28);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantTecnicaturas
            // 
            this.lblCantTecnicaturas.AutoSize = true;
            this.lblCantTecnicaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantTecnicaturas.Location = new System.Drawing.Point(15, 47);
            this.lblCantTecnicaturas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantTecnicaturas.Name = "lblCantTecnicaturas";
            this.lblCantTecnicaturas.Size = new System.Drawing.Size(111, 13);
            this.lblCantTecnicaturas.TabIndex = 12;
            this.lblCantTecnicaturas.Text = "Cant. de Tecnicaturas:";
            this.lblCantTecnicaturas.Click += new System.EventHandler(this.lblCantCarreras_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(17, 433);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(65, 28);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // cboMaterias
            // 
            this.cboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(228, 176);
            this.cboMaterias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(159, 21);
            this.cboMaterias.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(649, 173);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(71, 27);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // rbtSegundo
            // 
            this.rbtSegundo.AutoSize = true;
            this.rbtSegundo.Location = new System.Drawing.Point(493, 178);
            this.rbtSegundo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtSegundo.Name = "rbtSegundo";
            this.rbtSegundo.Size = new System.Drawing.Size(35, 17);
            this.rbtSegundo.TabIndex = 8;
            this.rbtSegundo.Text = "2°";
            this.rbtSegundo.UseVisualStyleBackColor = true;
            // 
            // rbtPrimero
            // 
            this.rbtPrimero.AutoSize = true;
            this.rbtPrimero.Location = new System.Drawing.Point(459, 178);
            this.rbtPrimero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbtPrimero.Name = "rbtPrimero";
            this.rbtPrimero.Size = new System.Drawing.Size(35, 17);
            this.rbtPrimero.TabIndex = 7;
            this.rbtPrimero.Text = "1°";
            this.rbtPrimero.UseVisualStyleBackColor = true;
            // 
            // LblAnio
            // 
            this.LblAnio.AutoSize = true;
            this.LblAnio.Location = new System.Drawing.Point(526, 180);
            this.LblAnio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnio.Name = "LblAnio";
            this.LblAnio.Size = new System.Drawing.Size(70, 13);
            this.LblAnio.TabIndex = 21;
            this.LblAnio.Text = "Año cursado:";
            // 
            // LblCuatrimestre
            // 
            this.LblCuatrimestre.AutoSize = true;
            this.LblCuatrimestre.Location = new System.Drawing.Point(391, 180);
            this.LblCuatrimestre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCuatrimestre.Name = "LblCuatrimestre";
            this.LblCuatrimestre.Size = new System.Drawing.Size(68, 13);
            this.LblCuatrimestre.TabIndex = 20;
            this.LblCuatrimestre.Text = "Cuatrimestre:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(228, 433);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(65, 28);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // nudAnioCursado
            // 
            this.nudAnioCursado.Location = new System.Drawing.Point(596, 177);
            this.nudAnioCursado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudAnioCursado.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAnioCursado.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAnioCursado.Name = "nudAnioCursado";
            this.nudAnioCursado.Size = new System.Drawing.Size(40, 20);
            this.nudAnioCursado.TabIndex = 22;
            this.nudAnioCursado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnTecBajas
            // 
            this.btnTecBajas.Location = new System.Drawing.Point(17, 395);
            this.btnTecBajas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTecBajas.Name = "btnTecBajas";
            this.btnTecBajas.Size = new System.Drawing.Size(179, 28);
            this.btnTecBajas.TabIndex = 23;
            this.btnTecBajas.Text = "Ver tecnicaturas anteriores";
            this.btnTecBajas.UseVisualStyleBackColor = true;
            this.btnTecBajas.Click += new System.EventHandler(this.btnTecBajas_Click);
            // 
            // FrmConsultarTecnicaturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 471);
            this.Controls.Add(this.btnTecBajas);
            this.Controls.Add(this.nudAnioCursado);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.rbtSegundo);
            this.Controls.Add(this.rbtPrimero);
            this.Controls.Add(this.LblAnio);
            this.Controls.Add(this.LblCuatrimestre);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCantTecnicaturas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBorrarTec);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lstTecnicaturas);
            this.Controls.Add(this.lblTecnicaturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmConsultarTecnicaturas";
            this.Text = "Tecnicaturas";
            this.Load += new System.EventHandler(this.FrmConsultarCarreras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCursado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTecnicaturas;
        private System.Windows.Forms.ListBox lstTecnicaturas;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBorrarTec;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCantTecnicaturas;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.ComboBox cboMaterias;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.RadioButton rbtSegundo;
        private System.Windows.Forms.RadioButton rbtPrimero;
        private System.Windows.Forms.Label LblAnio;
        private System.Windows.Forms.Label LblCuatrimestre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.NumericUpDown nudAnioCursado;
        private System.Windows.Forms.Button btnTecBajas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmCuatrimestre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmAnioCursado;
        private System.Windows.Forms.DataGridViewButtonColumn ClmQuitar;
    }
}