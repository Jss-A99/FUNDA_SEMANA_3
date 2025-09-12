using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EJER_7 ();
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
            Console.WriteLine("\n--- OPERACIONES BÁSICAS ---");
            Console.Write("\nIngrese un número decimal: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double raiz2 = Math.Sqrt(num);
            int redo = (int) Math.Round(num,0);
            double cubo = Math.Pow(num,3);
            double raiz3 = Math.Pow(num, 1/3d);

            Console.WriteLine("\n---------------------");
            Console.WriteLine($"Raíz cuadrada: {raiz2:f2}");
            Console.WriteLine($"Redondeado: {redo}");
            Console.WriteLine($"Potencia al cubo: {cubo:f2}");
            Console.WriteLine($"Raíz cúbica: {raiz3:f2}");
        }
        static void ejer5()
        {
            Console.Write("\nIngrese un número: ");
            string num = Console.ReadLine();

            int entero = int.Parse (num);
            double deci = double.Parse (num);

            Console.Write($"Resto: {entero % 2}");
            Console.WriteLine($"División/3: {deci / 3:f2}");
        }
        static void EJER_7()
        {
            Console.WriteLine("\nIngrese una cantidad de segundos: ");
            double num = double.Parse(Console.ReadLine());

            int horas = (int) num / 3600;
            int min = (horas % 60) / 60;
            int seg = (min % 60) / 60;

            Console.WriteLine($"\nHoras: {horas}");
            Console.WriteLine($"Minutos: {min}");
            Console.WriteLine($"Segundos: {seg}");
        }
    }
}
