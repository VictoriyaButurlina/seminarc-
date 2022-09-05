//пример рекурсиии
// int i = 0;
// Factorial (4);

// int Factorial (int n)
// {
//     int result;
//     if (n==1)
//     {
//         result =1;
//         Console.WriteLine($"Шаг рекурсии {++i}, результат {result} базовый вариант ");
//         return result;
//     }
//     else
//     {
//         Console.WriteLine($"Шаг рекурсии {++i}");
//         result = n*Factorial(n-1);


//         Console.WriteLine($"Шаг рекурсии {++i}, результат {result}");
//         return result;
//     }

// }




//Задача 63 Задайте значение N НАпишите программу которая выведет все натуральные числа в промежутке от 1 до N
// Console.Clear();
// Console.WriteLine("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.Write(ToN(n));
// string ToN(int n)
// {
//     if (n ==1) return $"{n} ";
//     return ToN (n-1) + $"{n} ";
// }

// Задача 65 Задайте значениям N и M. Напишите программу, которая выведет все натуральные числа в промежутке от N до M

// Console.Clear();
// Console.WriteLine("Введите N: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write(ToN(n, m));
// string ToN(int n, int m)
// {
//     if (n==m) return $"{n}";
//     return $"{n} " + ToN(n + 1, m) ;
// }

//Задача 67 напишите программу, которая на вход принимает число и возвращает сумму его цифр.
// Console.Clear();
// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр: {SumDigits(number)}");

// int SumDigits(int number)
// {
// if (number < 1) return 0;
// int result = 0;
// return SumDigits(number / 10) + number % 10;
// }

// Задача  69 Напишите программу , которая на вход принимает два числа и возводит число А в степень Б с помощью рекурсии.
Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"Возвести число {numberA} в степень {numberB} = {DegreeOfNumber(numberA, numberB)}");

int DegreeOfNumber(int numberA, int numberB)
{
if (numberB < 1) return 1;
return numberA * (DegreeOfNumber(numberA, numberB - 1));
}