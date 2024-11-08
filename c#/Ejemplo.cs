using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace ejemplo_1_7_mo
{
    public class Producto
    {
        public int Id{get; set;}
        public decimal Precio {get; set;}
        public string Nombre {get; set;}

        public override string ToString()
        {
            return "Producto: Id "+this.Id+"Precio "+this.Precio+" Nombre"+this.Nombre;
        }
        public Producto(){
            //constructor
        }
        public Producto(int id, decimal precio,string nombre)
        {
            this.Nombre=nombre;
            this.Id=id;
            this.Precio=precio;
        }
    }
}