namespace FrontTecnicaturas.Presentacion
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.lblUtn = new System.Windows.Forms.Label();
            this.pbUTN = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pbContrasenia = new System.Windows.Forms.PictureBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.pic_ojo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasenia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ojo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = global::FrontTecnicaturas.Properties.Resources.usuario;
            this.pbUsuario.Location = new System.Drawing.Point(53, 328);
            this.pbUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(71, 54);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUsuario.TabIndex = 9;
            this.pbUsuario.TabStop = false;
            this.pbUsuario.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // lblUtn
            // 
            this.lblUtn.AutoSize = true;
            this.lblUtn.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUtn.Location = new System.Drawing.Point(137, 254);
            this.lblUtn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUtn.Name = "lblUtn";
            this.lblUtn.Size = new System.Drawing.Size(175, 30);
            this.lblUtn.TabIndex = 1;
            this.lblUtn.Text = "Bienvenido a la UTN";
            // 
            // pbUTN
            // 
            this.pbUTN.Image = global::FrontTecnicaturas.Properties.Resources.utn;
            this.pbUTN.Location = new System.Drawing.Point(110, 31);
            this.pbUTN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbUTN.Name = "pbUTN";
            this.pbUTN.Size = new System.Drawing.Size(235, 219);
            this.pbUTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUTN.TabIndex = 8;
            this.pbUTN.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(124, 349);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(207, 27);
            this.txtUsuario.TabIndex = 3;
            // 
            // pbContrasenia
            // 
            this.pbContrasenia.Image = global::FrontTecnicaturas.Properties.Resources.contraseña;
            this.pbContrasenia.Location = new System.Drawing.Point(53, 430);
            this.pbContrasenia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pbContrasenia.Name = "pbContrasenia";
            this.pbContrasenia.Size = new System.Drawing.Size(71, 48);
            this.pbContrasenia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbContrasenia.TabIndex = 7;
            this.pbContrasenia.TabStop = false;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(124, 440);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(207, 27);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            this.txtContraseña.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.Location = new System.Drawing.Point(156, 545);
            this.btnIniciarSesion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(143, 35);
            this.btnIniciarSesion.TabIndex = 6;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // pic_ojo
            // 
            this.pic_ojo.Image = global::FrontTecnicaturas.Properties.Resources.ojo_abierto;
            this.pic_ojo.Location = new System.Drawing.Point(338, 430);
            this.pic_ojo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_ojo.Name = "pic_ojo";
            this.pic_ojo.Size = new System.Drawing.Size(64, 48);
            this.pic_ojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_ojo.TabIndex = 0;
            this.pic_ojo.TabStop = false;
            this.pic_ojo.Click += new System.EventHandler(this.pic_ojo_Click_1);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(457, 646);
            this.Controls.Add(this.pic_ojo);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.pbContrasenia);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.pbUTN);
            this.Controls.Add(this.lblUtn);
            this.Controls.Add(this.pbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContrasenia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.Label lblUtn;
        private System.Windows.Forms.PictureBox pbUTN;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbContrasenia;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnIniciarSesion;
        private PictureBox pic_ojo;
    }
}