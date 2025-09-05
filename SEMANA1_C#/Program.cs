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
            ejer1();
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
    }
}
