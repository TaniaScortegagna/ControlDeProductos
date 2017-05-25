using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
   public class Producto
    {
<<<<<<< HEAD
        public int Codigo{get;set; }
        public string Nombre{get;set; }
        public string Descripcion{get;set; }
        public Proveedor Proveedor = new Proveedor();
        public Rubro Rubro = new Rubro();
        public string Marca{get;set; }
        public decimal Precio{get;set; }

        public Producto() { }

        public Producto(int pcod, string pnom, string pdesc, Proveedor pprov, string pmarca,decimal pprecio, Rubro prubro)
        {
            this.Codigo = pcod;
            this.Nombre = pnom;
            this.Descripcion = pdesc;
            this.Proveedor = pprov;
            this.Marca = pmarca;
            this.Precio = pprecio;
            this.Rubro = prubro;
            
        }
   
=======
        public int codigo{get;set; }
        public string nombre{get;set; }
        public string descripcion{get;set; }
        public int proveedor{get;set; }
        public int rubro{get;set; }
        public string marca{get;set; }
        public decimal precio{get;set; }

        public Producto() { }

        public Producto(int pcod,string pnom,string pdesc,int pprov,int prubro,string pmarca, decimal pprecio)
        {
            this.codigo = pcod;
            this.nombre = pnom;
            this.descripcion = pdesc;
            this.proveedor = pprov;
            this.marca = pmarca;
            this.precio = pprecio;
            
        }
>>>>>>> origin/master
    }
}
