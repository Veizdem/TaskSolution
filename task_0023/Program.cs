using System;

namespace task_0023
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Считая, что Земля – идеальная сфера с радиусом R ≈ 6350 км,
             * определить расстояние до линии горизонта от точки с заданной
             * высотой над Землей.
             */

            const int RADIUS = 6_350_000;

            Console.Write("Введите нужную высоту (м): ");
            string stringH = Console.ReadLine();
            double h = Convert.ToDouble(stringH);

            double horizont = Math.Sqrt(Math.Pow(RADIUS + h, 2) - Math.Pow(RADIUS, 2));

            Console.WriteLine("Расстояние до горизонта на высоте {0} метров равно {1} (в метрах)", h, horizont);

            Console.ReadKey();
        }
    }
}
