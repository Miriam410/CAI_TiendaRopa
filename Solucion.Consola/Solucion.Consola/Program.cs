using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.LibreriaClase;
using Proyecto.LibreriaConsola;
using Proyecto.LibreriaClase.Entidades;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinuarActivo = true;
            string menu = ("1)Listar Indumentaria" + Environment.NewLine +
                "2) Agregar Indumentaria" + Environment.NewLine +
                "3) Modificar Indumentaria" + Environment.NewLine +
                "4) Eliminar Indumentaria" + Environment.NewLine +
                "5) Listar Ordenes" + Environment.NewLine +
                "6) Devolver Orden" + Environment.NewLine +
                "X) Salir" + Environment.NewLine);

         
            Console.WriteLine("Bienvenidos a Adiddas");
            do
            {
                Console.WriteLine("menu");
                try
                {
                    string opcionSeleccionada = Console.ReadLine();
                    if (ConsolaHelper.EsValido(opcionSeleccionada, "123456X"))
                    {
                        if (opcionSeleccionada.ToUpper() == "X")
                        {
                            ContinuarActivo = false;
                            continue;
                        }
                        switch (opcionSeleccionada)
                        {
                            case "1":
                                AgregarIndumentaria(Adidas);
                                break;
                            case "2":
                                ModificaIndumentaria(Adidas);
                                break;
                            case "3":
                                EliminarIndumentaria(Adidas);
                                break;
                            case "4":
                                ListarOrden(Adidas);
                                break;
                            case "5":
                                DevolverOrden(Adidas);
                                break;
                            case "X":
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("opcion invalido");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("opcion invalido");
                    }
                    catch (Exception ex)
                {
                    Console.WriteLine("Eror durante la Ejecucion del comando. Por favor intente nuevamente. Mesanje: " + ex.Message);
                }
                Console.WriteLine("ingrese una tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
            while (ContinuarActivo);
            Console.WriteLine("gracias por usar la app");
            Console.ReadKey();
            }

        }
    }
}
