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
    public partial class ProductoABMEditar : Form
    {
        AdministrarProducto frmAdminPro = new AdministrarProducto();
        public ProductoABMEditar(int _codigo, string _nombre)
        {
            InitializeComponent();
        //    this.txbcodigo = _codigo;
        //    this.txbnombre = _nombre;
        }

        public ProductoABMEditar()
        {
            // TODO: Complete member initialization
        }
        private void ProductoABMEditar_Load(object sender, EventArgs e)
        {
            //txbcodigo = Convert.ToInt16(_codigo);
            //txbnombre = Convert.ToString(_nombre);
            //txbcodigo.Text = AdministrarProducto.;
            //txbnombre.Text = "Matias";
            txbdescripcion.Text = "Genial";
            txbmarca.Text = "Whirpool";
            txbprecio.Text = "12,50";
            CargarCombos();
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

        private void cmbfamilias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbrubros.DataSource = null;
            cmbrubros.Items.Clear();           
            RubroDao oRubro = new RubroDao();
            cmbrubros.DataSource = oRubro.obtenerRubro(((Familia)cmbfamilias.SelectedItem).Id);
            cmbrubros.DisplayMember = "Nombre";
            cmbrubros.ValueMember = "Id";

        }
        private void ValidarCampos()
        { 
            
        }
        
        private void btnguardar_Click(object sender, EventArgs e)
        {
            Producto oProducto = new Producto();
            oProducto.nombre = txbnombre.Text;
            oProducto.descripcion = txbdescripcion.Text;
            oProducto.marca = txbmarca.Text;
            oProducto.proveedor = (int)cmbproveedores.SelectedValue;
            oProducto.rubro = (int)cmbrubros.SelectedValue;
            oProducto.precio = Convert.ToDecimal(txbprecio.Text);
            ProductoDao oProductoDao = new ProductoDao();
            if (oProductoDao.altaProducto(oProducto))
              {
                    DialogResult guardado = MessageBox.Show("DATOS GUARDADOS CORRECTAMENTE","CORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (guardado == DialogResult.OK)
                    {
                        this.Close();
                        AdministrarProducto AdminProd = new AdministrarProducto();
                        AdminProd.Show();
                    }
                    else
                    {
                        MessageBox.Show("Datos Incorrectos", "Error");
                    }
                }
               
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrarProducto AdminProd = new AdministrarProducto();
            AdminProd.Show();
        }
    }
}
