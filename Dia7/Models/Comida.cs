using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia7.Models
{
     class Comida : Producto
    {
        public int Id { get; set; }
        public Comida()
        {

        }

        public Comida(string nombre, double precio,int id)
        {
            Nombre = nombre;
            Precio = precio;
            Id = id;
        }
    }
}
