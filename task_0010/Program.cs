using System;

namespace task_0010
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу, которая запрашивает имя человека
            // и повторяет его на экране.

            Console.WriteLine("Введите Ваше имя:");
            string name = Console.ReadLine();

            Console.WriteLine("{0}", name);

            Console.ReadKey();

        }
    }
}
