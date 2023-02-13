/*Задача 38: Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] InitArray(int dimension)
{
    int[] array = new int[dimension];
    Random number = new Random();
    for (int i = 0; i < dimension; i++)
    {
        array[i] = number.Next(1, 99);
    }
    return array;
}

int FindMax(int[] array)
{
  int max = 0;
  for(int i = 0; i < array.Length; i++)
  {
     if(array[i] > max)
    {
      max = array[i];
    }
   }
  return max;
}

int FindMin(int[] array)
{
  int min = array[0];
  for(int i = 0; i < array.Length; i++)
  {
     if(array[i] < min)
    {
      min = array[i];
    }
   }
  return min;
}

int[] a = InitArray(3);
int max = FindMax(a);
int min = FindMin(a);

Console.WriteLine(string.Join(", ", a));
Console.WriteLine($"Максимальный элемент массива = {max}, минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max - min}");