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
<<<<<<< HEAD:ControlProductos/Forms/AdministrarProducto.cs

=======
        
        private void btnproductos_Click(object sender, EventArgs e)
        {
            //ProductoDao oProductos = new ProductoDao();
            //dgvproveedores.DataSource = oProductos.consultarProductos();

        }
>>>>>>> origin/master:ControlProductos/AdministrarProducto.cs

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
<<<<<<< HEAD:ControlProductos/Forms/AdministrarProducto.cs
           
=======
            ProductoDao oProductos = new ProductoDao();
            dgvproveedores.DataSource = oProductos.consultarProductos();
>>>>>>> origin/master:ControlProductos/AdministrarProducto.cs
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

<<<<<<< HEAD:ControlProductos/Forms/AdministrarProducto.cs
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ProductoDao oProductos = new ProductoDao();
            string familia = cmbfamilias.SelectedValue.ToString();
            string rubro = cmbrubros.SelectedValue.ToString();
            string proveedor = cmbproveedores.SelectedValue.ToString();
            string filtro = txbbuscar.Text;
            dgvproveedores.DataSource = oProductos.buscarProducto(familia, rubro,  proveedor,  filtro);
            dgvproveedores.Columns["IdProveedor"].Visible = false;
            dgvproveedores.Columns["IdRubro"].Visible = false;
            dgvproveedores.Columns["IdFlia"].Visible = false;        
        }
        
        private void btneditar_Click(object sender, EventArgs e)
        {
            Producto oProducto = enviarProdEditar(); 
            ProductoABM EditarProducto = new ProductoABM();
            EditarProducto.llenarForm(oProducto);
            EditarProducto.Show();         
            
        }

        private Producto enviarProdEditar()
        {
            Producto oProducto = new Producto();
            oProducto.codigo = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["Codigo"].Value.ToString());
            oProducto.nombre = this.dgvproveedores.CurrentRow.Cells["Nombre"].Value.ToString();
            oProducto.descripcion = this.dgvproveedores.CurrentRow.Cells["Descripcion"].Value.ToString();
            oProducto.proveedor = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["IdProveedor"].Value.ToString());
            oProducto.rubro = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["IdRubro"].Value.ToString());
            oProducto.marca = this.dgvproveedores.CurrentRow.Cells["Marca"].Value.ToString();
            oProducto.precio = Convert.ToDecimal(this.dgvproveedores.CurrentRow.Cells["Precio"].Value.ToString());

            return oProducto;
=======
        private void dgvproveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvproveedores.CurrentRow.Selected);
            btneditar.Show();

        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            ProductoABMEditar PABME = new ProductoABMEditar();
            _codigo = this.dgvproveedores.CurrentRow.Cells[0].Value.ToString();
            //public string _descripcion;
            //public string _marca;
            //public string _nombre;
            //public char _precio;
            //public string _proveedor;
            //public string _rubro;
            //_codigo = 0001; 
            //_nombre = "Pedro";
            //ProductoABMEditar oProducto = new ProductoABMEditar(_codigo);
            //oProducto.Show();
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
>>>>>>> origin/master:ControlProductos/AdministrarProducto.cs
        }
    }
}
