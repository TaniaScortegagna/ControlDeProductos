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

            string pConsulta = string.Format("SELECT IdProv,Nombre FROM Proveedores");
            DataTable resultado = cnn.EjecutarQuery(pConsulta, CommandType.Text);

            for (int x = 0; x < resultado.Rows.Count; x++){

                Proveedor pProveedor = new Proveedor();
                pProveedor.Id = Convert.ToInt32(resultado.Rows[x]["IdProv"]);
                pProveedor.Nombre = resultado.Rows[x]["Nombre"].ToString();
                listaProveedores.Add(pProveedor);

            }

            return listaProveedores;
        }
    }

}
