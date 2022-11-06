
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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text=="utn") && (txtContraseña.Text == "utn"))
            {
                
                FrmPrincipal principal = new FrmPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos \n Ingrese nuevamente", "Inicio",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtUsuario.Focus();
                txtContraseña.Text = "";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pic_ojo_Click_1(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                pic_ojo.Image = FrontTecnicaturas.Properties.Resources.ojo_cerrado;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                pic_ojo.Image = FrontTecnicaturas.Properties.Resources.ojo_abierto;
            }

        }
    }
}
