﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (!(a < 100|| a > 999))
{
   a = a % 100;
   a = a / 10;
    Console.WriteLine(a);
}
else {Console.WriteLine("Число не трехзначное");}