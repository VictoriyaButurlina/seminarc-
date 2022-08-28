// Задача
// Напишите программу кот-я принимает на вход 3 числа и проверяет может ли существовать треугольник такой длины

// Console.WriteLine("Введите первое число: ");
// int number1 = int.Parse (Console.ReadLine());
// Console.WriteLine("Введите второе число: ");
// int number2 = int.Parse (Console.ReadLine());
// Console.WriteLine("Введите третье число: ");
// int number3 = int.Parse (Console.ReadLine());


//     if (number1+number2 <= number3 || number1+number3 <= number2 || number2+number3 <= number1) 
//         Console.Write("Треугольник не существует.");
//     else
//         if (number1 != number2 && number1 != number3 && number2 != number3) 
//             Console.Write("Разносторонний");
//         else
//             if (number1 == number2 && number2 == number3)
//                 Console.Write("Равносторонний");
//             else
//                 Console.Write("Равнобедренный");



//Напишите программу кот-я будет преобразовать 10-е в двоичное число
// Console.WriteLine("Введите число: ");
// int a= int.Parse(Console.ReadLine());
// Console.WriteLine($"Десятичное {a} в двоичное -> {Convert.ToString(a,2)}");


// Задача
//Напишите программу кот-я перевернет одномерный массив (последний элемент будет на первом месте, первый на последнем  и т.д.)

// int [] array = GetArray (10, 0, 10);
// Console.WriteLine("Исходный массив");
// Console.WriteLine(String.Join(" ", array));
// Console.WriteLine();
// Console.WriteLine("Перевернутый массив");

// //1. первый алгоритм
// int [] reversArray = ReversArray2(array); 
// Console.WriteLine(String.Join(" ", reversArray));

// //2. второй алгоритм
// ReversArray1(array);
// Console.WriteLine(String.Join(" ", array));

// //метод который возвращает массив заполненный случайными числами из промежутка
// int [] GetArray (int count, int min, int max)
// {   int [] array = new int [count];
//     for (int i = 0; i < count; i ++)
//     {
//         array [i] = new Random().Next (min, max+1);
//     }
//     return array;
// }

// //Алгоритм первый копирование парных элементов
// void ReversArray1(int [] inArray)
// {
//     for (int i = 0; i< inArray.Length/2; i++)
//     {
//         int k = inArray[i]; //сохраняем текущий элемент
//         inArray[i]= inArray[inArray.Length-i-1];
//         inArray[inArray.Length-i-1]=  k;   
        
//       }

// }

// //второй алгоритм. Формирование нового массива, кот-й вернет перевернутый исходный массив
// int [] ReversArray2(int []inArray)
// {
//     int [] result = new int [inArray.Length];
//     for (int i = 0; i < inArray.Length; i++)
//     {
//         result [i] = inArray[inArray.Length-1-i];
//     }
//     return result;
// }


//Задача
//Не используя рекурсию выведите первые N чисел фибоначчи

Console.WriteLine("ВВедите число: ");
int number = int.Parse(Console.ReadLine());

int Fibonacci (int number)
{
    if (number==0)
}