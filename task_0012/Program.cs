﻿using System;

namespace task_0012
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Напишите программу, в которую вводится имя человека
             * и выводится на экран приветствие в виде слова «Привет», после
             * которого должна стоять запятая, введенное имя и восклицательный
             * знак. После запятой должен стоять пробел, а перед восклицательным
             * знаком пробела быть не должно.
             */

            Console.WriteLine("Введите имя:");
            string name = Console.ReadLine();

            Console.WriteLine("Привет, {0}!", name);

            Console.ReadKey();
        }
    }
}
