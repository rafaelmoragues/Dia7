using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dia7.Models;

namespace Dia7.Interfaces
{
     interface IMenu
    {
        IEnumerable<Producto> ObtenerProd();
        void AgregarProd(Producto prod);
        void EliminarProd(Producto product);
    }
}
