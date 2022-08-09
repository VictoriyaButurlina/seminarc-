//задача рандомный вывод трехзначного числа и удаление второго числа

// int num = new Random().Next(100, 1000);
// int a1 = num /100;
// int a2 = num % 10;
// Console.WriteLine($"Число {num}");
// Console.WriteLine($"Число {a1}");
// Console.WriteLine($"Число {a2}");
// int result = a1*10+a2;
// Console.WriteLine($"Число {result}");

//Задача кратно второе число первому или нет, если не кратно вывести остаток
// int num1 = new Random().Next(100, 1000);
// int num2 = new Random().Next(100, 1000);

// Console.WriteLine($"Число первое {num1}");
// Console.WriteLine($"Число второе {num2}");

// if (num2 % num1 ==0)
// {
//     Console.WriteLine($"Число {num2} кратно числу {num1}");
// }
// else
// {
//     Console.WriteLine($"Число {num2} не кратно числу {num1}");
//     int ostatok = num2%num1;
//     Console.WriteLine($"Остаток {ostatok}");
    
// }

//Задача ввести число, которе кратно и 7 и 23

// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number%7==0 && number%23==0)
// {
// Console.WriteLine("Число кратно");
// }
// else{
//     Console.WriteLine("Число некратно");
// }

// //Задача является ли число квадратом другого числа
// Console.Write("Введите первое число: ");
// int number = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int number1 = int.Parse(Console.ReadLine());
// // if (number==number1*number1)
// if (number == (int)Math.Pow(number1, 2))
// {
// Console.WriteLine($"Число {number} является квадратом {number1}");
// return;
// }
// if (Math.Pow(number, 2)== number1)
// {
//     Console.WriteLine($"Число {number1} является квадратом {number}");
// }
// else
// {
//     Console.WriteLine($"Число {number} не является квадратом {number1}");
// }


// ДЗ
// Задача 1
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
// Console.Clear();
// Console.Write("Введите трехзначное число: ");
// int number = int.Parse(Console.ReadLine());
// int number1=(number/10)%10;
// Console.WriteLine($"Вторая цифра числа {number} - {number1}");

// ДЗ
// Задача 2
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите любое число: ");
int number = int.Parse(Console.ReadLine());
if (number/100>=1)
{
    Console.WriteLine($"Третья цифра числа {number} - > {number.ToString()[2]}");
    return;
}
Console.Write("Третьей цифры нет");

// ДЗ
// Задача 3
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// Console.Write("Введите цифру от 1 до 7: ");
// int number = int.Parse(Console.ReadLine());
// if (number==6 || number==7)
// {
//     Console.WriteLine("Выходной");
//     }
// else
// {
//     Console.WriteLine("Будни");
// }