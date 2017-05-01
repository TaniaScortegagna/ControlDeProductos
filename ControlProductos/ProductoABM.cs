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
            RubroDao pRubro = new RubroDao();
            cmbrubros.DataSource = pRubro.obtenerRubro(((Familia)cmbfamilias.SelectedItem).Id);
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Producto pProducto = new Producto();
            pProducto.nombre = txbnombre.Text;
            pProducto.descripcion = txbdescripcion.Text;
            pProducto.marca = txbmarca.Text;
            pProducto.proveedor = (int)cmbproveedores.SelectedValue;
            pProducto.rubro = (int)cmbrubros.SelectedValue;
            pProducto.precio = Convert.ToDecimal(txbprecio.Text);
            ProductoDao pProductoDao = new ProductoDao();
            if (pProductoDao.altaProducto(pProducto))
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
    }
}
