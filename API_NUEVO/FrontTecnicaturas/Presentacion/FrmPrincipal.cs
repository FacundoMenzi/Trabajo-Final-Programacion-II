using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrontTecnicaturas.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void carreraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            timer1.Start();
        }
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaMateria frm = new FrmNuevaMateria();
            frm.ShowDialog();
            frm.Dispose(); 
        }

        

        private void tecnicaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea salir del Programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevaTecnicatura frmNuevaTec = new FrmNuevaTecnicatura();
            frmNuevaTec.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultarTecnicaturas frmConsultarTec = new FrmConsultarTecnicaturas();
            frmConsultarTec.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReloj.Text = DateTime.Now.ToLongTimeString();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarMaterias frm = new FrmConsultarMaterias();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void desarrolladoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDesarrolladores frm = new FrmDesarrolladores();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
