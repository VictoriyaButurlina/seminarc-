// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// A(m,n)=n+1, при m=0,
// A(m,n)=A(m−1,1), при m>0, n=0,
// A(m,n)=A(m−1,A(m,n−1)), при m>0, n>0

Console.Clear();
Console.WriteLine("Введите M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите N: ");
int n = int.Parse(Console.ReadLine());
Console.Write($"A({m},{n}) равно {Result(m,n)}");
int Result (int m, int n)
{ 
     if (m == 0) return n+1;
        else if ((m>0) && (n==0)) return Result(m-1,1);
        else if ((m>0) && (n>0)) return Result(m-1,Result(m,n-1));
    return n+1;
}