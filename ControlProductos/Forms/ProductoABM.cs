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
<<<<<<< HEAD
            
            CargarCombos();
            llenarFormEditar();  
=======
<<<<<<< HEAD
            
            CargarCombos();

            llenarFormEditar();  
=======

            
            CargarCombos();

            llenarFormEditar();
           // ultimoCodigo();
            
>>>>>>> origin/master
>>>>>>> origin/master
        }

        private void llenarFormEditar()
        {
            
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
            txbcodigo.Text = objProductoParaEditar.Codigo.ToString();
            txbnombre.Text = objProductoParaEditar.Nombre;
            txbdescripcion.Text = objProductoParaEditar.Descripcion;
            txbmarca.Text = objProductoParaEditar.Marca;
            cmbproveedores.SelectedValue = objProductoParaEditar.Proveedor.Id;
            cmbrubros.SelectedValue = objProductoParaEditar.Rubro.Familia.Id;
            cmbrubros.SelectedValue = objProductoParaEditar.Rubro.Id;
            txbprecio.Text = objProductoParaEditar.Precio.ToString();
<<<<<<< HEAD
=======
=======
            txbcodigo.Text = objProductoParaEditar.codigo.ToString();
            txbnombre.Text = objProductoParaEditar.nombre;
            txbdescripcion.Text = objProductoParaEditar.descripcion;
            txbmarca.Text = objProductoParaEditar.marca;
            int unIndice = 0;
            int indice = 0;

            foreach (Proveedor unProveedor in cmbproveedores.Items)
            {
                if (unProveedor.Id.Equals(objProductoParaEditar.proveedor))
                {
                    unIndice = indice;
                }
                indice++;
            }
            cmbproveedores.SelectedIndex = unIndice;
            cmbrubros.SelectedValue = objProductoParaEditar.rubro;
            txbprecio.Text = objProductoParaEditar.precio.ToString();
>>>>>>> origin/master
>>>>>>> origin/master
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
<<<<<<< HEAD
            
=======
>>>>>>> origin/master
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
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
            oProducto.Nombre = txbnombre.Text;
            oProducto.Descripcion = txbdescripcion.Text;
            oProducto.Marca = txbmarca.Text;
            oProducto.Proveedor.Id = (int)cmbproveedores.SelectedValue;
            oProducto.Rubro.Familia.Id = (int)cmbfamilias.SelectedValue;
            oProducto.Rubro.Id = (int)cmbrubros.SelectedValue;
            oProducto.Precio = Convert.ToDecimal(txbprecio.Text);
<<<<<<< HEAD
=======
=======
            oProducto.nombre = txbnombre.Text;
            oProducto.descripcion = txbdescripcion.Text;
            oProducto.marca = txbmarca.Text;
            oProducto.proveedor = (int)cmbproveedores.SelectedValue;
            oProducto.rubro = (int)cmbrubros.SelectedValue;
            oProducto.precio = Convert.ToDecimal(txbprecio.Text);
>>>>>>> origin/master
>>>>>>> origin/master
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
<<<<<<< HEAD
=======
        
        //public void llenarForm(Producto oProducto) 
        //{
        //   btnguardar.Visible = false;
        //   txbcodigo.Text = oProducto.codigo.ToString();
        //   txbnombre.Text = oProducto.nombre;
        //   txbdescripcion.Text = oProducto.descripcion;
        //   txbmarca.Text= oProducto.marca;
        //   int unIndice = 0;
        //   int indice = 0;

        //   foreach (Proveedor unProveedor in cmbproveedores.Items)
        //   {
        //       if (unProveedor.Id .Equals(oProducto.proveedor))
        //       {
        //           unIndice = indice;
        //       }
        //       indice++;
        //   }
        //   cmbproveedores.SelectedIndex = unIndice;
        //   cmbrubros.SelectedValue = oProducto.rubro;
        //   txbprecio.Text = oProducto.precio.ToString();
           
        
        //}
>>>>>>> origin/master

        public void btnactualizar_Click(object sender, EventArgs e)
        {
            ValidarCampos();
            Producto oProducto = new Producto();
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
            oProducto.Codigo = Convert.ToInt32(txbcodigo.Text);
            oProducto.Nombre = txbnombre.Text;
            oProducto.Descripcion = txbdescripcion.Text;
            oProducto.Marca = txbmarca.Text;
            oProducto.Proveedor.Id = (int)cmbproveedores.SelectedValue;
            oProducto.Rubro.Familia.Id = (int)cmbfamilias.SelectedValue;
            oProducto.Rubro.Id = (int)cmbrubros.SelectedValue;
            oProducto.Precio = Convert.ToDecimal(txbprecio.Text);
<<<<<<< HEAD
=======
=======
            oProducto.codigo = Convert.ToInt32(txbcodigo.Text);
            oProducto.nombre = txbnombre.Text;
            oProducto.descripcion = txbdescripcion.Text;
            oProducto.marca = txbmarca.Text;
            oProducto.proveedor = (int)cmbproveedores.SelectedValue;
            oProducto.rubro = (int)cmbrubros.SelectedValue;
            oProducto.precio = Convert.ToDecimal(txbprecio.Text);
>>>>>>> origin/master
>>>>>>> origin/master
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
