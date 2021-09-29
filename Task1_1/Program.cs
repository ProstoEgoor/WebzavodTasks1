﻿using System;

namespace Task1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            long number;
            while(!long.TryParse(Console.ReadLine(), out number) || number < -1_000_000 || number > 1_000_000)
            {
                Console.WriteLine("Неверный ввод!");
                Console.Write("Введите число: ");
            }

            Console.WriteLine(number + " в квадрате равно: " + getSquare(number));
        }

        static long getSquare(long number)
        {
            return number * number;
        }

    }
}
