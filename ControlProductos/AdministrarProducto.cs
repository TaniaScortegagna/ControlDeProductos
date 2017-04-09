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
    public partial class AdministrarProducto : Form
    {
        public AdministrarProducto()
        {
            
            InitializeComponent();
        }

        private void dgvproductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdministrarProducto_Load(object sender, EventArgs e)
        {
           
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            NuevoProducto iniciar = new NuevoProducto();
            iniciar.Show();
            this.Close();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal iniciar = new MenuPrincipal();
            iniciar.Show();
        }
    }
}
