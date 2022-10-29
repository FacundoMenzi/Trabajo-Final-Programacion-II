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
using TpProgramacion.Servicios.Implementaciones;
using TpProgramacion.Servicios.Interfaces;

namespace TpProgramacion.Presentacion
{
    public partial class FrmNuevaTecnicatura : Form
    {
        Tecnicatura tecnicatura;
        IServicio servicio;
        public FrmNuevaTecnicatura()
        {
            InitializeComponent();
            tecnicatura = new Tecnicatura();
            servicio=new Factory().CrearServicio();
        }

        private void FrmTecnicatura_Load(object sender, EventArgs e)
        {
            Limpiar();
            CargarCombo();
            ProximaTecnicatura();
            TotalMat();
        }

        public void TotalMat()
        {
            lblTotalMaterias.Text = "Total de Materias: " + dgvMaterias.Rows.Count;
        }
        private void ProximaTecnicatura()
        {
            lblTecNro.Text = "Tecnicatura N°: " + servicio.ObtenerProximaTecnicatura().ToString();
        }

        private void CargarCombo()
        {
            cboMaterias.DataSource = servicio.ObtenerMaterias();
            cboMaterias.DisplayMember = "Nombre";
            cboMaterias.ValueMember = "Id";
            cboMaterias.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMaterias.SelectedIndex = -1;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMaterias.CurrentCell.ColumnIndex == 4)
            {
                tecnicatura.Eliminar(dgvMaterias.CurrentRow.Index);
                dgvMaterias.Rows.Remove(dgvMaterias.CurrentRow);
                TotalMat();
            }

        }
        private bool ValidarMateria()
        {
            bool result = true;
            if (cboMaterias.SelectedIndex == -1)
            {
                result = false;
                cboMaterias.Focus();
                MessageBox.Show("Debe elegir una materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nudAnioCursado.Value == 0)
            {
                result = false;
                nudAnioCursado.Focus();
                MessageBox.Show("Debe ingresar un año de cursado válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(rbtCuatr1.Checked==false & rbtCuatr2.Checked == false)
            {
                result = false;
                MessageBox.Show("Debe seleccionar un cuatrimestre para la materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            foreach (DataGridViewRow row in dgvMaterias.Rows)
            {
                if (row.Cells["ClmMateria"].Value.ToString() == cboMaterias.Text)
                {
                    result = false;
                    cboMaterias.Focus();
                    MessageBox.Show("La materia " + cboMaterias.Text + " ya se encuentra añadida", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }
            }
            return result;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarMateria())
            {
                Materias m = (Materias)cboMaterias.SelectedItem;
                int anio = (int)nudAnioCursado.Value;
                int cuatr;
                if (rbtCuatr1.Checked)
                {
                    cuatr = 1;
                }
                else cuatr = 2;

                dgvMaterias.Rows.Add(new object[] { m.Id, m.Nombre, cuatr,anio });
                DetalleTecnicatura d = new DetalleTecnicatura(m,cuatr, anio);
                tecnicatura.Agregar(d);
                TotalMat();
            }
        }

        private bool ValidarTecnicatura()
        {
            bool result = true;
            if (txtNombre.Text == "")
            {
                result = false;
                txtNombre.Focus();
                MessageBox.Show("La tecnicatura debe tener un nombre", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else try
                {
                    Int32.Parse(txtNombre.Text);
                    result = false;
                    txtNombre.Focus();
                    MessageBox.Show("El nombre de la tecnicatura no es válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch
                {

                }
            if (txtTitulo.Text == "")
            {
                result = false;
                txtTitulo.Focus();
                MessageBox.Show("Debe ingresar un título", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
            if (dgvMaterias.Rows.Count < 3)
            {
                result = false;
                cboMaterias.Focus();
                MessageBox.Show("La tecnicatura debe tener un minimo de 3 materias", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return result;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarTecnicatura())
            {
                tecnicatura.Nombre = txtNombre.Text;
                tecnicatura.Titulo = txtTitulo.Text;
               
                if (servicio.CrearTecnicatura(tecnicatura))
                {
                    MessageBox.Show("Tecnicatura cargada con éxito", "Nueva tecnicatura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();

                }
                else MessageBox.Show("Ocurrió un error al cargar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtTitulo.Text = "";
            rbtCuatr1.Checked = false;
            rbtCuatr2.Checked = false;
            cboMaterias.SelectedIndex = -1;
            dgvMaterias.Rows.Clear();
            nudAnioCursado.Value = 1;
            TotalMat();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            {
            if(MessageBox.Show("¿Está seguro que desea salir?\n\nLos cambios no se guardarán", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Dispose();
            }
            
        }
    }
}
