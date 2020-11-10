using System;

namespace task_0008
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран числа, вводимого 
            // с клавиатуры. Выводимому числу должно предшествовать 
            // сообщение «Вы ввели число».

            string stringNumber = Console.ReadLine();

            int number = Convert.ToInt32(stringNumber);

            Console.WriteLine("Вы ввели число {0}", number);

            Console.ReadKey();
        }
    }
}
