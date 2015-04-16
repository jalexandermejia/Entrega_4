using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApPTryCatch_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50) no olvidar el manejo de errores.*/

            int numero, resultado;
            Console.WriteLine(Console.ReadLine());
            try
            {
                resultado = 5 / numero; /*Se coloca cualquier numero*/
            }
            catch (Exception error)
            {
                Console.WriteLine(Exception.Message);
            }
            Console.ReadKey();
        }
    }
}
