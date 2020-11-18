using System;

namespace task_0020
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Составить программу:
             * а) вычисления значения функции task_0020_a.jpg при любом значении а;
             * б) вычисления значения функции task_0020_b.jpg при любом значении х;
             * 
             * Функции в приложенных картинках
             */

            Console.WriteLine("Решение пункта а)\n");

            Console.Write("A = ");
            string stringA = Console.ReadLine();
            double a = Convert.ToDouble(stringA);

            double y = Math.Sqrt((2 * a + Math.Sin(Math.Abs(3 * a))) / 3.56);

            Console.WriteLine("При а = {0} выражение равно {1}", a, y);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\nРешение пункта б)\n");

            Console.Write("X = ");
            string stringX = Console.ReadLine();
            double x = Convert.ToDouble(stringX);

            y = Math.Sin((3.2 + Math.Sqrt(1 + x)) / Math.Abs(5 * x));

            Console.WriteLine("При х = {0} выражение равно {1}", x, y);

            Console.ReadKey();
        }
    }
}
