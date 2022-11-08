namespace WinNetFramework
{
    partial class FrmReportAlumnos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportAlumnos));
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nudPromedio = new System.Windows.Forms.NumericUpDown();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.chkPromedio = new System.Windows.Forms.CheckBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(189, 97);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(197, 22);
            this.txtApellido.TabIndex = 0;
            // 
            // nudPromedio
            // 
            this.nudPromedio.Enabled = false;
            this.nudPromedio.Location = new System.Drawing.Point(604, 97);
            this.nudPromedio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudPromedio.Name = "nudPromedio";
            this.nudPromedio.Size = new System.Drawing.Size(77, 22);
            this.nudPromedio.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(27, 100);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(129, 16);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido del alumno:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(701, 91);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(123, 36);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // chkPromedio
            // 
            this.chkPromedio.AutoSize = true;
            this.chkPromedio.Location = new System.Drawing.Point(402, 100);
            this.chkPromedio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkPromedio.Name = "chkPromedio";
            this.chkPromedio.Size = new System.Drawing.Size(177, 20);
            this.chkPromedio.TabIndex = 5;
            this.chkPromedio.Text = "Que supere el promedio:";
            this.chkPromedio.UseVisualStyleBackColor = true;
            this.chkPromedio.CheckedChanged += new System.EventHandler(this.chkPromedio_CheckedChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.Azure;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WinNetFramework.Reporte.ReportAlumnos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(29, 143);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(796, 364);
            this.reportViewer1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 48);
            this.label1.TabIndex = 7;
            this.label1.Text = "Alumnos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinNetFramework.Properties.Resources.usuario_nuevo;
            this.pictureBox1.Location = new System.Drawing.Point(737, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReportAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(837, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.chkPromedio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.nudPromedio);
            this.Controls.Add(this.txtApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FrmReportAlumnos";
            this.Text = "Alumnos";
            this.Load += new System.EventHandler(this.FrmReportAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPromedio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nudPromedio;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox chkPromedio;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}