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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnadminproductos_Click(object sender, EventArgs e)
        {
            AdministrarProducto AdminProd = new AdministrarProducto();
            AdminProd.Show();
            this.Close();
        }

    }
}
