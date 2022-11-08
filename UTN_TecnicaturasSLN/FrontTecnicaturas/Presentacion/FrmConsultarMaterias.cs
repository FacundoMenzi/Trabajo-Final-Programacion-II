using DLL_API.Dominio;
using FrontTenicaturas.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;


namespace FrontTecnicaturas.Presentacion
{
    public partial class FrmConsultarMaterias : Form
    {
        List<Materia> lMaterias;

        public FrmConsultarMaterias()
        {
            InitializeComponent();
            lMaterias = new List<Materia>();
            
            CenterToScreen();
            CenterToParent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private async void FrmNuevaMateria_Load(object sender, EventArgs e)
        {
            await CargarProfesores();
            await CargarLista();
            CantidadMaterias();
            
            Habilitar(false);
            Editar(false);
        }

        private async Task CargarProfesores()
        {
            string url = "http://localhost:5241/profesores/ver";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Profesor> lst = JsonConvert.DeserializeObject<List<Profesor>>(data);

            cboProfesores.DataSource = lst;
            cboProfesores.DisplayMember = "Nombre";
            cboProfesores.ValueMember = "Id";
            cboProfesores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesores.SelectedIndex = -1;

        }

        private void Editar(bool x)
        {
            txtNombre.Enabled = x;
            rbtMañana.Enabled = x;
            cboProfesores.Enabled = x;
            rbtNoche.Enabled = x;
            rbtTarde.Enabled = x;
            btnAceptar.Enabled = x;

            btnBajaMat.Enabled = !x;
            btnModificar.Enabled = !x;
            btnSalir.Enabled = !x;
        }

        private void Habilitar(bool x)
        {
            btnBajaMat.Enabled = x;
            btnModificar.Enabled = x;
            btnCancelar.Enabled = x;
            btnSalir.Enabled = !x;
        }

        private void CantidadMaterias()
        {
            int cant = lMaterias.Count;
            if (cant > 0)
            {
                lblCantTecnicaturas.Text = "Cant. Materias: " + cant.ToString();
            }
            else
                MessageBox.Show("Error. No se puede obtener la cantidad de Materias", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async Task CargarLista()
        {
            lstMateria.Items.Clear();
            lMaterias.Clear();
            string url = "http://localhost:5241/materias/ver";
            var data = await ClienteSingleton.GetInstance().GetAsync(url);
            List<Materia> lst = JsonConvert.DeserializeObject<List<Materia>>(data);

            if (lst != null)
            {
                lMaterias = lst;
                foreach (Materia m in lMaterias)
                {
                    lstMateria.Items.Add(m.Nombre);
                }
            }
            else MessageBox.Show("No se pueden recuperar las materias", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Habilitar(false);
            Editar(false);
            Limpiar();
            lstMateria.SelectedIndex = -1;
        }
        private void Limpiar()
        {
            txtNombre.Text = "";

            cboProfesores.SelectedIndex = -1;
            rbtMañana.Checked = false;
            rbtTarde.Checked = false;
            rbtNoche.Checked = false;

        }

        private void lstMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            Limpiar();

            if (lstMateria.SelectedIndex > -1)
            {
                Habilitar(true);
                CargarDatos(lstMateria.SelectedIndex);
            }
        }

        private void CargarDatos(int index)
        {
            foreach (Materia m in lMaterias)
            {
                txtNombre.Text = lMaterias[index].Nombre;
                cboProfesores.SelectedIndex = (lMaterias[index].Profesor.Id)-1;
                if (lMaterias[index].IdTurno == 1)
                    rbtMañana.Checked = true;
                else if (lMaterias[index].IdTurno == 2)
                    rbtTarde.Checked = true;
                else
                    rbtNoche.Checked = true;
            }
        }

        private async void btnBorrarTec_Click(object sender, EventArgs e)
        {
            if (lstMateria.SelectedIndex > -1)
            {
                if (MessageBox.Show("¿Está seguro que desea dar de baja la tecnicatura " + lMaterias[lstMateria.SelectedIndex].Nombre + "?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        await DarBaja();
                        
                        Habilitar(false);
                        MessageBox.Show("La materia ha sido dada de baja",
                        "Borrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await CargarLista();
                        lstMateria.SelectedIndex = -1;
                        CantidadMaterias();
                        Limpiar();
                    }
                    catch
                    {
                        MessageBox.Show("Ha ocurrido un error al borrarla ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private async Task DarBaja()
        {
            string url = "http://localhost:5241/materias/darBaja";
            string materiaJson = JsonConvert.SerializeObject(lMaterias[lstMateria.SelectedIndex]);
            await ClienteSingleton.GetInstance().PutAsync(url, materiaJson);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstMateria.SelectedIndex > -1)
            {
                Editar(true);
            }
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarMateria())
            {
                foreach (Materia m in lMaterias)
                {
                    if (m.Id == lMaterias[lstMateria.SelectedIndex].Id)
                    {
                        try
                        {
                            m.Nombre = txtNombre.Text;
                            m.Profesor = (Profesor)cboProfesores.SelectedItem;
                            if (rbtMañana.Checked) m.IdTurno = 1;
                            else if (rbtTarde.Checked) m.IdTurno = 2;
                            else m.IdTurno = 3;

                            string url = "http://localhost:5241/materias/modificar";
                            string presupuestoJson = JsonConvert.SerializeObject(m);
                            var data = await ClienteSingleton.GetInstance().PutAsync(url, presupuestoJson);

                            Editar(false);
                            Habilitar(false);
                            MessageBox.Show("Materia actualizada", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            await CargarLista();
                            Limpiar();
                            break;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Ha ocurrido un error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private bool ValidarMateria()
        {
            bool valido = true;
            if (txtNombre.Text == "")
            {
                valido = false;
                MessageBox.Show("Debe ingresar un nombre de Materia", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
            }
            else try { txtNombre.Text.ToString(); }
                catch (Exception)
                {
                    valido = false;
                    MessageBox.Show("Debe ingresar un nombre de Materia válido", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                }
            if(cboProfesores.SelectedIndex == -1)
            {
                valido = false;
                MessageBox.Show("Debe elegir un profesor", "Control", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboProfesores.Focus();
            }
            if (rbtMañana.Checked == false & rbtTarde.Checked == false && rbtNoche.Checked == false)
            {
                MessageBox.Show("Debe ingresar un turno", "Control",
                      MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                valido = false;
            }


            return valido;
        }

        private async void btnMatBajas_Click(object sender, EventArgs e)
        {
            FrmMateriasBaja frmbajas = new FrmMateriasBaja();
            frmbajas.ShowDialog();
            frmbajas.Dispose();
            await CargarLista();
            CantidadMaterias();
        }

        private void lblTecnicaturas_Click(object sender, EventArgs e)
        {

        }
    }
}
