using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinNetFramework
{
    public partial class FrmReportAlumnos : Form
    {
        public FrmReportAlumnos()
        {
            InitializeComponent();
        }

        private void FrmReportAlumnos_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Cargar();   
            this.reportViewer1.RefreshReport();
        }
        // Intentamos usar el HelperDao de la libreria, pero no nos dejaba hacerle referencia,
        // buscamos en google y resulta que es porque el proyecto tiene la versión net 6.0 y
        // WinNetFramework tiene 4.7.2 las cuales al no ser compatibles no permite hacer referencia,
        // Entonces creamos otro DbHelper (NetFramework)
        private void Cargar()
        {
            List<ParametroFramework> lst = new List<ParametroFramework>();
            lst.Add(new ParametroFramework("@apellido", txtApellido.Text));
            int activo = 0;
            if (chkPromedio.Checked)
            {
                lst.Add(new ParametroFramework("@promedio", (int)nudPromedio.Value));
                activo = 1;
            }
            lst.Add(new ParametroFramework("@activo", activo));
            
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(new
            ReportDataSource("DataSetAlumnos", HelperFramework.Instance().LoadReport("SP_REPORTE_ALUMNOS",lst)));

        }

        private void chkPromedio_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPromedio.Checked)
            {
                nudPromedio.Enabled = true;
            }
            else nudPromedio.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cargar();
            this.reportViewer1.RefreshReport();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
