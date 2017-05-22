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
    public partial class ProductoABM : Form
    {
        public ProductoABM()
        {
            InitializeComponent();
        }

        private void ProductoABM_Load(object sender, EventArgs e)
        {

            btnactualizar.Visible = false;
            CargarCombos();
            ultimoCodigo();
            
        }

        private void ultimoCodigo()
        {
            ProductoDao oProducto = new ProductoDao();
            txbcodigo.Text = oProducto.proxCod().ToString();
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
        private void limpiarTexBox()
        {
            foreach (Control limpiarTextBox in this.Controls)
            {
                if (limpiarTextBox is TextBox)
                {
                    TextBox text = limpiarTextBox as TextBox;
                    text.Clear();
                }
            }
        }
        private void ValidarCampos()
        {
            foreach (Control validarTextBox in this.Controls)
            {
                if (validarTextBox is TextBox)
                {
                    if (string.IsNullOrEmpty(txbnombre.Text))
                    {

                        MessageBox.Show("Debe completar la informacion");

                        return;

                    }
                }
            }

            
        }

        public void btnguardar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
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
                    DialogResult guardado = MessageBox.Show("DATOS GUARDADOS, ¿Desea cargar un nuevo producto?","CORRECTO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (guardado == DialogResult.Yes)
                    {
                        limpiarTexBox();
                    }
                    else
                    {
                        AdministrarProducto iniciar = new AdministrarProducto();
                        iniciar.Show();
                        this.Close();
                    }
                }
                else
                {
                     MessageBox.Show( "Datos Incorrectos", "Error");
                }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            AdministrarProducto AdminProd = new AdministrarProducto();
            AdminProd.Show();
        }
        
        public void llenarForm(Producto oProducto) 
        {
           txbnombre.Text = oProducto.nombre;
           txbdescripcion.Text = oProducto.descripcion;
           txbmarca.Text= oProducto.marca;
           cmbproveedores.SelectedValue = oProducto.proveedor;
           cmbrubros.SelectedValue = oProducto.rubro;
           txbprecio.Text = oProducto.precio.ToString();
           
        
        }

        public void btnactualizar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            Producto oProducto = new Producto();
            oProducto.nombre = txbnombre.Text;
            oProducto.descripcion = txbdescripcion.Text;
            oProducto.marca = txbmarca.Text;
            oProducto.proveedor = (int)cmbproveedores.SelectedValue;
            oProducto.rubro = (int)cmbrubros.SelectedValue;
            oProducto.precio = Convert.ToDecimal(txbprecio.Text);
            ProductoDao oProductoDao = new ProductoDao();
            
            if (oProductoDao.actualizarProducto(oProducto))
             {
                MessageBox.Show("DATOS ACTUALIZADOS", "CORRECTO");
                
             }
            else
              {
                 MessageBox.Show("ERROR AL ACTUALIZADOS", "CORRECTO");
              }
            
        }



    }
}
