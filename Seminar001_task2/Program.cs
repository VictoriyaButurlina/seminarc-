﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Напишите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Напишите второе число: ");
int number2 = int.Parse(Console.ReadLine());

Console.Write("Напишите третье число: ");
int number3 = int.Parse(Console.ReadLine());

int max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.Write($"Максимальное число: {max}");
