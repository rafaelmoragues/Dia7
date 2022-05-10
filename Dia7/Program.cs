using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia7.Models;
using Dia7.Controllers;

namespace Dia7
{
    internal class Program
    {
        static ListaBebida lB = new ListaBebida();
        static ListaComida lC = new ListaComida();
        Comanda com = new Comanda(lC, lB);
        void PrintMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("1. Agregar producto");
            stringBuilder.AppendLine("2. Eliminar Producto");
            stringBuilder.AppendLine("3. Cerrar comanda");
            stringBuilder.AppendLine("Seleccione una opcion");
            Console.WriteLine(stringBuilder);
        }

        void Opciones()
        {
            string op = Console.ReadLine();

            if (Int32.TryParse(op, out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        lB.MostrarBebidas();
                        Console.WriteLine("Elija la bebida");
                        int a = Int32.Parse(Console.ReadLine());
                        Bebida bb = lB.BuscaBebida(a);
                        lB.AgregarProd(bb);
                        lC.MostrarComida();
                        Console.WriteLine("Elija Comida");
                        a = Int32.Parse(Console.ReadLine());
                        Comida cc = lC.BuscaComida(a);
                        lC.AgregarProd(cc);
                        break;
                    case 2:
                        break;
                    case 3:
                        double tot = com.CalcularTotal();
                        Console.WriteLine(tot);
                        Console.ReadKey();
                        break;
                }
            }
        }
        static void Main(string[] args)
        {

            Program p = new Program();
            p.PrintMenu();
            p.Opciones();
            string op;
            do
            {
                Console.WriteLine("Desea ejecutar otro ejercicio? s/n");
                op = Console.ReadLine();
                if (op == "s")
                    p.PrintMenu();
                    p.Opciones();
            }
            while (op == "s");
        }
    }
}
