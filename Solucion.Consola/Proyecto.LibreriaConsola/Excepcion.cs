using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaConsola
{
    public class SinIndumentariaException : Exception
    {
        public class SinIndumentariExcepcion() :base ("No hay indumentaria cargado")
        {
        
        }
        public SinIndumentariaException(int cod) : base("No hay indumentaria cargado" + cod)
        {

        }
    }
}
