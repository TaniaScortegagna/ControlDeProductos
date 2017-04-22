using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;



namespace ControlProductos
{
    class Datos: Conexion //Hereda la conexion de la BD de la clase Conexion
    {
      
        //Ver productos en el grid
        public DataTable cargarGrilla()
           {   
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Productos"), cnn);
                SqlDataAdapter da = new SqlDataAdapter (consulta) ;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.Desconectar();
                return dt;
            }

        //Funcion para traer todos los proveedores a una lista
        public List<Proveedor> obtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            this.Conectar();
            this.comandosql = new SqlCommand(string.Format("SELECT IdProv,Nombre FROM Proveedores"), cnn);
            SqlDataReader drProveedores = null;
            drProveedores = comandosql.ExecuteReader();
            while (drProveedores.Read())
                {
                    Proveedor pProveedor = new Proveedor();
                    pProveedor.Id = drProveedores.GetInt32(0);
                    pProveedor.Nombre = drProveedores.GetString(1);

                    proveedores.Add(pProveedor);
                 }
            this.Desconectar();           
            return proveedores;
        }

        //Funcion para traer todos los Famillia a una lista
        public List<Familia> obtenerFamilia()
        {
           
            List<Familia> familias = new List<Familia>();
            this.Conectar();
            comandosql = new SqlCommand(string.Format("SELECT IdFamilia,Nombre FROM Familias"), cnn);
            SqlDataReader drFamilia = null;
            drFamilia = comandosql.ExecuteReader();
            while (drFamilia.Read())
            {
                Familia pFamilia = new Familia();
                pFamilia.IdFamilia = drFamilia.GetInt32(0);
                pFamilia.Nombre = drFamilia.GetString(1);
                familias.Add(pFamilia);

            }
            this.Desconectar();
            return familias;
        }

        //Funcion para traer todos los Rubro a una lista
        public List<Rubro> obtenerRubro(int pIdFlia)
        {
            List<Rubro> rubros = new List<Rubro>();
            this.Conectar();
            this.comandosql = new SqlCommand(string.Format("SELECT IdRubro , Nombre FROM Rubros WHERE IdFlia = '{0}'", pIdFlia), cnn);
            SqlDataReader drRubro = null;
            drRubro = comandosql.ExecuteReader();
            while (drRubro.Read())
            {
                Rubro pRubro = new Rubro();
                pRubro.IdRubro = drRubro.GetInt32(0);
                pRubro.Nombre = drRubro.GetString(1);

                rubros.Add(pRubro);
            }
            this.Desconectar();
            return rubros;
        }
        //Realiza el insert en la tabla llamando el Stored procedure
        public bool Agregar(Productos pproducto)
            {
               bool resultado = false;
               int consulta = 0;
               int con = 1;
               this.comandosql = cnn.CreateCommand();
               comandosql.CommandText = "EXECUTE abmProductos  @Codigo,@Nombre,@Descripcion,@IdProveedor,@IdRubro,@Marca,@Precio, @Consulta";
               comandosql.Parameters.Add("@Codigo", SqlDbType.Int).Value = pproducto.codigo;
               comandosql.Parameters.Add("@Nombre", SqlDbType.NChar, 50).Value = pproducto.nombre;
               comandosql.Parameters.Add("@Descripcion", SqlDbType.NChar, 50).Value = pproducto.descripcion;
               comandosql.Parameters.Add("@IdProveedor", SqlDbType.Int).Value = pproducto.proveedor;
               comandosql.Parameters.Add("@IdRubro", SqlDbType.Int).Value = pproducto.rubro;
               comandosql.Parameters.Add("@Marca", SqlDbType.NChar, 50).Value = pproducto.marca;
               comandosql.Parameters.Add("@Precio", SqlDbType.NChar, 50).Value = pproducto.precio;
               comandosql.Parameters.Add("@Consulta", SqlDbType.Int).Value = con;
               this.Conectar();            
               consulta = this.comandosql.ExecuteNonQuery();
                if (consulta >= 1 )
               {
                   resultado = true;
               }

               this.Desconectar();
               return resultado;          
            }
    }
}