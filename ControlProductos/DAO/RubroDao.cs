using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class RubroDao
    {    

        public RubroDao() { }
        public List<Rubro> obtenerRubro(int pIdFlia)
        {
            List<Rubro> listaRubros = new List<Rubro>();
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("SELECT IdRubro , Nombre FROM Rubros WHERE IdFlia = '{0}'", pIdFlia);            
            DataTable resultado = cnn.EjecutarQuery(pConsulta, CommandType.Text);

            for (int x = 0; x < resultado.Rows.Count; x++)
            {
                Rubro oRubro = new Rubro();
                oRubro.Id = Convert.ToInt32(resultado.Rows[x]["IdRubro"]);
                oRubro.Nombre = resultado.Rows[x]["Nombre"].ToString();
                listaRubros.Add(oRubro);
            }
            cnn.Desconectar();
            return listaRubros;
        }
    }
}
