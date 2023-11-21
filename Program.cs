// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

using System;
using System.Runtime.Intrinsics.Arm;

class Program
{
    static void Main()
    {
        System.Console.WriteLine( "Введите число first: ");
        int first = Convert.ToInt32(Console.ReadLine());

        if (first % 7 ==0 && first % 23 == 0)
        {
        System.Console.WriteLine("Верно");
    }
    else
    {
        System.Console.WriteLine ("Неверно");
    }
}
}