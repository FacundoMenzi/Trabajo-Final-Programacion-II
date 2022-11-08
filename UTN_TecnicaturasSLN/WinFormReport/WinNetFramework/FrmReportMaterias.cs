using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WinNetFramework
{
    public partial class FrmReportMaterias : Form
    {
        public FrmReportMaterias()
        {
            InitializeComponent();
        }
        // Intentamos usar el HelperDao de la libreria, pero no nos dejaba hacerle referencia,
        // buscamos en google y resulta que es porque el proyecto tiene la versión net 6.0 y
        // WinNetFramework tiene 4.7.2 las cuales al no ser compatibles no permite hacer referencia,
        // Entonces creamos otro DbHelper (NetFramework)
        private void FrmReportMaterias_Load(object sender, EventArgs e)
        {
            CenterToParent();
            Cargar();
        }

        private void Cargar()
        {
            rptMaterias.LocalReport.DataSources.Clear();
            rptMaterias.LocalReport.DataSources.Add(new
            ReportDataSource("DataSetMaterias", HelperFramework.Instance().LoadReport("SP_REPORTE_MATERIAS",null)));

            this.rptMaterias.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
