// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количетсво cтолбцов массива: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"\nВывод массива: ");
int [,] array = GetArray (m, n, 0, 100); 
PrintArray(array);

Console.WriteLine($"\nОтсортированный массив по убыванию элементов в строках: ");
SotrArray(array);
PrintArray(array);

int [,] GetArray (int m, int n, int minValue, int maxValue) //получение массива случайных целых чисел
{
    int [,] result = new int [m,n];
    for (int i = 0; i< m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            result [i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int [,] inArray) //вывод массива
{
    for (int i = 0; i< inArray.GetLength(0); i++)
    {
        for (int j = 0; j< inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

 void SotrArray(int[,] array) // вывод элементов массива в строках по убыванию
 {
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int result = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = result;
        }
      }
    }
  }
  return;
}