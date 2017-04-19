using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class Rubro
    {
        public int IdRubro { get; set; }
        public String Nombre{ get; set; }
        public String Descripcion{ get; set; }
        public int IdFlia { get; set; }


        public Rubro() { }
        public Rubro(int pId, string pNombre, string pDescripcion, int pIdFlia)
        {
            this.IdRubro = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.IdFlia = pIdFlia;

        }
    }
}
