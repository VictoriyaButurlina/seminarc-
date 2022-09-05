// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());

Console.Write($"Сумма чмсел от {n} до {m} равна {sum(n,m)}");

int sum (int n, int m)
{if (n == m) return n;
    return  n + (sum(n + 1, m));
}