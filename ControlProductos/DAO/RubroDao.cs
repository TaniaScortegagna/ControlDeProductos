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
            for (int x = 0; x < resultado.Rows.Count; x++){
                Rubro pRubro = new Rubro();
                pRubro.Id = Convert.ToInt32(resultado.Rows[x]["IdRubro"]);
                pRubro.Nombre = resultado.Rows[x]["Nombre"].ToString();
                listaRubros.Add(pRubro);
            }
            cnn.Desconectar();
            return listaRubros;
        }
    }
}
