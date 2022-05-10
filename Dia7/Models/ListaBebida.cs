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
        List<Bebida> listaTemporal;
        public ListaBebida()
        {
            _bebidas = new List<Bebida>();
            listaTemporal = new List<Bebida>();
            AgregarBebida();
        }
        public void AgregarProd(Producto prod)
        {
            _bebidas.Add((Bebida)prod);
            Console.WriteLine("Agregado correctamente a la comanda");
        }

        public void EliminarProd(Producto product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Producto> ObtenerProd()
        {
            return _bebidas;
        }

        void AgregarBebida()
        {
            listaTemporal = new List<Bebida>();
            listaTemporal.Add(new Bebida("coca", 250, 1));
            listaTemporal.Add(new Bebida("Cerveza", 350,2));
            listaTemporal.Add(new Bebida("Vino", 830,3));
        }
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

        public void MostrarBebidas()
        {
            Console.WriteLine("1: Coca");
            Console.WriteLine("2: Cerveza");
            Console.WriteLine("3: Vino");
        }
    }
}
