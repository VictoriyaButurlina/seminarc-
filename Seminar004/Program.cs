//Задача сумма всех чисел, например 47 - 4+7 =11, 123 - 1+2+3 = 6

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(GetSum(num));
// int GetSum(int number)
// {
//     int sum = 0;
//     while (number >0)
//     {
//         sum += number %10;
//         number/=10;

//     }
//     return sum;
// }

//напишите программу которая принимает число и выдает количество цифр в числе

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine(GetCount(num));

// int GetCount(int number)
// {
//     int count =0;
//     while (number > 0 )
//     {
//         count++;
//         number/=10;
//     }
//     return count;
// }

//Напишите программу, которая принимает число N и выдает произведение чисел от 1 до N

// int GetMultyplay(int number)
// {
//     int result =1;
//     for(int i= 1; i<=number; i++)
//     {
//         result*=i;
//     }
//     return result;
// }
// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());

// Console.WriteLine($"Произведение цифр = {GetMultyplay(num)}");


// //Задача напишите программу кот-я выводит массив из 8 элементов случайные числа , заполненный нулями и единицами в случайном порядке. [0,1,0,1,0,1,1,1]
// int [] array = GetBinaryArray (8);
// int [] GetBinaryArray(int size); // функция принимает размер массива
// {
//     int[] arr = new int [size];
//     //int i = new Random().Next(2);//вывод рандомного числа, 2 = ограничение, то есть будет выводиться либо 0 либо 1
//     for (int i = 0; i < size; i++)
//     {
//         arr[i]= new Random().Next(2);
//          }
//     return (arr[]);
// }
// Console.WriteLine($"{GetBinaryArray(size)}");


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine(GetStepen(number1, number2));
int GetStepen(int a, int b)
{
    int result = a;
    for(int i = 1; i < b; i++)
    {
        result *=a;
    }
    return result;
}



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// Console.WriteLine(GetSum(number));
// int GetSum (int a)
// {
//     int sum = 0;
//     while (a > 0)
//     {
//         sum+= a%10;
//         a /= 10;
//     }
//     return sum;
// }


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int [] array = GetBinaryArray (8);
// Console.WriteLine("Массив из 8 элементов: ");
// Console.WriteLine($"[{string.Join(",", array)}]");
// int [] GetBinaryArray(int size)
// {
//     int[] arr = new int [size];
    
//     for (int i = 0; i < size; i++)
//     {
//         arr[i]= new Random().Next(1000);
//          }
//     return arr;
// }