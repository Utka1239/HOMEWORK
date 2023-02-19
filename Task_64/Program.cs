/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int X = 1;
NaturalToLow(number, X);

void NaturalToLow(int n, int X)
{
    if (X > n)
    {
        return;
    }
    else
    {
        NaturalToLow(n, X + 1);
        Console.Write($"{X} ");
    }
}