using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpProgramacion.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void pic_ojo_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                txtContraseña.UseSystemPasswordChar = false;
                pic_ojo.Image = TpProgramacion.Properties.Resources.ojo_abierto;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                pic_ojo.Image = TpProgramacion.Properties.Resources.ojo_cerrado;
            }

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if((txtUsuario.Text=="utn") && (txtContraseña.Text == "utn"))
            {
                MessageBox.Show("Usuario y Contraseña correctos! \n Ingresando al sistema... ",
                    "Ingresando");
                FrmPrincipal principal = new FrmPrincipal();
                principal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos! \n Ingrese nuevamente.", "Error");
                txtUsuario.Text = "";
                txtUsuario.Focus();
                txtContraseña.Text = "";
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
