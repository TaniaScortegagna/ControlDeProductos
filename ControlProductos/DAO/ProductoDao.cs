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
            string pConsulta = string.Format("SP_ALTA_BAJA_MODIFICACION_PRODUCTOS");                
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
            string pConsulta = string.Format("SP_LISTAR_PRODUCTOS");
            DataTable resultado = cnn.EjecutarQuery(pConsulta);
            return resultado;
        }
        public int proxCod()
        {
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("SP_MOSTRAR_CODIGO_PRODUCTO");
            int resultado = Convert.ToInt32(cnn.TraerValor(pConsulta));
            return resultado + 1;
        }        
        public DataTable buscarProducto(string familia, string rubro, string  proveedor,string   filtro)
        {
          Conexion cnn = new Conexion();
          string pConsulta = string.Format("SP_PRODUCTOS_CONSULTAR_TODOS");
          cnn.AgregarParametro("@Proveedor", familia, SqlDbType.VarChar);
          cnn.AgregarParametro("@Rubro", rubro, SqlDbType.VarChar);
          cnn.AgregarParametro("@Familia", proveedor, SqlDbType.VarChar);
          cnn.AgregarParametro("@filtro", filtro, SqlDbType.VarChar);
          DataTable resultado = cnn.EjecutarQuery(pConsulta);
          return resultado;
        }
        public bool actualizarProducto(Producto pproducto)
        {
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("SP_ALTA_BAJA_MODIFICACION_PRODUCTOS");                
            cnn.AgregarParametro("@Codigo",pproducto.codigo.ToString(),SqlDbType.Int);
            cnn.AgregarParametro("@Nombre", pproducto.nombre, SqlDbType.NChar);
            cnn.AgregarParametro("@Descripcion", pproducto.descripcion, SqlDbType.NChar);
            cnn.AgregarParametro("@IdProveedor", pproducto.proveedor.ToString(), SqlDbType.Int);
            cnn.AgregarParametro("@IdRubro", pproducto.rubro.ToString(), SqlDbType.Int);
            cnn.AgregarParametro("@Marca",pproducto.marca,SqlDbType.NChar);
            cnn.AgregarParametro("@Precio",pproducto.precio.ToString(),SqlDbType.Decimal);
            cnn.AgregarParametro("@Consulta","2", SqlDbType.Int);
            int Resultado = cnn.EjecutarNonQuery(pConsulta);
            return Resultado>=1;

        }
 }
}
