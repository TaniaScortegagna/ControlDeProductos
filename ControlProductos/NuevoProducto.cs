﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ControlProductos
{
    public partial class NuevoProducto : Form
    {
        public NuevoProducto()
        {
            InitializeComponent();
        }

        private void NuevoProducto_Load(object sender, EventArgs e)
        {
            btneditar.Visible = false;
            btneliminar.Visible = false;
            CargarCombos();
            AgregarEventos();

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


        private void AgregarEventos()
        {
            this.cmbfamilias.SelectedIndexChanged += new System.EventHandler(this.cmbfamilias_SelectedIndexChanged);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            AdministrarProducto iniciar = new AdministrarProducto();
            iniciar.Show();
            this.Close();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Productos producto = new Productos();
            producto.nombre = txbnombre.Text;
            producto.descripcion = txbdescripcion.Text;
            producto.proveedor = ((int)cmbproveedores.SelectedValue);
            producto.rubro = ((int)cmbrubros.SelectedValue);
            producto.marca = txbmarca.Text;
            producto.precio = txbprecio.Text;
            Datos d = new Datos();
            bool a = d.Agregar(producto);
            if (a == true)
            {
                MessageBox.Show("DATOS GUARDADOS", "CORRECTO", MessageBoxButtons.OK);

            }
            else
                MessageBox.Show("Datos Incorrectos", "Error");
        }




        private void cmbfamilias_SelectedIndexChanged(object sender, EventArgs e)
        {

            Datos d = new Datos();
            cmbrubros.DataSource = d.obtenerRubro((int)cmbfamilias.SelectedValue);
            cmbrubros.DisplayMember = "Nombre";
            cmbrubros.ValueMember = "IdRubro";


        }   

    }
}
