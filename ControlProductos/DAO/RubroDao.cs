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
            string pConsulta = string.Format("SP_LISTAR_RUBROS");
            cnn.AgregarParametro("@idFlia", pIdFlia.ToString(), SqlDbType.Int);
            DataTable resultado = cnn.EjecutarQuery(pConsulta);            
            foreach (DataRow rubro in resultado.Rows)
            {
                Rubro oRubro = new Rubro();
                oRubro.Id = Convert.ToInt32(rubro["IdRubro"]);
                oRubro.Nombre = rubro["Nombre"].ToString();
                listaRubros.Add(oRubro);
            }
            listaRubros.Insert(0, new Rubro() { Id = 0, Nombre = "<Seleccione un Item>" });
            cnn.Desconectar();
            return listaRubros;
        }
        public List<Rubro> obtenerRubro()
        {
            List<Rubro> listaRubros = new List<Rubro>();
            Conexion cnn = new Conexion();
            string pConsulta = string.Format("SP_LISTAR_RUBROS_SIN_FAMILIA");
            DataTable resultado = cnn.EjecutarQuery(pConsulta);
            foreach (DataRow rubro in resultado.Rows)
            {
                Rubro oRubro = new Rubro();
                oRubro.Id = Convert.ToInt32(rubro["IdRubro"]);
                oRubro.Nombre = rubro["Nombre"].ToString();
                listaRubros.Add(oRubro);
            }
            listaRubros.Insert(0, new Rubro() { Id = 0, Nombre = "<Seleccione un Item>" });
            cnn.Desconectar();
            return listaRubros;
        }
    }
}
