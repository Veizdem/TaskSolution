using System;

namespace task_0018
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Составить программу:
             * 
             * а) вычисления значения функции y = 17x^2 – 6x + 13 при любом значении х;
             * 
             * б) вычисления значения функции y = 3a^2 + 5a – 21 при любом значении а;
             * 
             */

            Console.WriteLine("Решение пункта а)\n");

            Console.Write("X = ");
            string stringX = Console.ReadLine();
            double x = Convert.ToDouble(stringX);

            double y = 17 * Math.Pow(x, 2) - 6 * x + 13;

            Console.WriteLine("При х = {0}, y = 17x^2 – 6x + 13 = {1}", x, y);

            Console.WriteLine(new string('-', 50));

            Console.WriteLine("\nРешение пункта б)\n");

            Console.Write("A = ");
            string stringA = Console.ReadLine();
            double a = Convert.ToDouble(stringA);

            y = 3 * Math.Pow(a, 2) + 5 * a - 21;

            Console.WriteLine("При a = {0}, y = 3a^2 + 5a – 21 = {1}", a, y);

            Console.ReadKey();
        }
    }
}
