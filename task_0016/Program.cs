using System;

namespace task_0016
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Составить программу вывода на экран следующей информации:
             * а)  5 10  б)  100   t  в)  x 25
             *     7 см      1949  v      x y
             * 
             * Примечание
             * t, v, x и y – переменные величины целого типа, значения 
             * которых вводятся с клавиатуры и должны быть выведены 
             * вместо имен величин.
             */

            Console.Write("Введите переменную t: ");
            string st = Console.ReadLine();
            int t = Convert.ToInt32(st);

            Console.Write("Введите переменную v: ");
            string sv = Console.ReadLine();
            int v = Convert.ToInt32(sv);

            Console.Write("Введите переменную x: ");
            string sx = Console.ReadLine();
            int x = Convert.ToInt32(sx);

            Console.Write("Введите переменную y: ");
            string sy = Console.ReadLine();
            int y = Convert.ToInt32(sy);

            Console.WriteLine("a) 5 10\tб) 100  {0}\tв) {1} 25", t, x);
            Console.WriteLine("   7 см\t   1949 {0}\t   {1} {2}", v, x, y);

            Console.ReadKey();

        }
    }
}
