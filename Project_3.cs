// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

using System;
class Program
{
static void Main()
{
Console.Write("Введите число из отрезка [10, 99]: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;Console.WriteLine(maxDigit);
}
}