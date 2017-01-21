using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capitulo8Ejercicio2
{
    class Program
    {
        //Hacer un programa que le pida al usuario una cadena y la forma de justificarla.

        static void Main(string[] args)
        {
            Console.WriteLine("Digite la cadena a justificar: ");
            string cad = Console.ReadLine();
            Console.Write("Digite la cantidad de espacios para justificar: ");
            int spaces = Convert.ToInt32(Console.ReadLine());
            cad = cad.PadLeft(spaces);
            Console.WriteLine("\nNueva cadena:\n" + cad);
            Console.ReadKey();
        }
    }
}
