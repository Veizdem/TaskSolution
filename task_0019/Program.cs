using System;

namespace task_0019
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Составить программу вычсиления фунции при любом значении а.
             * 
             * (Функция прикреплена в картинке)
             */

            Console.Write("А = ");
            string stringA = Console.ReadLine();
            double a = Convert.ToDouble(stringA);

            double y = (Math.Pow(a, 2) + 10) / Math.Sqrt(Math.Pow(a, 2) + 1);

            Console.WriteLine("При а = {0} результат равен {1}", a, y);

            Console.ReadKey();
        }
    }
}
