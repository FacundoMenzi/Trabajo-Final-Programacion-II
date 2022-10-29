using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TpProgramacion.Dominio;
using TpProgramacion.Servicios;
using TpProgramacion.Servicios.Interfaces;

namespace TpProgramacion.Presentacion
{
    public partial class FrmTecnicaturasBaja : Form
    {
        IServicio servicio;
        List<Tecnicatura> lTecnicatura;

        public FrmTecnicaturasBaja()
        {
            InitializeComponent();
            CenterToParent();
            servicio=new Factory().CrearServicio();
            lTecnicatura=new List<Tecnicatura>();
        }

        private void FrmTecnicaturasBaja_Load(object sender, EventArgs e)
        {
            CargarTecnicaturas();

        }

        private void CargarTecnicaturas()
        {
            lstTecBajas.Items.Clear();
            lTecnicatura.Clear();

            lTecnicatura = servicio.CargarListaTecnicaturasBajas();
            foreach (Tecnicatura t in lTecnicatura)
            {
                lstTecBajas.Items.Add(t.Nombre);
            }
            if(lstTecBajas.Items.Count == 0)
            {
                MessageBox.Show("No existen tecnicaturas anteriores","Tecnicaturas anteriores",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lstTecBajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTecBajas.SelectedIndex > -1)
            {
                Limpiar();
                CargarDatos(lstTecBajas.SelectedIndex);
                Habilitar(true);
            }
        }
        private void Habilitar(bool x)
        {
            btnAlta.Enabled = x;
            btnCancelar.Enabled = x;
        }

        private void CargarDatos(int index)
        {
            foreach (Tecnicatura c in lTecnicatura)
            {
                txtNombre.Text = lTecnicatura[index].Nombre;
                txtTitulo.Text = lTecnicatura[index].Titulo;

            }
            foreach (DetalleTecnicatura dc in lTecnicatura[index].Detalles)
            {
                int anio = dc.AñoCursado;
                int cuatr = dc.Cuatrimestre;
                string asig = dc.Materia.Nombre;
                int id = dc.Materia.Id;
                dgvMaterias.Rows.Add(new object[] { id, asig, cuatr, anio });
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            Limpiar();
            lstTecBajas.SelectedIndex = -1;
        }
        private void Limpiar()
        {
            dgvMaterias.Rows.Clear();
            txtNombre.Text = "";
            txtTitulo.Text = "";
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea dar de alta la tecnicatura "+
                lTecnicatura[lstTecBajas.SelectedIndex].Nombre+" ?","Alta",MessageBoxButtons.YesNo,MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                try
                {
                    servicio.DarAlta(lTecnicatura[lstTecBajas.SelectedIndex]);
                    MessageBox.Show("Se dió de alta la tecnicatura " +
                lTecnicatura[lstTecBajas.SelectedIndex].Nombre, "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTecnicaturas();
                    lstTecBajas.SelectedIndex = -1;
                    Habilitar(false);
                }
                catch
                {
                    MessageBox.Show("Ocurrió un error al dar de alta la tecnicatura " +
                lTecnicatura[lstTecBajas.SelectedIndex].Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
