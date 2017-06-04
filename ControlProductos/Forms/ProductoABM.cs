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
            if (objProductoParaEditar == null)
            {
                CargarCombos();
                btnactualizar.Visible = false;
                chkActivo.Visible = false;
            }
            else
            {
                CargarCombos();
                llenarFormEditar();
                btnguardar.Visible = false;
            }
        }
        private void llenarFormEditar()
        {
            txbcodigo.Text = objProductoParaEditar.Codigo.ToString().Trim(); 
            txbnombre.Text = objProductoParaEditar.Nombre.Trim();
            txbdescripcion.Text = objProductoParaEditar.Descripcion.Trim();
            txbmarca.Text = objProductoParaEditar.Marca.Trim();
            cmbproveedores.SelectedValue = objProductoParaEditar.Proveedor.Id;
            cmbfamilias.SelectedValue = objProductoParaEditar.Rubro.Familia.Id;
            cmbrubros.SelectedValue = objProductoParaEditar.Rubro.Id;
            txbprecio.Text = objProductoParaEditar.Precio.ToString().Trim();
            if (objProductoParaEditar.Activo)
            {
                chkActivo.Checked = true;
            }

        }
        public Producto objProductoParaEditar; 
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
                cmbfamilias.SelectedValue = 0;
                cmbproveedores.SelectedValue = 0;
                cmbrubros.SelectedValue = 0;
                if (limpiarTextBox is TextBox)
                {
                    TextBox text = limpiarTextBox as TextBox;
                    text.Clear();
                }
            }
        }
        public void btnguardar_Click(object sender, EventArgs e)
        {
            Producto oProducto = new Producto();
            if (string.IsNullOrEmpty(txbnombre.Text) && string.IsNullOrEmpty(txbdescripcion.Text) && string.IsNullOrEmpty(txbmarca.Text) && string.IsNullOrEmpty(txbprecio.Text) && ((int)cmbproveedores.SelectedValue == 0) && ((int)cmbfamilias.SelectedValue) == 0 && ((int)cmbrubros.SelectedValue == 0))
            {
                MessageBox.Show("DEBE COMPLETAR INFORMACION", "ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                oProducto.Nombre = txbnombre.Text.Trim();
                oProducto.Descripcion = txbdescripcion.Text.Trim();
                oProducto.Marca = txbmarca.Text.Trim();
                oProducto.Proveedor.Id = (int)cmbproveedores.SelectedValue;
                oProducto.Rubro.Familia.Id = (int)cmbfamilias.SelectedValue;
                oProducto.Rubro.Id = (int)cmbrubros.SelectedValue;
                oProducto.Precio = Convert.ToDouble(txbprecio.Text);
                ProductoDao oProductoDao = new ProductoDao();
                if (oProductoDao.altaProducto(oProducto))
                {
                    DialogResult guardado = MessageBox.Show("DATOS GUARDADOS, ¿Desea cargar un nuevo producto?", "CORRECTO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (guardado == DialogResult.Yes)
                    {
                        limpiarTexBox();
                    }
                    else
                    {
                        this.Close();
                    }
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
        }
        public void btnactualizar_Click(object sender, EventArgs e)
        {
            if (chkActivo.Checked)
            {
                Producto oProducto = new Producto();
                oProducto.Activo = chkActivo.Checked;
                oProducto.Codigo = Convert.ToInt32(txbcodigo.Text);
                oProducto.Nombre = txbnombre.Text;
                oProducto.Descripcion = txbdescripcion.Text;
                oProducto.Marca = txbmarca.Text;
                oProducto.Proveedor.Id = (int)cmbproveedores.SelectedValue;
                oProducto.Rubro.Familia.Id = (int)cmbfamilias.SelectedValue;
                oProducto.Rubro.Id = (int)cmbrubros.SelectedValue;
                oProducto.Precio = Convert.ToDouble(txbprecio.Text);
                ProductoDao oProductoDao = new ProductoDao();

                if (oProductoDao.actualizarProducto(oProducto))
                {
                    MessageBox.Show("DATOS ACTUALIZADOS", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("ERROR AL ACTUALIZAR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERROR AL ACTUALIZAR", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void txbnombre_Validated(object sender, EventArgs e)
        {
            if (txbnombre.Text.Trim() == "")
            {
                epError.SetError(txbnombre, "Introduzca Nombre");
                txbnombre.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
        private void txbdescripcion_Validated(object sender, EventArgs e)
        {
            if (txbdescripcion.Text.Trim() == "")
            {
                epError.SetError(txbdescripcion, "Intruduce Descripcion");
                txbdescripcion.Focus();
            }
            else
            {
                epError.Clear();
            }

        }
        private void txbmarca_Validated(object sender, EventArgs e)
        {
            if (txbmarca.Text.Trim() == "")
            {
                epError.SetError(txbmarca, "Intruduce Marca");
                txbmarca.Focus();
            }
            else
            {
                epError.Clear();
            }

        }
        private void txbprecio_Validated(object sender, EventArgs e)
        {
            if (txbprecio.Text.Trim() == "")
            {
                epError.SetError(txbprecio, "Intruduce Marca");
                txbprecio.Focus();
            }
            else
            {
                epError.Clear();
            }

        }
        private void cmbproveedores_Validated(object sender, EventArgs e)
        {
            if ((int)cmbproveedores.SelectedValue == 0)
            {
                epError.SetError(cmbproveedores, "Seleccione proveedor");
                cmbproveedores.Focus();
            }
            else
            {
                epError.Clear();
            }

        }
        private void cmbfamilias_Validated(object sender, EventArgs e)
        {
            if ((int)cmbfamilias.SelectedValue == 0)
            {
                epError.SetError(cmbfamilias, "Seleccione familia");
                cmbfamilias.Focus();
            }
            else
            {
                epError.Clear();
            }

        }
        private void ProductoABM_Activated(object sender, EventArgs e)
        {
            txbnombre.Focus();
        }

    }
}
