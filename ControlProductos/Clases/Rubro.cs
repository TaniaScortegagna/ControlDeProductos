using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
<<<<<<< HEAD
    public class Rubro
=======
<<<<<<< HEAD
    public class Rubro
=======
    class Rubro
>>>>>>> origin/master
>>>>>>> origin/master
    {
        public int Id { get; set; }
        public String Nombre{ get; set; }
        public String Descripcion{ get; set; }
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master
        public Familia Familia = new Familia();



        public Rubro() { }
        public Rubro(int pId, string pNombre, string pDescripcion, Familia pFamilia)
<<<<<<< HEAD
=======
=======

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
>>>>>>> origin/master
>>>>>>> origin/master
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Descripcion = pDescripcion;
<<<<<<< HEAD
            this.Familia = pFamilia;
=======
<<<<<<< HEAD
            this.Familia = pFamilia;
=======
            this.IdFlia = pIdFlia;
>>>>>>> origin/master
>>>>>>> origin/master

        }
    }
}
