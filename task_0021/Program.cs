using System;

namespace task_0021
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дана сторона квадрата. Найти его периметр.

            Console.Write("Сторона квадрата: ");
            string stringSide = Console.ReadLine();
            double side = Convert.ToDouble(stringSide);

            double perimeter = side * 4;

            Console.WriteLine("Периметр квадрата со стороной {0} равен {1}.", side, perimeter);

            Console.ReadKey();
        }
    }
}
