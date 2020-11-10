using System;

namespace task_0007
{
    class Program
    {
        static void Main(string[] args)
        {
            // Число  e  (основание  натурального  логарифма)  приблизительно
            // равно  2,71828 .Вывести  на экран  это число  с точностью до десятых.
            // Текст '2.7' не использовать.

            double e = 2.71828;

            Console.WriteLine("{0:f1}", e);

            Console.ReadKey();

        }
    }
}
