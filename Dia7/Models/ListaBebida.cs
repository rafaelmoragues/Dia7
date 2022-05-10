using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia7.Interfaces;

namespace Dia7.Models
{
    class ListaBebida : IMenu
    {
        List<Bebida> _bebidas;
        List<Bebida> listaTemporal; //lista que no deberia ir, solo esta para tener unos datos para trabajar
        public ListaBebida()
        {
            _bebidas = new List<Bebida>();
            listaTemporal = new List<Bebida>();//instancia de la lista temporal
            AgregarBebida(); // cargo la lista temporal con datos aleatorios
        }

        //agrega un producto a la lista de bebidas
        public void AgregarProd(Producto prod)
        {
            _bebidas.Add((Bebida)prod);
            Console.WriteLine("Agregado correctamente a la comanda");
        }

        public void EliminarProd(Producto product)
        {
            throw new NotImplementedException();
        }

        //devuelve la lista de bebidas
        public IEnumerable<Producto> ObtenerProd()
        {
            return _bebidas;
        }

        //agrega bebidas random a la lista temporal
        void AgregarBebida()
        {
            listaTemporal = new List<Bebida>();
            listaTemporal.Add(new Bebida("coca", 250, 1));
            listaTemporal.Add(new Bebida("Cerveza", 350,2));
            listaTemporal.Add(new Bebida("Vino", 830,3));
        }

        //busca y devuelve una bebida a traves del id
        public Bebida BuscaBebida(int id)
        {
            foreach (var bebida in listaTemporal)
            {
                if (bebida.Id == id)
                {
                    return bebida;
                }
            }
            return null;
        }

        //muestra las bebidas de la lista temporal
        public void MostrarBebidas()
        {
            Console.WriteLine("1: Coca");
            Console.WriteLine("2: Cerveza");
            Console.WriteLine("3: Vino");
        }
    }
}
