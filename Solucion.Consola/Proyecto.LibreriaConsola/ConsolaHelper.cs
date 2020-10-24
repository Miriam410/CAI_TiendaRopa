using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.LibreriaConsola
{
    public class ConsolaHelper
    {
        public string PedirString(string msg)
        {
            Console.WriteLine("Ingrese"+ msg);
            string n = Console.ReadLine();
            return n;
        }
        public int PedirInt(string msg)
        {
            Console.WriteLine("Ingrese" + msg);
            int  c = Convert.ToInt32(Console.ReadLine());
            return c;
        }
        public double PedirDouble(string msg)
        {
            Console.WriteLine("Ingrese" + msg);
            double p = Convert.ToDouble(Console.ReadLine());
            return p;
        }

        public static bool EsValido(string input, string opcionValido)
        {
            try
            {
                if (string.IsNullOrEmpty(input) || input.Length > 1 ||
                    !opcionValido.ToUpper().Contains(input.ToUpper()))
                {
                    return false;
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
