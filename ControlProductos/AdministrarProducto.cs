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
            btnnuevo.Visible = false;
            CargarCombos();
                     
        }

        private void CargarCombos()
        {

            Datos d = new Datos();
            cmbproveedores.DataSource = d.obtenerProveedores();
            cmbproveedores.DisplayMember = "Nombre";
            cmbproveedores.ValueMember = "Id";


            cmbfamilias.DataSource = d.obtenerFamilia();
            cmbfamilias.DisplayMember = "Nombre";
            cmbfamilias.ValueMember = "IdFamilia";
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
            this.Close();
        }
        
        private void btverprod_Click(object sender, EventArgs e)
        {
            btnnuevo.Visible = true;

            Datos datosOb = new Datos();
            gvproductos.DataSource = datosOb.cargarGrilla();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbfamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // cmbrubros.Items.Clear();
            Datos d = new Datos();
            //Familia familia = (Familia) cmbfamilias.SelectedValue;

            cmbrubros.DataSource = d.obtenerRubro((int)cmbfamilias.SelectedValue);
            cmbrubros.DisplayMember = "Nombre";
            cmbrubros.ValueMember = "IdRubro";
        }


  
    }

            
}
