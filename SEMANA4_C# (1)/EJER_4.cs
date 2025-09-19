using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA4_C___1_
{
    internal class EJER_4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de Áreas");
            Console.WriteLine("1. Cuadrado.");
            Console.WriteLine("2. Rectángulo.");
            Console.WriteLine("3. Triángulo:");
            Console.WriteLine("4. Círculo.");

            Console.Write("\nIngrese una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("\nIngrese el lado: ");
                    int lado = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del cuadrado: " + lado * lado);
                    break;
                case 2:
                    Console.Write("\nIngrese la altura: ");
                    int alt = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese la base: ");
                    int bas = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del rectángulo: " + bas * alt);
                    break;
                case 3:
                    Console.Write("\nIngrese la altura: ");
                    int alt1 = int.Parse(Console.ReadLine());
                    Console.Write("\nIngrese la base: ");
                    int bas1 = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del triángulo: " + ((bas1 * alt1) / 2));
                    break;
                case 4:
                    Console.Write("\nIngrese el radio: ");
                    int rad = int.Parse(Console.ReadLine());
                    Console.Write("\nÁrea del círculo: " + Math.Round((Math.PI * Math.Pow(rad,2)),2));
                    break;
                default: Console.WriteLine("Opción incorrecta."); 
                    break;
            }
        }
    }
}
