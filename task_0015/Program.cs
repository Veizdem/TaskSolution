using System;

namespace task_0015
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран в одну строку четырех\
            // любых чисел, вводимых с клавиатуры, с одним пробелом между ними.

            Console.Write("Введите первое число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int n3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите четвертое число: ");
            int n4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);

            Console.ReadKey();

        }
    }
}
