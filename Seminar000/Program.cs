// int  i = 0;
// while (i <10)
// {
//     i += 2;
//     Console.WriteLine(i);

// }

// Console.WriteLine("Введите число");  Первая задача на поиск квадрата из числа
// int number = int.Parse(Console.ReadLine());
// int sqr = number*number;
// // Console.Write(sqr); первый вариант написание
// Console.WriteLine($"Квадрат числа {number} равен = {sqr}");

// sqr = Convert.ToInt32(Math.Pow(number, 2));
// Console.Write($"Квадрат числа {number} равен = {sqr}");


//Задача 2
//Программа принимает на ввод 2 числа и проверяет, является ли первое число квадратом 2
// Console.WriteLine("Введите первое число "); 
// int number1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите второе число ");
// int number2 = int.Parse(Console.ReadLine());
// if (number1 == Convert.ToInt32(Math.Pow(number2, 2)))
// {
//     Console.Write ($"{number1} квадрат числа {number2}");
// }
// else
// {
//     Console.Write($"{number1} не является квадратом числа {number2}");
// }

// Задача 3
// Console.WriteLine("Введите число 3 или 5 "); Название дня недели по заданному номеру
// int number = int.Parse(Console.ReadLine());
// if (number == 3)
// {
//     Console.WriteLine ("Среда");
// }
// if (number == 5)
// {
//     Console.WriteLine ("Пятница");
// }

// Задача 4
// Программа на вход число N, на выходе все целые числа от -N до N  
// Console.WriteLine("Введите число ");
// int number = int.Parse(Console.ReadLine());
// int number1 =-number;
// Console.WriteLine();
// while (number1 <= number)
// {
//     Console.WriteLine (number1);
//     number1++;
// }

//Задача 5 - вывести последнюю цифру из трехзначного числа
Console.WriteLine("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());
int result = number % 10;
Console.WriteLine (result);