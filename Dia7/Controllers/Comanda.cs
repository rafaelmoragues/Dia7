using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia7.Interfaces;
using Dia7.Models;

namespace Dia7.Controllers
{
    internal class Comanda
    {
        private IMenu _menuComida;
        private IMenu _menuBebida;

        public Comanda(IMenu menucom, IMenu menubeb)
        {
            _menuComida = menucom;
            _menuBebida = menubeb;
        }
        public double CalcularTotal()
        {
            double total = 0;
            IEnumerable<Producto> lista = _menuComida.ObtenerProd();
            foreach (Producto prod in lista)
            {
                total += prod.Precio;
                Console.WriteLine(prod.Nombre + " $"+ prod.Precio);
            }
            IEnumerable<Producto> lista2 = _menuBebida.ObtenerProd();
            foreach (Producto prod in lista2)
            {
                total += prod.Precio;
                Console.WriteLine(prod.Nombre + " $" + prod.Precio);
            }
            return total;
        }
    }
}
