namespace WinNetFramework
{
    partial class FrmReportMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportMaterias));
            this.rptMaterias = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptMaterias
            // 
            this.rptMaterias.BackColor = System.Drawing.Color.Azure;
            this.rptMaterias.LocalReport.ReportEmbeddedResource = "WinNetFramework.Reporte.ReportMaterias.rdlc";
            this.rptMaterias.Location = new System.Drawing.Point(12, 14);
            this.rptMaterias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rptMaterias.Name = "rptMaterias";
            this.rptMaterias.ServerReport.BearerToken = null;
            this.rptMaterias.ShowBackButton = false;
            this.rptMaterias.ShowContextMenu = false;
            this.rptMaterias.ShowCredentialPrompts = false;
            this.rptMaterias.ShowDocumentMapButton = false;
            this.rptMaterias.ShowFindControls = false;
            this.rptMaterias.ShowParameterPrompts = false;
            this.rptMaterias.ShowProgress = false;
            this.rptMaterias.ShowPromptAreaButton = false;
            this.rptMaterias.Size = new System.Drawing.Size(846, 424);
            this.rptMaterias.TabIndex = 0;
            this.rptMaterias.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // FrmReportMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 450);
            this.Controls.Add(this.rptMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmReportMaterias";
            this.Text = "Materias";
            this.Load += new System.EventHandler(this.FrmReportMaterias_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptMaterias;
    }
}