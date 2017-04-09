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
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdministrarProducto iniciar = new AdministrarProducto();
            iniciar.Show();
            this.Close();
        }
    }
}
