// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите b1");
double b1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите k1");
double k1= int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2= int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2= int.Parse(Console.ReadLine());
double x =(b2-b1)/(k1-k2);
double y =k1*x+b1;
Console.WriteLine($"[{x};{y}]");


// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите числа M: ");
// string numbers = Console.ReadLine();
// int [] array = numbers.Split(',').Select(int.Parse).ToArray();

// Console.WriteLine($"Массив :[{string.Join(",", array)}] -  чисел больше 0 -> {Positive(array)}");


// int Positive(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i<array.Length; i++ )
//     {
//     if (array[i] > 0)  count+=1;
//   }
//   return count;
// }