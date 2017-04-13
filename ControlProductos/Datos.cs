using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace ControlProductos
{
    class Datos: Conexion
    {
        public DataTable cargarGrilla()
           {   
                SqlCommand consulta = new SqlCommand(string.Format("SELECT * FROM Productos"), cnn);
                SqlDataAdapter da = new SqlDataAdapter (consulta) ;
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.Desconectar();
                return dt;   
            }

    }


}
