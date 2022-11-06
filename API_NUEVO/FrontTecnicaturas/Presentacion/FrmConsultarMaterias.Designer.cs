namespace FrontTecnicaturas.Presentacion
{
    partial class FrmConsultarMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultarMaterias));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.rbtTarde = new System.Windows.Forms.RadioButton();
            this.rbtMañana = new System.Windows.Forms.RadioButton();
            this.LblCuatrimestre = new System.Windows.Forms.Label();
            this.cboProfesores = new System.Windows.Forms.ComboBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblCantTecnicaturas = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBajaMat = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTecnicaturas = new System.Windows.Forms.Label();
            this.rbtNoche = new System.Windows.Forms.RadioButton();
            this.lstMateria = new System.Windows.Forms.ListBox();
            this.btnMatBajas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(439, 560);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 42);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // rbtTarde
            // 
            this.rbtTarde.AutoSize = true;
            this.rbtTarde.Location = new System.Drawing.Point(455, 389);
            this.rbtTarde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtTarde.Name = "rbtTarde";
            this.rbtTarde.Size = new System.Drawing.Size(66, 24);
            this.rbtTarde.TabIndex = 36;
            this.rbtTarde.Text = "Tarde";
            this.rbtTarde.UseVisualStyleBackColor = true;
            // 
            // rbtMañana
            // 
            this.rbtMañana.AutoSize = true;
            this.rbtMañana.Location = new System.Drawing.Point(455, 335);
            this.rbtMañana.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtMañana.Name = "rbtMañana";
            this.rbtMañana.Size = new System.Drawing.Size(83, 24);
            this.rbtMañana.TabIndex = 34;
            this.rbtMañana.Text = "Mañana";
            this.rbtMañana.UseVisualStyleBackColor = true;
            // 
            // LblCuatrimestre
            // 
            this.LblCuatrimestre.AutoSize = true;
            this.LblCuatrimestre.Location = new System.Drawing.Point(400, 286);
            this.LblCuatrimestre.Name = "LblCuatrimestre";
            this.LblCuatrimestre.Size = new System.Drawing.Size(50, 20);
            this.LblCuatrimestre.TabIndex = 42;
            this.LblCuatrimestre.Text = "Turno:";
            // 
            // cboProfesores
            // 
            this.cboProfesores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProfesores.FormattingEnabled = true;
            this.cboProfesores.Location = new System.Drawing.Point(455, 221);
            this.cboProfesores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboProfesores.Name = "cboProfesores";
            this.cboProfesores.Size = new System.Drawing.Size(291, 28);
            this.cboProfesores.TabIndex = 33;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(33, 668);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 42);
            this.btnModificar.TabIndex = 26;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblCantTecnicaturas
            // 
            this.lblCantTecnicaturas.AutoSize = true;
            this.lblCantTecnicaturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCantTecnicaturas.Location = new System.Drawing.Point(30, 71);
            this.lblCantTecnicaturas.Name = "lblCantTecnicaturas";
            this.lblCantTecnicaturas.Size = new System.Drawing.Size(106, 15);
            this.lblCantTecnicaturas.TabIndex = 39;
            this.lblCantTecnicaturas.Text = "Cant. de Materias:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(553, 560);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 42);
            this.btnCancelar.TabIndex = 29;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBajaMat
            // 
            this.btnBajaMat.Location = new System.Drawing.Point(218, 668);
            this.btnBajaMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBajaMat.Name = "btnBajaMat";
            this.btnBajaMat.Size = new System.Drawing.Size(119, 42);
            this.btnBajaMat.TabIndex = 27;
            this.btnBajaMat.Text = "Dar de baja";
            this.btnBajaMat.UseVisualStyleBackColor = true;
            this.btnBajaMat.Click += new System.EventHandler(this.btnBorrarTec_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(659, 668);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 42);
            this.btnSalir.TabIndex = 41;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(387, 225);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(64, 20);
            this.lblProfesor.TabIndex = 35;
            this.lblProfesor.Text = "Profesor";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(455, 139);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(291, 27);
            this.txtNombre.TabIndex = 31;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(386, 144);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 20);
            this.lblNombre.TabIndex = 28;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblTecnicaturas
            // 
            this.lblTecnicaturas.AutoSize = true;
            this.lblTecnicaturas.Font = new System.Drawing.Font("Myanmar Text", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTecnicaturas.Location = new System.Drawing.Point(12, 22);
            this.lblTecnicaturas.Name = "lblTecnicaturas";
            this.lblTecnicaturas.Size = new System.Drawing.Size(114, 39);
            this.lblTecnicaturas.TabIndex = 24;
            this.lblTecnicaturas.Text = "Materias:";
            // 
            // rbtNoche
            // 
            this.rbtNoche.AutoSize = true;
            this.rbtNoche.Location = new System.Drawing.Point(455, 443);
            this.rbtNoche.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtNoche.Name = "rbtNoche";
            this.rbtNoche.Size = new System.Drawing.Size(73, 24);
            this.rbtNoche.TabIndex = 46;
            this.rbtNoche.Text = "Noche";
            this.rbtNoche.UseVisualStyleBackColor = true;
            this.rbtNoche.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lstMateria
            // 
            this.lstMateria.FormattingEnabled = true;
            this.lstMateria.ItemHeight = 20;
            this.lstMateria.Location = new System.Drawing.Point(33, 98);
            this.lstMateria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstMateria.Name = "lstMateria";
            this.lstMateria.Size = new System.Drawing.Size(304, 504);
            this.lstMateria.TabIndex = 47;
            this.lstMateria.SelectedIndexChanged += new System.EventHandler(this.lstMateria_SelectedIndexChanged);
            // 
            // btnMatBajas
            // 
            this.btnMatBajas.Location = new System.Drawing.Point(33, 608);
            this.btnMatBajas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMatBajas.Name = "btnMatBajas";
            this.btnMatBajas.Size = new System.Drawing.Size(304, 42);
            this.btnMatBajas.TabIndex = 48;
            this.btnMatBajas.Text = "Ver materias anteriores";
            this.btnMatBajas.UseVisualStyleBackColor = true;
            this.btnMatBajas.Click += new System.EventHandler(this.btnMatBajas_Click);
            // 
            // FrmConsultarMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 735);
            this.Controls.Add(this.btnMatBajas);
            this.Controls.Add(this.lstMateria);
            this.Controls.Add(this.rbtNoche);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.rbtTarde);
            this.Controls.Add(this.rbtMañana);
            this.Controls.Add(this.LblCuatrimestre);
            this.Controls.Add(this.cboProfesores);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lblCantTecnicaturas);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBajaMat);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblProfesor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTecnicaturas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmConsultarMaterias";
            this.Text = "Consultar Materias";
            this.Load += new System.EventHandler(this.FrmNuevaMateria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.RadioButton rbtTarde;
        private System.Windows.Forms.RadioButton rbtMañana;
        private System.Windows.Forms.Label LblCuatrimestre;
        private System.Windows.Forms.ComboBox cboProfesores;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblCantTecnicaturas;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBajaMat;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ListBox lstMaterias;
        private System.Windows.Forms.Label lblTecnicaturas;
        private System.Windows.Forms.RadioButton rbtNoche;
        private System.Windows.Forms.ListBox lstMateria;
        private System.Windows.Forms.Button btnMatBajas;
    }
}