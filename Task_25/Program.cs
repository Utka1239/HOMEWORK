/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

// int a = 3;
// int b = 5;
// Console.Write(Math.Pow(a, b));



int a = 3;
int b = 5;   
int sum = a;
for (int i = 1; i < b; i++)
{
    sum = sum * a;
    
}
Console.Write(sum);