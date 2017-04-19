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
    class Datos: Conexion
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

        public List<Proveedor> obtenerProveedores()
        {
            List<Proveedor> proveedores = new List<Proveedor>();
            this.Conectar();
            this.comandosql = new SqlCommand(string.Format("SELECT IdProv,Nombre FROM Proveedores"), cnn);
            this.dr = comandosql.ExecuteReader();
            while (dr.Read())
                {
                    Proveedor pProveedor = new Proveedor();
                    pProveedor.Id = dr.GetInt32(0);
                    pProveedor.Nombre = dr.GetString(1);

                    proveedores.Add(pProveedor);
                 }
            

            this.Desconectar();
           
            return proveedores;
        }
        public List<Familia> obtenerFamilia()
        {
           
            List<Familia> familias = new List<Familia>();
            this.Conectar();
            comandosql = new SqlCommand(string.Format("SELECT IdFamilia,Nombre FROM Familias"), cnn);
            this.dr2 = comandosql.ExecuteReader();

            while (dr2.Read())
            {
                Familia pFamilia = new Familia();
                pFamilia.IdFamilia = dr2.GetInt32(0);
                pFamilia.Nombre = dr2.GetString(1);



                familias.Add(pFamilia);

            }
            this.Desconectar();
            return familias;
        }

        public List<Rubro> obtenerRubro(int pIdFlia)
        {
            List<Rubro> rubros = new List<Rubro>();
            this.Conectar();
            this.comandosql = new SqlCommand(string.Format("SELECT IdRubro , Nombre FROM Rubros WHERE IdFlia = '{0}'", pIdFlia), cnn);
            this.dr3 = comandosql.ExecuteReader();
            while (dr3.Read())
            {
                Rubro pRubro = new Rubro();
                pRubro.IdRubro = dr3.GetInt32(0);
                pRubro.Nombre = dr3.GetString(1);

                rubros.Add(pRubro);

            }
            return rubros;
        }

    
        public bool Agregar(Productos pproducto)
            {
               bool resultado = false;
               int consulta = 0;
               int con = 1;
               
//               this.sql = string.Empty;
  //             this.sql = string.Format(@"INSERT INTO Productos (nombre,descripcion,idProveedor,idRubro,marca,precio)
    //                                            VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
      //                                          pproducto.nombre, pproducto.descripcion,
        //                                        pproducto.proveedor, pproducto.rubro, pproducto.marca, pproducto.precio);
          //     this.comandosql = new SqlCommand(this.sql,this.cnn);
            //   this.Conectar();
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