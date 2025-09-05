using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey(); //REALIZANDO DETENIMIENTO DE CONSOLA
        }
        static void ejer1()
        {
            string nombre, carrera;

            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese su carrera: ");
            carrera = Console.ReadLine();

            Console.WriteLine($"\n{nombre}, bienvenido(a) al curso Fundamentos de Algoritmos de {carrera}.");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Jessy\"");
        }

        static void ejer3()
        {
            Console.WriteLine("Ingrese x: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Suma: " +(x + y));
            Console.WriteLine("Resta: " +(x - y));
            Console.WriteLine("Multiplicación: " +(x * y));
            Console.WriteLine("División: " +(x / y));
        }
        static void ejer4()
        {
            Console.WriteLine("Hola");
        }
    }
}
