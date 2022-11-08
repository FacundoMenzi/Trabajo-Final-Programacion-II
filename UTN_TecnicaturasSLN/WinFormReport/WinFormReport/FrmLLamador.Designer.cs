namespace WinFormReport
{
    partial class FrmLLamador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLLamador));
            this.btnRptMaterias = new System.Windows.Forms.Button();
            this.btnRptAlumnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRptMaterias
            // 
            this.btnRptMaterias.BackColor = System.Drawing.Color.White;
            this.btnRptMaterias.BackgroundImage = global::WinFormReport.Properties.Resources.Ver_Materias;
            this.btnRptMaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRptMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRptMaterias.Location = new System.Drawing.Point(14, 13);
            this.btnRptMaterias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRptMaterias.Name = "btnRptMaterias";
            this.btnRptMaterias.Size = new System.Drawing.Size(291, 363);
            this.btnRptMaterias.TabIndex = 0;
            this.btnRptMaterias.UseVisualStyleBackColor = false;
            this.btnRptMaterias.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRptAlumnos
            // 
            this.btnRptAlumnos.BackColor = System.Drawing.Color.White;
            this.btnRptAlumnos.BackgroundImage = global::WinFormReport.Properties.Resources.Ver_Alumnos;
            this.btnRptAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRptAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRptAlumnos.Location = new System.Drawing.Point(313, 13);
            this.btnRptAlumnos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRptAlumnos.Name = "btnRptAlumnos";
            this.btnRptAlumnos.Size = new System.Drawing.Size(291, 363);
            this.btnRptAlumnos.TabIndex = 1;
            this.btnRptAlumnos.UseVisualStyleBackColor = false;
            this.btnRptAlumnos.Click += new System.EventHandler(this.btnRptAlumnos_Click);
            // 
            // FrmLLamador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(618, 392);
            this.Controls.Add(this.btnRptAlumnos);
            this.Controls.Add(this.btnRptMaterias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmLLamador";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.FrmLLamador_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRptMaterias;
        private Button btnRptAlumnos;
    }
}