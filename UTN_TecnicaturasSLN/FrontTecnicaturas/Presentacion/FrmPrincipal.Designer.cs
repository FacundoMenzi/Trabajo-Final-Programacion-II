namespace FrontTecnicaturas.Presentacion
{
    partial class FrmPrincipal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicaturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carreraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desarrolladoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblReloj = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.tecnicaturaToolStripMenuItem,
            this.carreraToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(105, 519);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.archivo;
            this.archivoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.salirToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.quit;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tecnicaturaToolStripMenuItem
            // 
            this.tecnicaturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem,
            this.nuevaToolStripMenuItem});
            this.tecnicaturaToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.soporte;
            this.tecnicaturaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tecnicaturaToolStripMenuItem.Name = "tecnicaturaToolStripMenuItem";
            this.tecnicaturaToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.tecnicaturaToolStripMenuItem.Text = "Soporte";
            this.tecnicaturaToolStripMenuItem.Click += new System.EventHandler(this.tecnicaturaToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.consulta;
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.consultarToolStripMenuItem.Text = "Consultar Materias";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // nuevaToolStripMenuItem
            // 
            this.nuevaToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources._new;
            this.nuevaToolStripMenuItem.Name = "nuevaToolStripMenuItem";
            this.nuevaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.nuevaToolStripMenuItem.Text = "Nueva Materia";
            this.nuevaToolStripMenuItem.Click += new System.EventHandler(this.nuevaToolStripMenuItem_Click);
            // 
            // carreraToolStripMenuItem
            // 
            this.carreraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem1,
            this.nuevoToolStripMenuItem});
            this.carreraToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.transaccion;
            this.carreraToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.carreraToolStripMenuItem.Name = "carreraToolStripMenuItem";
            this.carreraToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.carreraToolStripMenuItem.Text = "Transacción";
            this.carreraToolStripMenuItem.Click += new System.EventHandler(this.carreraToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem1
            // 
            this.consultarToolStripMenuItem1.Image = global::FrontTecnicaturas.Properties.Resources.consulta;
            this.consultarToolStripMenuItem1.Name = "consultarToolStripMenuItem1";
            this.consultarToolStripMenuItem1.Size = new System.Drawing.Size(193, 22);
            this.consultarToolStripMenuItem1.Text = "Consultar Tecnicaturas";
            this.consultarToolStripMenuItem1.Click += new System.EventHandler(this.consultarToolStripMenuItem1_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources._new;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.nuevoToolStripMenuItem.Text = "Nueva Tecnicatura";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.reportes;
            this.reportesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desarrolladoresToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.about;
            this.acercaDeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // desarrolladoresToolStripMenuItem
            // 
            this.desarrolladoresToolStripMenuItem.Image = global::FrontTecnicaturas.Properties.Resources.debelopers;
            this.desarrolladoresToolStripMenuItem.Name = "desarrolladoresToolStripMenuItem";
            this.desarrolladoresToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.desarrolladoresToolStripMenuItem.Text = "Desarrolladores";
            this.desarrolladoresToolStripMenuItem.Click += new System.EventHandler(this.desarrolladoresToolStripMenuItem_Click);
            // 
            // lblReloj
            // 
            this.lblReloj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReloj.AutoSize = true;
            this.lblReloj.Font = new System.Drawing.Font("Myanmar Text", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReloj.Location = new System.Drawing.Point(708, 482);
            this.lblReloj.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReloj.Name = "lblReloj";
            this.lblReloj.Size = new System.Drawing.Size(0, 114);
            this.lblReloj.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::FrontTecnicaturas.Properties.Resources.UTN_FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(797, 519);
            this.Controls.Add(this.lblReloj);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicaturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carreraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desarrolladoresToolStripMenuItem;
        private System.Windows.Forms.Label lblReloj;
    }
}

