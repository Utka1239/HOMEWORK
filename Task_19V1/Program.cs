/*Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/


Console.Write("Введите 5-ти значное число: ");
var number = Console.ReadLine();
if (number.Reverse().SequenceEqual(number))
{
    Console.WriteLine("Это число является палиндромом.");
}
else
{
    Console.Write("Число не является палиндромом.");
}

