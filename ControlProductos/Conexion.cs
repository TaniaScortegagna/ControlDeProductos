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

        public Conexion()
        {
            this.conexiones = (@"Data source=(local);Initial Catalog = ControlDeProductos; integrated security = True");
            this.cnn = new SqlConnection(this.conexiones);

        }
        public String Mensaje
        {
            get {
                return this.mensaje;
                  }
        }
    }
}
