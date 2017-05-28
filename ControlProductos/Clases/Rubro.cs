using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    public class Rubro
    {
        public int Id { get; set; }
        public String Nombre{ get; set; }
        public String Descripcion{ get; set; }
        public Familia Familia = new Familia();



        public Rubro() { }
        public Rubro(int pId, string pNombre, string pDescripcion, Familia pFamilia)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
            this.Familia = pFamilia;

        }
    }
}
