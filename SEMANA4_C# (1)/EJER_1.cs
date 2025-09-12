using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C___1_
{
    internal class EJER_1
    {
        static void Main(string[] args)
        {
            int edad;
            string msj = "";

            Console.WriteLine("\n--- RANGO DE EDAD ---");
            Console.Write("\nEdad: ");
            edad = int.Parse(Console.ReadLine());

            switch (edad)
            {
                case int e when e < 18: msj = "Es menos de edad."; break;
                case int e when e <= 64: msj = "Es adulto."; break;
                case int e when e >= 65: msj = "Es adulto mayor."; break;
            }

            Console.WriteLine("\n----------------");
            Console.Write($"{msj}");
        }
    }
}
