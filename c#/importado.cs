using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Task;

namespace ejemplo_1_7_mo
{
    public class Importado:Producto
    {
        public Importado() : base()
        {
            this.Precio=this.Precio + this.Precio * 0.30m;
        }
        public Importado(int id, string nombre, decimal precio) : base()
        {
            Id = id;
            Nombre = nombre;
            Precio = precio +(precio * 0.30m);
        }
    }
}