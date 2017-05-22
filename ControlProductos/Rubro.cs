using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class Rubro
    {
        public int Id { get; set; }
        public String Nombre{ get; set; }
        public String Descripcion{ get; set; }

        public int IdFlia { get; set; }

        //public Familia familia {
        //    get
        //    {
        //        if (familia != null)
        //        {
        //            return familia;
        //        }
        //        else
        //        { 
                    

        //        }
        //    }
        //    set { }        
        //}


        public Rubro() { }
        public Rubro(int pId, string pNombre, string pDescripcion, int pIdFlia)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.IdFlia = pIdFlia;

        }
    }
}
