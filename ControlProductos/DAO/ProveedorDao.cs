using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class ProveedorDao
    {
        public ProveedorDao() { }

        public List<Proveedor> obtenerProveedores()
        {
            List<Proveedor> listaProveedores = new List<Proveedor>();
            Conexion cnn = new Conexion();

            string pConsulta = string.Format("SP_LISTAR_PROVEEDORES");
            DataTable resultado = cnn.EjecutarQuery(pConsulta);

            foreach (DataRow proveedor in resultado.Rows)
            {
                Proveedor oProveedor = new Proveedor();
                oProveedor.Id = Convert.ToInt32(proveedor["IdProv"]);
                oProveedor.Nombre = proveedor["Nombre"].ToString();
                listaProveedores.Add(oProveedor);

            }

            listaProveedores.Insert(0, new Proveedor() { Id = 0, Nombre = "<Seleccione un Item>" });
            return listaProveedores;
        }
    }

}
