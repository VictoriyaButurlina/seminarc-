
// Задача
// 1. Создайте массив из 12 элементов 
// 2. заполненный случайными числами из промежутка от -9 до 9
// 3. Найдите сумму отрицательных и положительных элементов
// Console.Clear();

// 1. Метод, который возвращает массив заполненный элементами из заданного промежутка

// int [] array = GetArray(12); - 1 вариант решения
// Console.WriteLine($"[{string.Join(",", array)}]");
// int [] GetArray(int size)
// {
//     int[] arr = new int [size];
    
//     for (int i = 0; i < size; i++)
//     {
//         arr[i]= new Random().Next(-9, 9);
//          }
//     return arr;
// }
// int [] array = GetArray (12, -9, 9); 
// Console.WriteLine($"[{string.Join(", ", array)}]");
// Console.WriteLine($"(Сумма положительных цифр = {GetPozitive(array)})");
// Console.WriteLine($"(Сумма отрицательных цифр = {GetNegative(array)})");
// int [] GetArray (int count, int minValue, int maxValue) // функция, кот возвращает массив целых чисел, в качестве входных параметров = count - кол-во элементов в массиве,
// диапазон чисел мин - minValue и макс maxValue
// {
//     int [] array = new int [count]; // создаем массив внутри метода GetArray
//     {
//          for (int i = 0; i < count; i++)
//          {
//             array[i] = new Random().Next (minValue, maxValue+1  ); // заполнение массива
//          }
//     }
//     return array ; // возвращаем значение из метода
// }


// 2. Метод, чтобы получить сумму отрицательных элементов массива

// int GetNegative (int [] arr)
// {
//     int sum = 0;
//     for (int i = 0; i < arr.Length ; i++ )
//     {if (arr[i]<0) // является ли элемент массива отрицательным числом
//         {
// //             sum+= arr[i];
// //         }

// //     }
// //     return sum;
// // }
// // 3. Метод, чтобы получить сумму положительных элементов массива
// // int GetPozitive (int [] arr)
// // {
// //     int sum = 0;
// //     for (int i = 0; i < arr.Length ; i++ )
// //     {if (arr[i]>0) // является ли элемент массива положительным числом
// //         {
// //             sum+= arr[i];
// //         }

// //     }
// //     return sum;
// // }

// //Задача 
// //Напишите программу замена элементов массива: положительные на отрицательные и наоборот


// int [] array = GetArray(10, -10, +10);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", GetChange(array)));
// int [] GetArray (int count, int minValue, int maxValue)
// {
//     int [] array = new int [count];
//     {
//         for (int i = 0; i < count; i ++)
//         {
//             array[i] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }
// int [] GetChange(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//         {
//             arr[i] *=-1;
//         }
//     return arr;
// }

// Задача
// Задайте массив, напишите программу которая определяет есть ли число в массиве
//  int [] array = GetArray(10, -10, +10);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Число {number} найдено? : {FindElement (number, array)}");
// //Console.WriteLine(string.Join(", ", GetChange(array)));
// int [] GetArray (int count, int minValue, int maxValue)
// {
//     int [] array = new int [count];
//     {
//         for (int i = 0; i < count; i ++)
//         {
//             array[i] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }
// bool FindElement(int number, int [] arr)

// {
//      for (int i = 0; i < arr.Length; i ++)
//      {
//         if (arr[i]== number) return true;
//      }
//     return false;
// }

// Задача
// задайте одномерный массив из 123 случайных чисел
// // Найдите кол-во элементовмассива, значения которых лежат в отрезке 10,99

//  int [] array = GetArray(123, 1, 100);

// Console.WriteLine(string.Join(", ", array));
// //Console.WriteLine($"Число меньше 99 и больше 10 {FindArray (array)}");
// //Console.WriteLine(string.Join(", ", FindArray(array)));

// int [] GetArray (int count, int minValue, int maxValue)
// {
//     int [] array = new int [count];
//     {
//         for (int i = 0; i < count; i ++)
//         {
//             array[i] = new Random().Next(minValue, maxValue +1);
//         }
//     }
//     return array;
// }


// double[] M = new double[50]; // заданный массив M
// int n=123; // текущая размерность массива n = 1..50
// double a = 10, b= 99; // сравниваемые значения
// int i; // дополнительная переменная
// int count; // результат

// // ввод A, n, a, b
// // ...

// // вычисление, реализация с помощью цикла for
// count=0;
// for (i=0; i<n; i++)
//     if ((M[i]>=a)&&(M[i]<=b))
//         count++;
 


