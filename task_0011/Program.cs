using System;

namespace task_0011
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу, которая запрашивает название футбольной
            // команды и повторяет его на экране со словами «– это чемпион!».

            Console.WriteLine("Введите название футбольной команды:");
            string name = Console.ReadLine();

            Console.WriteLine("{0} - это чемпион!", name);

            Console.ReadKey();

        }
    }
}
