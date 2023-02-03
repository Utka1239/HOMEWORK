// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] FArray()
{
    int[] array = new int [8];
Random number = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = number.Next(0, 10);
}
return array;
}
int[] a = FArray();
void PrintFArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]},");
    }
}
PrintFArray(a);



