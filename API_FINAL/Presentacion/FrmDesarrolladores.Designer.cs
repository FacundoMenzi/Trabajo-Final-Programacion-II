namespace FrontTecnicaturas.Presentacion
{
    partial class FrmDesarrolladores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDesarrolladores));
            this.lblTB = new System.Windows.Forms.Label();
            this.lblTO = new System.Windows.Forms.Label();
            this.lblFM = new System.Windows.Forms.Label();
            this.lblCM = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTB.Location = new System.Drawing.Point(50, 28);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(168, 20);
            this.lblTB.TabIndex = 0;
            this.lblTB.Text = "Tomás Benza | 114036";
            // 
            // lblTO
            // 
            this.lblTO.AutoSize = true;
            this.lblTO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTO.Location = new System.Drawing.Point(388, 28);
            this.lblTO.Name = "lblTO";
            this.lblTO.Size = new System.Drawing.Size(174, 20);
            this.lblTO.TabIndex = 1;
            this.lblTO.Text = "Tomás Ortega | 114120";
            // 
            // lblFM
            // 
            this.lblFM.AutoSize = true;
            this.lblFM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFM.Location = new System.Drawing.Point(37, 80);
            this.lblFM.Name = "lblFM";
            this.lblFM.Size = new System.Drawing.Size(181, 20);
            this.lblFM.TabIndex = 2;
            this.lblFM.Text = "Facundo Menzi | 113992";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCM.Location = new System.Drawing.Point(370, 80);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(192, 20);
            this.lblCM.TabIndex = 3;
            this.lblCM.Text = "Candelaria Mello | 113905";
            // 
            // FrmDesarrolladores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 133);
            this.Controls.Add(this.lblCM);
            this.Controls.Add(this.lblFM);
            this.Controls.Add(this.lblTO);
            this.Controls.Add(this.lblTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmDesarrolladores";
            this.Text = "Desarrolladores";
            this.Load += new System.EventHandler(this.FrmDesarrolladores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTB;
        private Label lblTO;
        private Label lblFM;
        private Label lblCM;
    }
}