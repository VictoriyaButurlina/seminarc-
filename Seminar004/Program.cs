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


//Задача напишите программу кот-я выводит массив из 8 элементов случайные числа , заполненный нулями и единицами в случайном порядке. [0,1,0,1,0,1,1,1]
int [] array = GetBinaryArray (8);
int [] GetBinaryArray(int size); // функция принимает размер массива
{
    int[] arr = new int [size];
    //int i = new Random().Next(2);//вывод рандомного числа, 2 = ограничение, то есть будет выводиться либо 0 либо 1
    for (int i = 0; i < size; i++)
    {
        arr[i]= new Random().Next(2)   
         }
    return [arr] ;
}
}
Console.WriteLine($"{GetBinaryArray(size)}");