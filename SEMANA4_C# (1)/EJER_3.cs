using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C___1_
{
    internal class EJER_3
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese monto en soles: ");
            double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("\n1. Dólares.");
            Console.WriteLine("2. Euros.");

            Console.Write("\nIngrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1: Console.WriteLine("\nDólares: " + Math.Round((monto / 3.75), 2)); break;
                case 2: Console.WriteLine($"\nEuros: {(monto / 4.05):F0}"); break;
                default: Console.WriteLine("\nOpción incorrecta.");  break;
            }
            
        }
    }
}
