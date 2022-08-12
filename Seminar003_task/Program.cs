// Writer("ВВедите X: ");
// int x = int.Parse(ReadLine());

// Writer("ВВедите Y: ");
// int y = int.Parse(ReadLine());

// if (x > 0 && y > 0)
//     WriteLine("1");
// if (x < 0 && y > 0)
//     WriteLine("2");
// if (x < 0 && y < 0)
//     WriteLine("3");
// if (x > 0 && y > 0)
//     WriteLine("4");

//задача 2
// Console.Clear();
// Console.Write("введите номер четверти:");
// int x = int.Parse(Console.ReadLine());

// switch (x)
// {
//     case (1):
//     {
//         Console.Write("x>0 и y>0");
//         break;
//     }
//     case (2):
//     {
//         Console.Write("x<0 и y>0");
//         break;
//     }
//     case (3):
//     {
//         Console.Write("x<0 и y<0");
//         break;
//     }
//     case (4):
//     {
//         Console.Write("x>0 и y<0");
//         break;
//     }
//     default:
//     {
//         Console.Write("введен не верный номер четверти");
//         break;
//     }
// }


// //Задача 3 - расстояние между точками
// Console.Clear();
// Console.Write("введите координаты точек: ");
// Console.Write("введите x1: ");
// int x1 = int.Parse(Console.ReadLine());

// Console.Write("введите y1:");
// int y1 = int.Parse(Console.ReadLine());

// Console.Write("введите x2:");
// int x2 = int.Parse(Console.ReadLine());

// Console.Write("введите y2:");
// int y2 = int.Parse(Console.ReadLine());

// double c = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1,2));
// Console.WriteLine($"c = {c:f3}");

// //Задача поиск квадрата всех чисел от числа . пример 3 -> 1,2,3
// Console.Clear();
// Console.Write("введите число N: ");
 
// int num = int.Parse(Console.ReadLine());
// int k = num;
// if (num < 0) k=-num;
// for (int i=1; i <= k; i++)
// {
//     Console.WriteLine($"i = {i} -> i*i = {i*i}");
// }




// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("ВВедите пятизначное число: ");
int n = int.Parse(Console.ReadLine());

int a1 = n / 10000; 
int a2 = (n /1000)%10;
int a4 = (n/10)%10;
int a5 = n%10;


    if (a1==a5 && a2==a4)
        {
            Console.WriteLine($"Число {n} является палиндромом");
        }
    else
        {
            Console.WriteLine($"Число {n} не является палиндромом");
        }




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.Clear();
// Console.WriteLine("Введите точки координат: ");
// Console.WriteLine("Введите x1");
// int x1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите y1");
// int y1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите z1");
// int z1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите x2");
// int x2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите y2");
// int y2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите z2");
// int z2 = int.Parse(Console.ReadLine());


// double a = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
// Console.WriteLine($"Расстояние между двумя точками координат - > {a:f2}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// Console.Clear();
// Console.WriteLine("Введите число N: ");
// int n = int.Parse(Console.ReadLine());
// for (int i=1;  i <= n; i++)
// {
//     Console.WriteLine($"i = {i} -> i*i*i = {i*i*i}");
// }

