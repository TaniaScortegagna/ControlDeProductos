using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlProductos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            ValidarUsuario();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
                this.Close();
            
        }

        private void txbclave_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                ValidarUsuario();
            }
        }
        private void txbusuario_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void ValidarUsuario()
        {
            UsuarioDao UsuarioOb = new UsuarioDao();

            if (UsuarioOb.BuscarUsuario(this.txbusuario.Text, this.txbclave.Text) == true)
            {

                MenuPrincipal iniciar = new MenuPrincipal();
                iniciar.Show();
                this.Hide();

            }
            else
                MessageBox.Show("DATOS INCORRECTOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
