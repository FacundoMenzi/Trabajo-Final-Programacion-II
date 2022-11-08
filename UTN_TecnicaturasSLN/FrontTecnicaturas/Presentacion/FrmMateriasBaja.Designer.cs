namespace FrontTecnicaturas.Presentacion
{
    partial class FrmMateriasBaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMateriasBaja));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lstMatBajas = new System.Windows.Forms.ListBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.rbtNoche = new System.Windows.Forms.RadioButton();
            this.rbtTarde = new System.Windows.Forms.RadioButton();
            this.rbtMañana = new System.Windows.Forms.RadioButton();
            this.txtProfesor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(22, 45);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(99, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 27);
            this.txtNombre.TabIndex = 18;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(22, 96);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(67, 20);
            this.lblProfesor.TabIndex = 17;
            this.lblProfesor.Text = "Profesor:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(641, 477);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 49);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Red;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(182, 477);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 49);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlta.Enabled = false;
            this.btnAlta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlta.ForeColor = System.Drawing.Color.White;
            this.btnAlta.Location = new System.Drawing.Point(14, 477);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(114, 49);
            this.btnAlta.TabIndex = 13;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(14, 12);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(225, 39);
            this.lblMateria.TabIndex = 12;
            this.lblMateria.Text = "Materias anteriores:";
            // 
            // lstMatBajas
            // 
            this.lstMatBajas.BackColor = System.Drawing.Color.Azure;
            this.lstMatBajas.FormattingEnabled = true;
            this.lstMatBajas.ItemHeight = 20;
            this.lstMatBajas.Location = new System.Drawing.Point(14, 55);
            this.lstMatBajas.Name = "lstMatBajas";
            this.lstMatBajas.Size = new System.Drawing.Size(282, 404);
            this.lstMatBajas.TabIndex = 11;
            this.lstMatBajas.SelectedIndexChanged += new System.EventHandler(this.lstMatBajas_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(37, 147);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 20);
            this.lblTurno.TabIndex = 22;
            this.lblTurno.Text = "Turno:";
            // 
            // rbtNoche
            // 
            this.rbtNoche.AutoSize = true;
            this.rbtNoche.Enabled = false;
            this.rbtNoche.Location = new System.Drawing.Point(99, 205);
            this.rbtNoche.Name = "rbtNoche";
            this.rbtNoche.Size = new System.Drawing.Size(73, 24);
            this.rbtNoche.TabIndex = 49;
            this.rbtNoche.Text = "Noche";
            this.rbtNoche.UseVisualStyleBackColor = true;
            // 
            // rbtTarde
            // 
            this.rbtTarde.AutoSize = true;
            this.rbtTarde.Enabled = false;
            this.rbtTarde.Location = new System.Drawing.Point(99, 175);
            this.rbtTarde.Name = "rbtTarde";
            this.rbtTarde.Size = new System.Drawing.Size(66, 24);
            this.rbtTarde.TabIndex = 48;
            this.rbtTarde.Text = "Tarde";
            this.rbtTarde.UseVisualStyleBackColor = true;
            // 
            // rbtMañana
            // 
            this.rbtMañana.AutoSize = true;
            this.rbtMañana.Enabled = false;
            this.rbtMañana.Location = new System.Drawing.Point(99, 144);
            this.rbtMañana.Name = "rbtMañana";
            this.rbtMañana.Size = new System.Drawing.Size(83, 24);
            this.rbtMañana.TabIndex = 47;
            this.rbtMañana.Text = "Mañana";
            this.rbtMañana.UseVisualStyleBackColor = true;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Enabled = false;
            this.txtProfesor.Location = new System.Drawing.Point(99, 91);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(313, 27);
            this.txtProfesor.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProfesor);
            this.groupBox1.Controls.Add(this.rbtNoche);
            this.groupBox1.Controls.Add(this.rbtTarde);
            this.groupBox1.Controls.Add(this.rbtMañana);
            this.groupBox1.Controls.Add(this.lblTurno);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblProfesor);
            this.groupBox1.Location = new System.Drawing.Point(314, 193);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 265);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontTecnicaturas.Properties.Resources.anteriores;
            this.pictureBox1.Location = new System.Drawing.Point(629, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FrontTecnicaturas.Properties.Resources.UTN_FONDO;
            this.pictureBox2.Location = new System.Drawing.Point(314, 28);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(302, 156);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 53;
            this.pictureBox2.TabStop = false;
            // 
            // FrmMateriasBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(786, 560);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lstMatBajas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmMateriasBaja";
            this.Text = "Materias Anteriores";
            this.Load += new System.EventHandler(this.FrmMateriasBaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ListBox lstMatBajas;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.RadioButton rbtNoche;
        private System.Windows.Forms.RadioButton rbtTarde;
        private System.Windows.Forms.RadioButton rbtMañana;
        private TextBox txtProfesor;
        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}