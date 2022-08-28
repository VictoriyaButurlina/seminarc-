// Задача 46
//задайте двумерный массив заполнненый случайными числами m и n 


// Console.WriteLine("Введите количество строк массива ");
// int rows= int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов массива  ");
// int cols= int.Parse(Console.ReadLine());

// int [,] arr = GetArray(rows, cols, 100, 1000);
// PrintArray(arr);
// //1. Создание двумерного массива размера m на N 
// int [,] GetArray (int m , int n, int minValue, int maxValue)
// {
//     int [,] array = new int [m,n];
//     for (int i=0; i < m; i++)
//     {
//         for (int j=0; j < n; j++)
//         {
//             array [i, j] = new Random (). Next(minValue, maxValue);
//         }
//         Console.WriteLine();
//     }
// return array;
// }

// //2. Вывод на печать 
// void PrintArray (int [,] array)
// {
//   for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
    
//             {
//                 Console.Write($"{array[i,j]} ");
//             }
//             Console.WriteLine();
//     }
// }


//Задача
//1. Создание двумерного массива размера m на N . 
// 0 1 2 3 
// 1 2 3 4 
// 2 3 4 5
// int [,] arr = GetArray(3, 4, 1, 10);
// PrintArray(arr);
// int [,] GetArray (int m , int n, int minValue, int maxValue)
// {
//     int [,] array = new int [m,n];
//     for (int i=0; i < m; i++)
//     {
//         for (int j=0; j < n; j++)
//         {
//             array [i, j] = i+j;
//         }
//         Console.WriteLine();
//     }
// return array;
// }

// void PrintArray (int [,] array)
// {
//   for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
    
//             {
//                 Console.Write($"{array[i,j]} ");
//             }
//             Console.WriteLine();
//     }
// }

//Задача найдите элементы у которых оба индекса нечетные  и замените эти элементы на квадраты

// int [,] arr = GetArray(3, 4, 1, 10);
// PrintArray(arr);
// MakeArray(arr);
// Console.WriteLine();
// PrintArray(arr);
// int [,] GetArray (int m , int n, int minValue, int maxValue)
// {
//     int [,] array = new int [m,n];
//     for (int i=0; i < m; i++)
//     {
//         for (int j=0; j < n; j++)
//         {
//             array [i, j] = new Random (). Next(minValue, maxValue);
//         }
//         Console.WriteLine();
//     }
// return array;
// }

// //печать двумерного массива
// void PrintArray (int [,] array)
// {
//   for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
    
//             {
//                 Console.Write($"{array[i,j]} ");
//             }
//             Console.WriteLine();
//     }
// }


// //печать двумерного массива нового
// void MakeArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         { if (i%2==0 && j%2==0)
//             {
//                 array[i,j] *=array[i,j];
//             }
//         }
//     }
// }


// найдите сумму элементовнаходящихся по диагонали
// int [,] arr = GetArray(3, 4, 1, 10);
// PrintArray(arr);
// int sum = MakeArray(arr);
// Console.WriteLine($"Сумма элементов на главной диагонали {sum}");

// int [,] GetArray (int m , int n, int minValue, int maxValue)
// {
//     int [,] array = new int [m,n];
//     for (int i=0; i < m; i++)
//     {
//         for (int j=0; j < n; j++)
//         {
//             array [i, j] = new Random (). Next(minValue, maxValue);
//         }
//         Console.WriteLine();
//     }
// return array;
// }

// //печать двумерного массива
// void PrintArray (int [,] array)
// {
//   for (int i=0; i < array.GetLength(0); i++)
//     {
//         for (int j=0; j < array.GetLength(1); j++)
    
//             {
//                 Console.Write($"{array[i,j]} ");
//             }
//             Console.WriteLine();
//     }
// }


// //печать двумерного массива нового
// int MakeArray(int[,] array)
// { int sum =0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         { if (i==j)
//             {
//                 sum+=array[i,j];
//             }
//         }
//     }
//     return sum;
// }
