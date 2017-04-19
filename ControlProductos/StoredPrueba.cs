using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace ControlProductos
{
    class StoredPrecedureFamilia: Conexion
    {

        public StoredPrecedureFamilia()
                {  
             
                }

        public void Insertar()
                {         
                    this.Conectar();
                    this.comandosql = cnn.CreateCommand();
                    comandosql.CommandText = "EXECUTE InsertarFamilia @Nombre,@Descripcion";
                 //   comandosql.Parameters.Add("@IdFamilia",SqlDbType.Int).Value = "";
                    comandosql.Parameters.Add("@Nombre",SqlDbType.NChar,50).Value= "Otros";
                    comandosql.Parameters.Add("@Descripcion",SqlDbType.NChar,50).Value= "Sin categoria";
                    comandosql.ExecuteNonQuery(); 
                }
                    
    }
}
