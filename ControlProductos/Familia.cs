using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class Familia
    {
        public int IdFamilia { get; set; }
        public String Nombre{ get; set; }
        public String Descripcion{ get; set; }


        public Familia() { }
        
        public Familia(int pId, string pNombre, string pDescripcion)
        {
            this.IdFamilia = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;

        }
    }


}
