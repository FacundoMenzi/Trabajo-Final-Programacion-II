namespace FrontTecnicaturas.Presentacion
{
    partial class FrmTecnicaturasBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTecnicaturasBaja));
            this.lstTecBajas = new System.Windows.Forms.ListBox();
            this.lblTecnicaturas = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.ClmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmCuatrimestre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClmAnio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstTecBajas
            // 
            this.lstTecBajas.BackColor = System.Drawing.Color.Azure;
            this.lstTecBajas.FormattingEnabled = true;
            this.lstTecBajas.ItemHeight = 20;
            this.lstTecBajas.Location = new System.Drawing.Point(35, 63);
            this.lstTecBajas.Name = "lstTecBajas";
            this.lstTecBajas.Size = new System.Drawing.Size(205, 384);
            this.lstTecBajas.TabIndex = 0;
            this.lstTecBajas.SelectedIndexChanged += new System.EventHandler(this.lstTecBajas_SelectedIndexChanged);
            // 
            // lblTecnicaturas
            // 
            this.lblTecnicaturas.AutoSize = true;
            this.lblTecnicaturas.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTecnicaturas.Location = new System.Drawing.Point(29, 17);
            this.lblTecnicaturas.Name = "lblTecnicaturas";
            this.lblTecnicaturas.Size = new System.Drawing.Size(259, 39);
            this.lblTecnicaturas.TabIndex = 1;
            this.lblTecnicaturas.Text = "Tecnicaturas anteriores";
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.Enabled = false;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(35, 467);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(96, 49);
            this.btnAlta.TabIndex = 2;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(145, 467);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 49);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.AllowUserToDeleteRows = false;
            this.dgvMaterias.BackgroundColor = System.Drawing.Color.Azure;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmID,
            this.ClmMateria,
            this.ClmCuatrimestre,
            this.ClmAnio});
            this.dgvMaterias.Enabled = false;
            this.dgvMaterias.Location = new System.Drawing.Point(257, 179);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.RowHeadersWidth = 51;
            this.dgvMaterias.RowTemplate.Height = 24;
            this.dgvMaterias.Size = new System.Drawing.Size(504, 269);
            this.dgvMaterias.TabIndex = 4;
            // 
            // ClmID
            // 
            this.ClmID.HeaderText = "ID";
            this.ClmID.MinimumWidth = 6;
            this.ClmID.Name = "ClmID";
            this.ClmID.ReadOnly = true;
            this.ClmID.Visible = false;
            this.ClmID.Width = 6;
            // 
            // ClmMateria
            // 
            this.ClmMateria.HeaderText = "Materia";
            this.ClmMateria.MinimumWidth = 6;
            this.ClmMateria.Name = "ClmMateria";
            this.ClmMateria.ReadOnly = true;
            this.ClmMateria.Width = 250;
            // 
            // ClmCuatrimestre
            // 
            this.ClmCuatrimestre.HeaderText = "Cuatrimestre";
            this.ClmCuatrimestre.MinimumWidth = 6;
            this.ClmCuatrimestre.Name = "ClmCuatrimestre";
            this.ClmCuatrimestre.ReadOnly = true;
            this.ClmCuatrimestre.Width = 125;
            // 
            // ClmAnio
            // 
            this.ClmAnio.HeaderText = "Año";
            this.ClmAnio.MinimumWidth = 6;
            this.ClmAnio.Name = "ClmAnio";
            this.ClmAnio.ReadOnly = true;
            this.ClmAnio.Width = 75;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(657, 467);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 49);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(259, 156);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(69, 20);
            this.lblMaterias.TabIndex = 6;
            this.lblMaterias.Text = "Materias:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(325, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(317, 27);
            this.txtNombre.TabIndex = 7;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Enabled = false;
            this.txtTitulo.Location = new System.Drawing.Point(325, 111);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(317, 27);
            this.txtTitulo.TabIndex = 8;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(261, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(277, 115);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(50, 20);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Título:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontTecnicaturas.Properties.Resources.anteriores;
            this.pictureBox1.Location = new System.Drawing.Point(670, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmTecnicaturasBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(799, 547);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblTecnicaturas);
            this.Controls.Add(this.lstTecBajas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmTecnicaturasBaja";
            this.Text = "Tecnicaturas anteriores";
            this.Load += new System.EventHandler(this.FrmTecnicaturasBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstTecBajas;
        private System.Windows.Forms.Label lblTecnicaturas;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn ClmID;
        private DataGridViewTextBoxColumn ClmMateria;
        private DataGridViewTextBoxColumn ClmCuatrimestre;
        private DataGridViewTextBoxColumn ClmAnio;
    }
}