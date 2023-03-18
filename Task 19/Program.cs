// Напишите программу, которая 
// 1. Принимает на вход пятизначное число
// 2. Проверяет, является ли оно палиндромом

int num, r, sum = 0, t;
Console.WriteLine("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if (num > 9999 && num < 100000)
{
    for (t = num; num != 0; num = num / 10)
    {
        r = num % 10;
        sum = sum * 10 + r;
    }
    if (t == sum)
        Console.Write($"{t} является палиндромом");
    else
    {
        Console.Write($"{t} не является палиндромом");
    }
}
else
{
    Console.Write("Введите пятизначное число!");
}
