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
        public string _codigo;
        public string _descripcion;
        public string _marca;
        public string _nombre;
        public string _precio;
        public string _proveedor;
        public string _rubro;
        public AdministrarProducto()
        {
            InitializeComponent();
        }
        
        private void btnproductos_Click(object sender, EventArgs e)
        {
            //ProductoDao oProductos = new ProductoDao();
            //dgvproveedores.DataSource = oProductos.consultarProductos();

        }

        private void cmbfamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbrubros.DataSource = null;
            cmbrubros.Items.Clear();
            RubroDao oRubro = new RubroDao();
            cmbrubros.DataSource = oRubro.obtenerRubro(((Familia)cmbfamilias.SelectedItem).Id);
            cmbrubros.DisplayMember = "Nombre";
            cmbrubros.ValueMember = "Id";
        }

        private void AdministrarProducto_Load(object sender, EventArgs e)
        {
            ProductoDao oProductos = new ProductoDao();
            dgvproveedores.DataSource = oProductos.consultarProductos();
            CargarCombos();
            btneditar.Hide();
        }

        private void CargarCombos()
        {
            ProveedorDao oProveedor = new ProveedorDao();
            cmbproveedores.DataSource = oProveedor.obtenerProveedores();
            cmbproveedores.DisplayMember = "Nombre";
            cmbproveedores.ValueMember = "Id";

            FamiliaDao oFamilia = new FamiliaDao();
            cmbfamilias.DataSource = oFamilia.obtenerFamilia();
            cmbfamilias.DisplayMember = "Nombre";
            cmbfamilias.ValueMember = "Id";

            cmbfamilias.SelectedIndex = 0;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ProductoABM oProducto = new ProductoABM();
            oProducto.Show();
            this.Hide();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenuPrin = new MenuPrincipal();
            MenuPrin.Show();
            this.Close();
        }

        private void dgvproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvproveedores.CurrentRow.Selected);
            btneditar.Show();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            ProductoABMEditar PABME = new ProductoABMEditar();
            _codigo = this.dgvproveedores.CurrentRow.Cells[0].Value.ToString();
            _descripcion = this.dgvproveedores.CurrentRow.Cells[1].Value.ToString();
            _marca = this.dgvproveedores.CurrentRow.Cells[2].Value.ToString();
            _nombre = this.dgvproveedores.CurrentRow.Cells[3].Value.ToString();
            _precio = this.dgvproveedores.CurrentRow.Cells[4].Value.ToString();
            _proveedor = this.dgvproveedores.CurrentRow.Cells[5].Value.ToString();
            _rubro = this.dgvproveedores.CurrentRow.Cells[6].Value.ToString();  
            ProductoABMEditar oProducto = new ProductoABMEditar(_codigo, _descripcion, _marca,  _nombre, _precio, _proveedor, _rubro);
            oProducto.Show();
            this.Hide(); 
        }

        private ProductoABMEditar ProductoABMEditar()
        {
            throw new NotImplementedException();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ProductoDao oBuscarProducto = new ProductoDao();
            dgvproveedores.DataSource = oBuscarProducto.buscarProducto(txbbuscar.Text);
        }
    }
}
