using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlProductos
{
   public class Producto
    {
        public int Codigo{get;set; }
        public string Nombre{get;set; }
        public string Descripcion{get;set; }
        public Proveedor Proveedor = new Proveedor();
        public Rubro Rubro = new Rubro();
        public string Marca{get;set; }
        public double Precio{get;set; }
        public bool Activo { get; set; }
        public Producto() { }

        public Producto(int pcod, string pnom, string pdesc, Proveedor pprov, string pmarca, double pprecio, Rubro prubro, bool pActivo)
        {
            this.Codigo = pcod;
            this.Nombre = pnom;
            this.Descripcion = pdesc;
            this.Proveedor = pprov;
            this.Marca = pmarca;
            this.Precio = pprecio;
            this.Rubro = prubro;
            this.Activo = pActivo;
            
        }
   
    }
}
