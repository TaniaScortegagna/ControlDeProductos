using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class FamiliaDao
    {
        
        public FamiliaDao() { }

        public List<Familia> obtenerFamilia()
        {

            List<Familia> listaFamilias = new List<Familia>();
            Conexion cnn = new Conexion();

            string pConsulta = string.Format("SP_LISTAR_FAMILIAS");
            DataTable resultado = cnn.EjecutarQuery(pConsulta);
                       
            foreach (DataRow familia in  resultado.Rows)
            {
                Familia oFamilia = new Familia();
                oFamilia.Id = Convert.ToInt32(familia["IdFamilia"]);
                oFamilia.Nombre = familia["Nombre"].ToString();
                listaFamilias.Add(oFamilia);
            }         

            cnn.Desconectar();
            return listaFamilias;
       
       }
    }
}
