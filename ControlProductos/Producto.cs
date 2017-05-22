using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
    class Producto
    {
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
    }
}
