// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите размер массива X*Y*Z: ");
Console.WriteLine("Введите X: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = int.Parse(Console.ReadLine());
// формируем трехмерный массив

int [,,] array = GetArray (x,y,z); 
PrintArray(array);
Console.WriteLine();



int [ , , ] GetArray (int x, int y, int z) //получение трехмерного массива случайных целых чисел
{
    int [, ,] result = new int [x,y,z];
    for (int i = 0; i< x; i++)
    {
        for (int j = 0; j< y; j++)
        {
            for (int k = 0; k< z; k++)
            {
            result [i,j,k] = new Random().Next(10,100);
            }
        }
    }
    return result;
}

void PrintArray(int [,,] inArray) //вывод массива с индексом элемента
{
    for (int i = 0; i< inArray.GetLength(0); i++)
    {
        for (int j = 0; j< inArray.GetLength(1); j++)
        {for (int k = 0; k< inArray.GetLength(2); k++)
                {
                    Console.Write($"{inArray[i,j,k]} ");
                    Console.Write($"({i}, {j}, {k}) ");
                }
        Console.WriteLine();
    }
    }
}
