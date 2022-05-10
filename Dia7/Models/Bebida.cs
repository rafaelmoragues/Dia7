using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia7.Models
{
     class Bebida : Producto
    {
        public int Id { get; set; }
        public Bebida()
        {

        }

        public Bebida(string nombre, double precio, int id)
        {
            Nombre = nombre;
            Precio = precio;
            Id = id;
        }
    }
}
