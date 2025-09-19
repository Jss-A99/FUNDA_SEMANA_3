using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C___1_
{
    internal class EJER_2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese año: ");
            int an = int.Parse(Console.ReadLine());

            if ((an % 4 == 0 & an % 100 != 0) || an % 400 == 0)
                Console.WriteLine("El año es bisiesto.");
            else 
                Console.WriteLine("El año no es bisiesto.");

            if (an % 2 == 0) Console.WriteLine("El año es par.");
            else Console.WriteLine("El año es impar."); 
        }
    }
}
