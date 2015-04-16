using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Controlar y mostrar el error que captura el catch cuando se intenta dividir por cero, tambien imprimir 
              la propiedad stack trace de la exepcion.*/

            int numero, resultado;
            Console.WriteLine(Console.ReadLine());
            try
                {
                resultado= 5/numero; /*Se coloca cualquier numero*/
                }
            catch (Exception error)
                {
                Console.WriteLine(Exception.Message);
                }
            Console.ReadKey();
        }
    }
}
