/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


int[] GetArray(int dimension) // Создание массива
{
    int [] array = new int[dimension];
    Random number = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = number.Next(100,999);
    }
return array;
}


int FindCount(int[] array) // Поиск четных чисел в массиве
{
    var count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] arr = GetArray(123);
int count = FindCount(arr); 

Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"В указанном массиве находится {count} четных чисел.");
