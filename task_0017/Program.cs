using System;

namespace task_0017
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Составить программу вывода на экран следующей информации:
             * а)  2 кг  б)  а 1  в) x y
             *    13 17     19 b     5 y
             *    
             * Примечание
             * a, b, x и y – переменные величины целого типа, значения 
             * которых вводятся с клавиатуры и должны быть выведены 
             * вместо имен величин.
             */

            Console.Write("Введите переменную a: ");
            string sa = Console.ReadLine();
            int a = Convert.ToInt32(sa);

            Console.Write("Введите переменную b: ");
            string sb = Console.ReadLine();
            int b = Convert.ToInt32(sb);

            Console.Write("Введите переменную x: ");
            string sx = Console.ReadLine();
            int x = Convert.ToInt32(sx);

            Console.Write("Введите переменную y: ");
            string sy = Console.ReadLine();
            int y = Convert.ToInt32(sy);

            Console.WriteLine("a) 2 кг\tб) {0} 1\tв) {1} {2}", a, x, y);
            Console.WriteLine("  13 17\t   19 {0}\t   5 {1}", b, y);

            Console.ReadKey();
        }
    }
}
