using System;

namespace task_0014
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран в одну строку трех любых
            // чисел, вводимых с клавиатуры, с двумя пробелами между ними.

            Console.Write("Введите первое число: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите третье число: ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}  {1}  {2}", n1, n2, n3);

            Console.ReadKey();
        }
    }
}
