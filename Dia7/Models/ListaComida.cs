using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia7.Interfaces;

namespace Dia7.Models
{
    class ListaComida : IMenu
    {
        List<Comida> _comida;
        List<Comida> listaTemporal;

        public ListaComida()
        {
            _comida = new List<Comida>();
            AgregarComida();
        }
        public void AgregarProd(Producto prod)
        {
            _comida.Add((Comida)prod);
            Console.WriteLine("Agregado correctamente a la comanda");
        }

        public void EliminarProd(Producto product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ObtenerProd()
        {
            return _comida;
        }
        void AgregarComida()
        {
            listaTemporal = new List<Comida>();
            listaTemporal.Add(new Comida("ñoquis", 950,1));
            listaTemporal.Add(new Comida("milanesa", 800,2));
            listaTemporal.Add(new Comida("hamburguesa", 900,3));
            listaTemporal.Add(new Comida("tortilla", 750,4));
        }
        public Comida BuscaComida(int id)
        {
            foreach (var comida in listaTemporal)
            {
                if (comida.Id == id)
                {
                    return comida;
                }
            }
            return null;
        }

        public void MostrarComida()
        {
            Console.WriteLine("1: ñoquis");
            Console.WriteLine("2: milanesa");
            Console.WriteLine("3: hamburguesa");
            Console.WriteLine("4: tortilla");
        }
    }
}
