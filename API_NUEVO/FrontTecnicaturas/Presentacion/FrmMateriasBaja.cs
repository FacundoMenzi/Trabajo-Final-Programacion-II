using DLL_API.Dominio;
using FrontTenicaturas.Servicios;
using Newtonsoft.Json;
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
    public partial class FrmMateriasBaja : Form
    {
        List<Materia> lMaterias;
        public FrmMateriasBaja()
        {
            InitializeComponent();
            CenterToParent();

            lMaterias = new List<Materia>();
        }
        private async void FrmMateriasBaja_Load(object sender, EventArgs e)
        {
            await CargarMaterias();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            Limpiar();
            lstMatBajas.SelectedIndex = -1;
        }

        
        private async Task CargarMaterias()
        {
            lstMatBajas.Items.Clear();
            lMaterias.Clear();

            string url = "http://localhost:5241/materias/verBajas";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Materia> lst = JsonConvert.DeserializeObject<List<Materia>>(data);
            lMaterias = lst;
            foreach (Materia materias in lMaterias)
            {
                lstMatBajas.Items.Add(materias.Nombre);
            }
            if (lstMatBajas.Items.Count == 0)
            {
                MessageBox.Show("No existen Materias anteriores", "Materias anteriores", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void Habilitar(bool x)
        {
            btnAlta.Enabled = x;
            btnCancelar.Enabled = x;
        }

        private void CargarDatos(int index)
        {
            foreach (Materia m in lMaterias)
            {
                txtNombre.Text = lMaterias[index].Nombre;
                txtProfesor.Text = lMaterias[index].Profesor.Nombre;
                if (lMaterias[index].IdTurno == 1)
                    rbtMañana.Checked = true;
                else if (lMaterias[index].IdTurno == 2)
                    rbtTarde.Checked = true;
                else
                    rbtNoche.Checked = true;
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtProfesor.Text = "";
            rbtMañana.Checked=false;
            rbtTarde.Checked=false;
            rbtNoche.Checked=false;
        }

        private async void btnAlta_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea dar de alta la Materia " +
               lMaterias[lstMatBajas.SelectedIndex].Nombre + " ?", "Alta", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == DialogResult.Yes)
            {
                try
                {
                    await DarAlta();
                    
                    MessageBox.Show("Se dió de alta la materia " +
                    lMaterias[lstMatBajas.SelectedIndex].Nombre, "Alta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await CargarMaterias();
                    lstMatBajas.SelectedIndex = -1;
                    Habilitar(false);
                    Limpiar();
                }
                catch
                {
                    MessageBox.Show("Ocurrió un error al dar de alta la materia " +
                    lMaterias[lstMatBajas.SelectedIndex].Nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task DarAlta()
        {
            string url = "http://localhost:5241/materias/darAlta";
            string materiaJson = JsonConvert.SerializeObject(lMaterias[lstMatBajas.SelectedIndex]);
            await ClienteSingleton.GetInstance().PutAsync(url, materiaJson);
        }

        private void lstMatBajas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMatBajas.SelectedIndex > -1)
            {
                Limpiar();
                CargarDatos(lstMatBajas.SelectedIndex);
                Habilitar(true);
            }
        }
    }
    
}
