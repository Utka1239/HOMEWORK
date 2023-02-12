/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] InitArray(int dimension)
{
    int [] arr = new int[dimension];
    Random number = new Random();
    for (int i = 0; i < dimension; i++)
    {
        arr[i] = number.Next(-999, 999);
    }
    return arr;
}

int FindArray(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 1 | arr[i] % 2 == -1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
    
}

int[] arr = InitArray(123);
int sum = FindArray(arr);
Console.WriteLine(string.Join(", ", arr));
Console.Write($"[{sum}]");