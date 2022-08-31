// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите количество столбцов: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк:");
int cols = int.Parse(Console.ReadLine());
double [,] array = GetArray(rows, cols, -99, 99);
PrintArray(array);
double [,] GetArray (int m , int  n, int minValue, int maxValue)
{
    double [,] array = new double [m,n];
    for (int i=0; i < m; i++)
    {
        for (int  j=0; j < n; j++)
        {
           array [ i,  j]=new Random().NextDouble()*(maxValue - minValue) + minValue    ;
        }
    }
return array;
}
 void PrintArray (double [,] array)
{
  for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
    
            {
                Console.Write($"{array[i,j]:f2} ");
            }
            Console.WriteLine();
    }
}
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] array = GetArray (3, 4, 10, 20);
// PrintArray(array);
// int [,] GetArray (int n, int m, int minValue, int maxValue)
// { 
// int [,] array = new int [m,n];
// {
// for (int i =0; i<m; i++)
// {
//     for (int j=0; j<n; j++)
//     {
//         array[i,j]=new Random().Next(minValue, maxValue);
//     }
// } 
// return array;
// }
// }
// void PrintArray(int [,] array)
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {
            
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите позицию элемента: ");
// int position = int.Parse(Console.ReadLine());
// if(position <= array.GetLength(0)*array.GetLength(1))
//     {         Console.WriteLine($"Позиция {position} - есть в двумерном массиве");
                    
//     }
//     else
//     {
//         Console.WriteLine($"Позиции {position} - нет в массиве");
//     }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// int [,] array = GetArray (3, 4, 1, 10);
// PrintArray(array);
// GetAverage(array);
// int [,] GetArray (int rows, int cols, int minValue, int maxValue) //создание массива
// {   int [,] array = new int [rows,cols];
//     for (int i=0; i < rows; i++)
//     {
//         for (int j =0; j <cols; j++)
//         {
//             array [i,j]= new Random().Next(minValue, maxValue);
//         }
//     }
//     return array;
// }
// void PrintArray(int [,] array) //вывод на печать
// {
//     for(int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(1); j++)
//         {

//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void GetAverage(int[,] array) //нахождение среднего арифметического
// {   for (int i = 0; i < array.GetLength(1); i++)
//     {double sum = 0;
//     for (int j = 0; j < array.GetLength(0); j++)
//                 {
//                     sum+=array[j,i];   }   
//                 Console.WriteLine($"Сумма чисел столбца {i+1} равна {sum} среднее арифметическое -> {sum/array.GetLength(0):f2}");
//              }
//     }
  
