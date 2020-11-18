using System;

namespace task_0022
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дан радиус окружности. Найти ее диаметр.

            Console.Write("Введите радиус окружности: ");
            string stringRadius = Console.ReadLine();
            double radius = Convert.ToDouble(stringRadius);

            double diameter = radius * 2;

            Console.WriteLine("Диаметр окружности с радиусом {0} равен {1}", radius, diameter);

            Console.ReadKey();
        }
    }
}
