using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class ProductoDao
    {
       
        public ProductoDao() { }


        public bool altaProducto(Producto pproducto)
        {
            bool Resultado = false;
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("abmProductos");                
            cnn.AgregarParametro("@Codigo",pproducto.codigo.ToString(),SqlDbType.Int);
            cnn.AgregarParametro("@Nombre", pproducto.nombre, SqlDbType.NChar);
            cnn.AgregarParametro("@Descripcion", pproducto.descripcion, SqlDbType.NChar);
            cnn.AgregarParametro("@IdProveedor", pproducto.proveedor.ToString(), SqlDbType.Int);
            cnn.AgregarParametro("@IdRubro", pproducto.rubro.ToString(), SqlDbType.Int);
            cnn.AgregarParametro("@Marca",pproducto.marca,SqlDbType.NChar);
            cnn.AgregarParametro("@Precio",pproducto.precio.ToString(),SqlDbType.Decimal);
            cnn.AgregarParametro("@Consulta","1", SqlDbType.Int);
            Resultado = cnn.EjecutarNonQuery(pConsulta, CommandType.StoredProcedure);
            return Resultado;

        }
        public DataTable consultarProductos()
        {
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("SELECT p.Codigo,p.Descripcion,p.Marca,p.Nombre,p.Precio,pr.Nombre Proveedor,r.Nombre Rubro FROM Productos p JOIN Proveedores pr ON p.IdProveedor=pr.IdProv JOIN Rubros r ON p.IdRubro=r.IdRubro");
            DataTable resultado = cnn.EjecutarQuery(pConsulta, CommandType.Text);
            return resultado;
        }
        public int proxCod()
        {
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("consultaIdProducto");
            int resultado = Convert.ToInt32(cnn.TraerValor(pConsulta));
            return resultado + 1;
        }
    }
}
