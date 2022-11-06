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
    public partial class FrmNuevaMateria : Form
    {
        Materia materia;

        public FrmNuevaMateria()
        {
            InitializeComponent();
            materia = new Materia();

        }

        private async void FrmNuevaMateria_Load(object sender, EventArgs e)
        {
            Limpiar();
            await CargarCombo();
            await ProximaMateria();
        }
       

        private async Task ProximaMateria()
        {
            string url = "http://localhost:5241/materias/proxima";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            int prox = JsonConvert.DeserializeObject<int>(data);

            lblMatNro.Text = "Materia N°: " + prox.ToString();
        }

        private async Task CargarCombo()
        {
            string url = "http://localhost:5241/profesores/ver";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Profesor> lst = JsonConvert.DeserializeObject<List<Profesor>>(data);
            
            cboProfesor.DataSource = lst;
            cboProfesor.DisplayMember = "Nombre";
            cboProfesor.ValueMember = "Id";
            cboProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesor.SelectedIndex = -1;
        }

        private bool ValidarMateria()
        {
            bool result = true;
            if (txtNombre.Text == "")
            {
                result = false;
                txtNombre.Focus();
                MessageBox.Show("Debe escribir un nombre de materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cboProfesor.SelectedIndex == -1)
            {
                result = false;
                cboProfesor.Focus();
                MessageBox.Show("Debe elegir un profesor", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (rbtMañana.Checked == false & rbtTarde.Checked == false & rbtNoche.Checked == false)
            {
                result = false;
                MessageBox.Show("Debe seleccionar un turno para la materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return result;
        }


        public void Limpiar()
        {
            txtNombre.Text = "";

            rbtMañana.Checked = false;
            rbtTarde.Checked = false;
            rbtNoche.Checked = false;
            cboProfesor.SelectedIndex = -1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void btnAniadir_Click_1(object sender, EventArgs e)
        {
            if (ValidarMateria())
            {
                await NuevaMateria();
            }
        }

        private async Task NuevaMateria()
        {
            try
            {
                materia.Nombre = txtNombre.Text;
                materia.Profesor = (Profesor)cboProfesor.SelectedItem;

                if (rbtMañana.Checked) materia.IdTurno = 1;
                else if (rbtTarde.Checked) materia.IdTurno = 2;
                else materia.IdTurno = 3;
                materia.Estado = 1;

                string url = "http://localhost:5241/materias/nueva";
                string materiaJson = JsonConvert.SerializeObject(materia);
                var data = await ClienteSingleton.GetInstance().PostAsync(url, materiaJson);
                
                MessageBox.Show("Materia añadida con éxito", "Nueva materia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
                await ProximaMateria();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
