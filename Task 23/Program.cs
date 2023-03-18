// Напишите программу, которая
// 1. Принимает на вход число (N);
// 2. Выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Таблица кубов:\n");
for (int i = 1; i <= n; i++)
{
    int k = i * i * i;
    Console.Write($"{ k}, ");
}
