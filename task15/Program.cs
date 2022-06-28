// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число, порядковый день недели (от 1 до 7): ");
int a = int.Parse(Console.ReadLine());

    switch (a)
    {
    case 1: Console.WriteLine("Рабочий день "); break;
    case 2: Console.WriteLine("Рабочий день "); break;
    case 3: Console.WriteLine("Рабочий день "); break;
    case 4: Console.WriteLine("Рабочий день "); break;
    case 5: Console.WriteLine("Рабочий день "); break;
    case 6: Console.WriteLine("Выходной "); break;
    case 7: Console.WriteLine("Выходной "); break;
    default: Console.WriteLine("Введите от 1 до 7 "); break;
    }
