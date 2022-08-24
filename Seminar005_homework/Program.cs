//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

// int [] array = GetArray (10);
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine($"Количество четных чисел в массиве {EvenNumber(array)}");

// int [] GetArray (int size)
// {
//     int [] arr = new int [size];
//     {
//         for (int i = 0; i < size; i ++)
//         {
//             arr[i] = new Random().Next(100, 1000);
//         }
//     }
//     return arr;
// }

// int EvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i<array.Length; i++ )
//     {
//     if (array[i] % 2 == 0)
    
//       count++;
    
//   }
//   return count;
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = GetArray (6);
// Console.WriteLine(string.Join(", ", array));

// int [] GetArray (int count)
// {  int [] arr = new int [count];
//     for (int i = 0; i < count; i++)
//     {
//         arr [i] = new Random().Next(-100, 100);
//     }
//     return arr;
// }

// Console.WriteLine($"Сумма элементов чисел на нечетных позициях {SumNegativeElement(array)}");
// int SumNegativeElement (int [] array)
// {
//     int sumnumbers = 0;
//     for (int i = 1; i< array.Length; i+=2)
//     { 
//                {
//             sumnumbers+= array[i];
//                     }
//     }
// return sumnumbers;

// }

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] array = GetArray (3);
Console.WriteLine ($"Массив вещественных чисел {String.Join(", ", array)} ");
Console.WriteLine ($"Разница между максимальным и минимальным элементов массива {DifferenceMaxMin(array)} ");
double [] GetArray (int count)
{
    double [] array = new double [count];
    for (int i = 0; i < count ; i++)
    {
        array[i]=new Random ().NextDouble ();
    }
    return array ;
}

double DifferenceMaxMin (double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < array.Length ; i++)
    {
    if (arr[i]> min) max = arr[i];
    if (arr[i]< max) min = arr[i];
    }
    return max-min;
}