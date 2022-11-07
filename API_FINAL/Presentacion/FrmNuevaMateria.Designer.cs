namespace FrontTecnicaturas.Presentacion
{
    partial class FrmNuevaMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNuevaMateria));
            this.rbtNoche = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAniadir = new System.Windows.Forms.Button();
            this.rbtTarde = new System.Windows.Forms.RadioButton();
            this.rbtMañana = new System.Windows.Forms.RadioButton();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.cboProfesor = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMatNro = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rbtNoche
            // 
            this.rbtNoche.AutoSize = true;
            this.rbtNoche.Location = new System.Drawing.Point(116, 351);
            this.rbtNoche.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtNoche.Name = "rbtNoche";
            this.rbtNoche.Size = new System.Drawing.Size(73, 24);
            this.rbtNoche.TabIndex = 45;
            this.rbtNoche.TabStop = true;
            this.rbtNoche.Text = "Noche";
            this.rbtNoche.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(273, 440);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 41);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnAniadir
            // 
            this.btnAniadir.Location = new System.Drawing.Point(116, 440);
            this.btnAniadir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAniadir.Name = "btnAniadir";
            this.btnAniadir.Size = new System.Drawing.Size(104, 41);
            this.btnAniadir.TabIndex = 36;
            this.btnAniadir.Text = "Añadir";
            this.btnAniadir.UseVisualStyleBackColor = true;
            this.btnAniadir.Click += new System.EventHandler(this.btnAniadir_Click_1);
            // 
            // rbtTarde
            // 
            this.rbtTarde.AutoSize = true;
            this.rbtTarde.Location = new System.Drawing.Point(116, 302);
            this.rbtTarde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtTarde.Name = "rbtTarde";
            this.rbtTarde.Size = new System.Drawing.Size(66, 24);
            this.rbtTarde.TabIndex = 43;
            this.rbtTarde.TabStop = true;
            this.rbtTarde.Text = "Tarde";
            this.rbtTarde.UseVisualStyleBackColor = true;
            // 
            // rbtMañana
            // 
            this.rbtMañana.AutoSize = true;
            this.rbtMañana.Location = new System.Drawing.Point(116, 256);
            this.rbtMañana.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtMañana.Name = "rbtMañana";
            this.rbtMañana.Size = new System.Drawing.Size(83, 24);
            this.rbtMañana.TabIndex = 42;
            this.rbtMañana.TabStop = true;
            this.rbtMañana.Text = "Mañana";
            this.rbtMañana.UseVisualStyleBackColor = true;
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Location = new System.Drawing.Point(55, 216);
            this.lblTurnos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(50, 20);
            this.lblTurnos.TabIndex = 41;
            this.lblTurnos.Text = "Turno:";
            // 
            // cboProfesor
            // 
            this.cboProfesor.FormattingEnabled = true;
            this.cboProfesor.Location = new System.Drawing.Point(116, 162);
            this.cboProfesor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboProfesor.Name = "cboProfesor";
            this.cboProfesor.Size = new System.Drawing.Size(261, 28);
            this.cboProfesor.TabIndex = 40;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(116, 101);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(261, 27);
            this.txtNombre.TabIndex = 38;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(41, 166);
            this.lblProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(67, 20);
            this.lblProfesor.TabIndex = 39;
            this.lblProfesor.Text = "Profesor:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(44, 105);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 37;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblMatNro
            // 
            this.lblMatNro.AutoSize = true;
            this.lblMatNro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMatNro.Location = new System.Drawing.Point(22, 34);
            this.lblMatNro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatNro.Name = "lblMatNro";
            this.lblMatNro.Size = new System.Drawing.Size(131, 26);
            this.lblMatNro.TabIndex = 35;
            this.lblMatNro.Text = "Materia Nº:";
            // 
            // FrmNuevaMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 554);
            this.Controls.Add(this.rbtNoche);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAniadir);
            this.Controls.Add(this.rbtTarde);
            this.Controls.Add(this.rbtMañana);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.cboProfesor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblMatNro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmNuevaMateria";
            this.Text = "Nueva Materia";
            this.Load += new System.EventHandler(this.FrmNuevaMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtNoche;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAniadir;
        private System.Windows.Forms.RadioButton rbtTarde;
        private System.Windows.Forms.RadioButton rbtMañana;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblMatNro;
    }
}