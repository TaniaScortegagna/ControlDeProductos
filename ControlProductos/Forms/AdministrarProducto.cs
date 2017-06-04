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
        private void AdministrarProducto_Load(object sender, EventArgs e)
        {
           
            btneditar.Visible = false;
            btneliminar.Visible = false;            
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

            //cmbrubros.DataSource = null;
            //cmbrubros.Items.Clear();
            RubroDao oRubro = new RubroDao();
            cmbrubros.DataSource = oRubro.obtenerRubro();
            cmbrubros.DisplayMember = "Nombre";
            cmbrubros.ValueMember = "Id";
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            ProductoABM oProductoABM = new ProductoABM();
            oProductoABM.ShowDialog();
        }
        private void btnvolver_Click(object sender, EventArgs e)
        {
            MenuPrincipal MenuPrin = new MenuPrincipal();
            MenuPrin.Show();
            this.Close();
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            btneditar.Visible = false;
            btneliminar.Visible = false;
            consultaBuscarProducto();
        }
        private void consultaBuscarProducto()
        {
            string activo = "1";
            if (chkBaja.Checked)
            {
                activo = "0";
            }
            if (chkTodos.Checked)
            {
                activo = null;
            }

            ProductoDao oProductos = new ProductoDao();
            dgvproveedores.DataSource = oProductos.buscarProducto(cmbfamilias.SelectedValue.ToString(), cmbrubros.SelectedValue.ToString(), cmbproveedores.SelectedValue.ToString(), txbbuscar.Text, activo);
            dgvproveedores.Columns["IdProveedor"].Visible = false;
            dgvproveedores.Columns["IdRubro"].Visible = false;
            dgvproveedores.Columns["IdFamilia"].Visible = false;
        }        
        private void btneditar_Click(object sender, EventArgs e)
        {
            Producto oProducto = enviarProdEditar(); 
            ProductoABM EditarProducto = new ProductoABM();
            EditarProducto.objProductoParaEditar = oProducto;
            EditarProducto.ShowDialog();
            consultaBuscarProducto();
            
        }
        private Producto enviarProdEditar()
        {
            Producto oProducto = new Producto();
            oProducto.Codigo = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["Codigo"].Value.ToString());
            oProducto.Nombre = this.dgvproveedores.CurrentRow.Cells["Nombre"].Value.ToString();
            oProducto.Descripcion = this.dgvproveedores.CurrentRow.Cells["Descripcion"].Value.ToString();
            oProducto.Proveedor.Id = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["IdProveedor"].Value.ToString());
            oProducto.Rubro.Familia.Id = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["IdFamilia"].Value.ToString());
            oProducto.Rubro.Id = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["IdRubro"].Value.ToString());
            oProducto.Marca = this.dgvproveedores.CurrentRow.Cells["Marca"].Value.ToString();
            oProducto.Precio = Convert.ToDouble(this.dgvproveedores.CurrentRow.Cells["Precio"].Value.ToString());
            oProducto.Activo = Convert.ToBoolean(this.dgvproveedores.CurrentRow.Cells["Activo"].Value.ToString());
            return oProducto;
        }
        private void bnteliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(this.dgvproveedores.CurrentRow.Cells["Activo"].Value.ToString()))
            {
                DialogResult darBajaOK = MessageBox.Show("El producto con Codigo:  " + this.dgvproveedores.CurrentRow.Cells["Codigo"].Value.ToString() + "  sera dado de baja,Esta seguro?", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (darBajaOK == DialogResult.OK)
                {
                    Producto oProducto = new Producto();
                    oProducto.Codigo = Convert.ToInt32(this.dgvproveedores.CurrentRow.Cells["Codigo"].Value.ToString());
                    ProductoDao oProductoDAO = new ProductoDao();
                    if (oProductoDAO.bajaProducto(oProducto))
                    {
                        MessageBox.Show("PRODUCTO DADO DE BAJA", "CORRECTO");
                        consultaBuscarProducto();

                    }
                    else
                    {
                        MessageBox.Show("ERROR AL DAR LA BAJA", "CORRECTO");
                    }
                }
            }
            else
            {
                MessageBox.Show("PRODUCTO YA DADO DE BAJA", "ERROR");
            }

        }
        private void dgvproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btneditar.Visible = true;
            btneliminar.Visible = true;
        }
    }
}
