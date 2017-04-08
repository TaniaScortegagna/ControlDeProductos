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
            MenuPrincipal iniciar = new MenuPrincipal();
            iniciar.Show();
            this.Hide();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
