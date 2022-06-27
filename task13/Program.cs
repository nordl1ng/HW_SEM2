// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine());
a = Math.Abs(a);

if ((a > 0) && (a < 100)) 
{
    Console.WriteLine("Третьей цифры нет");
}
if (a >= 100 && a < 1000 )
{
   while (a > 99)
    {
    a = a % 10;
    }
    Console.WriteLine(a);
}

if (a >= 1000)
{
   while (a > 999)
    {
    a = a / 10;
    }
    Console.WriteLine(a % 10);
}
