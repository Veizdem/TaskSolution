using System;

namespace task_0009
{
    class Program
    {
        static void Main(string[] args)
        {
            // Составить программу вывода на экран числа, вводимого 
            // с клавиатуры. После выводимого числа должно следовать
            // сообщение «– вот какое число Вы ввели».

            string stringNumber = Console.ReadLine();

            int number = Convert.ToInt32(stringNumber);

            Console.WriteLine("{0} - вот какое число Вы ввели", number);

            Console.ReadKey();

        }
    }
}
