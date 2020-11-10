using System;

namespace task_0013
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которую вводится целое число,
             * после чего на экран выводится следующее и предыдущее целое 
             * число. Например, при вводе числа 15 на экран должно быть выведено:
             * Следующее за числом 15 число – 16.
             * Для числа 15 предыдущее число – 14.
             */

            Console.Write("Введите число: ");
            string stringNumber = Console.ReadLine();

            int number = Convert.ToInt32(stringNumber);

            int prevNumber, nextNumber;
            prevNumber = number - 1;
            nextNumber = number + 1;

            Console.WriteLine("Следующее за числом {0} число - {1}.", number, nextNumber);
            Console.WriteLine("Для числа {0} предыдущее число - {1}.", number, prevNumber);

            Console.ReadKey();

        }
    }
}
