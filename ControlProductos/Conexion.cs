using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ControlProductos
{
    class Conexion
    {
        public string conexiones;
        protected string sql;
        protected int resultado;
        protected SqlConnection cnn;
        protected SqlCommand comandosql;
        protected String mensaje;
        public SqlDataAdapter adaptersql;

        public Conexion()
        {
            //Realizo el string con la conexion en mi BD , Source tiene que ser el nombre de mmi servicio
            //y Catalog el nombre de mi BD
            this.conexiones = (@"Data source=(local);Initial Catalog = ControlDeProductos; integrated security = True");
            this.cnn = new SqlConnection(this.conexiones);

        }
            // Cada vez que llamo esta funcion realizo la conexion con mi BD
            public void Conectar()
        {
            this.cnn.Open();
        }

            // Cada vez que llamo esta funcion realizo la desconexion con mi BD
            public void Desconectar()
            {
                this.cnn.Close();
            }

            public String Mensaje
            {
                get {
                    return this.mensaje;
                      }
            }

     }
}
