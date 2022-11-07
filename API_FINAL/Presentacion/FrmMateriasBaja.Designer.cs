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
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(361, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(439, 104);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(313, 27);
            this.txtNombre.TabIndex = 18;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(361, 180);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(67, 20);
            this.lblProfesor.TabIndex = 17;
            this.lblProfesor.Text = "Profesor:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(648, 498);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(104, 49);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(233, 498);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 49);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Enabled = false;
            this.btnAlta.Location = new System.Drawing.Point(39, 498);
            this.btnAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(96, 49);
            this.btnAlta.TabIndex = 13;
            this.btnAlta.Text = "Dar Alta";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateria.Location = new System.Drawing.Point(20, 36);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(225, 39);
            this.lblMateria.TabIndex = 12;
            this.lblMateria.Text = "Materias anteriores:";
            // 
            // lstMatBajas
            // 
            this.lstMatBajas.FormattingEnabled = true;
            this.lstMatBajas.ItemHeight = 20;
            this.lstMatBajas.Location = new System.Drawing.Point(39, 81);
            this.lstMatBajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMatBajas.Name = "lstMatBajas";
            this.lstMatBajas.Size = new System.Drawing.Size(282, 404);
            this.lstMatBajas.TabIndex = 11;
            this.lstMatBajas.SelectedIndexChanged += new System.EventHandler(this.lstMatBajas_SelectedIndexChanged);
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(378, 259);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(50, 20);
            this.lblTurno.TabIndex = 22;
            this.lblTurno.Text = "Turno:";
            // 
            // rbtNoche
            // 
            this.rbtNoche.AutoSize = true;
            this.rbtNoche.Enabled = false;
            this.rbtNoche.Location = new System.Drawing.Point(439, 407);
            this.rbtNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rbtTarde.Location = new System.Drawing.Point(439, 353);
            this.rbtTarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.rbtMañana.Location = new System.Drawing.Point(439, 300);
            this.rbtMañana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMañana.Name = "rbtMañana";
            this.rbtMañana.Size = new System.Drawing.Size(83, 24);
            this.rbtMañana.TabIndex = 47;
            this.rbtMañana.Text = "Mañana";
            this.rbtMañana.UseVisualStyleBackColor = true;
            // 
            // txtProfesor
            // 
            this.txtProfesor.Enabled = false;
            this.txtProfesor.Location = new System.Drawing.Point(439, 177);
            this.txtProfesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProfesor.Name = "txtProfesor";
            this.txtProfesor.Size = new System.Drawing.Size(313, 27);
            this.txtProfesor.TabIndex = 50;
            // 
            // FrmMateriasBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 560);
            this.Controls.Add(this.txtProfesor);
            this.Controls.Add(this.rbtNoche);
            this.Controls.Add(this.rbtTarde);
            this.Controls.Add(this.rbtMañana);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lstMatBajas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMateriasBaja";
            this.Text = "Materias Anteriores";
            this.Load += new System.EventHandler(this.FrmMateriasBaja_Load);
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
    }
}