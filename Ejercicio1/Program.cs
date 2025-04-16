using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //ax^2 + bx + c
            //2 soluciones
            //disc > 0 -> 2 sol.
            //disc = 0 -> 1 sol.
            //disc < 0 -> 0 sol.
            int a, b, c;
            double x1, x2, disc;
            Console.Write("Ingrese valor de a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Ingrese valor de c: ");
            c = int.Parse(Console.ReadLine());
            disc = (b * b) - (4 * a * c);

            if (disc > 0)
            {
                x1 = (-b + Math.Sqrt(disc)) / 2 * a;
                x2 = (-b - Math.Sqrt(disc)) / 2 * a;
                Console.WriteLine("X1: " + x1);
                Console.WriteLine("X2: " + x2);
            }
            else
            {
                if (disc == 0)
                {
                    x1 = -b / 2 * a;
                    Console.WriteLine("X1: " + x1);
                }
                else
                {
                    Console.WriteLine("No tiene soluciones");
                }

                Console.ReadKey();
            }
        }
    }
}
