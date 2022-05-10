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
        List<Comida> listaTemporal; //lista que no deberia ir, solo esta para tener unos datos para trabajar

        public ListaComida()
        {
            _comida = new List<Comida>();//instancia de la lista temporal
            AgregarComida();// cargo la lista temporal con datos aleatorios
        }
        //agrega un producto a la lista de bebidas
        public void AgregarProd(Producto prod)
        {
            _comida.Add((Comida)prod);
            Console.WriteLine("Agregado correctamente a la comanda");
        }

        public void EliminarProd(Producto product)
        {
            throw new NotImplementedException();
        }
        //devuelve la lista de bebidas
        public IEnumerable<Producto> ObtenerProd()
        {
            return _comida;
        }

        //agrega bebidas random a la lista temporal
        void AgregarComida()
        {
            listaTemporal = new List<Comida>();
            listaTemporal.Add(new Comida("ñoquis", 950,1));
            listaTemporal.Add(new Comida("milanesa", 800,2));
            listaTemporal.Add(new Comida("hamburguesa", 900,3));
            listaTemporal.Add(new Comida("tortilla", 750,4));
        }

        //busca y devuelve una bebida a traves del id
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

        //muestra las bebidas de la lista temporal
        public void MostrarComida()
        {
            Console.WriteLine("1: ñoquis");
            Console.WriteLine("2: milanesa");
            Console.WriteLine("3: hamburguesa");
            Console.WriteLine("4: tortilla");
        }
    }
}
