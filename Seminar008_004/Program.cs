//Задайте двумерный массив из целых чисел. Напишите программу кот-я удалит строки столбец, на пересечении кот-х расположен наименьший элемент массива


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество колонок массива: ");
int cols = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(rows, cols, 0, 9);
PrintArray(array);
Console.WriteLine();

int [] minElement = GetMinElement(array);

int [,] newArray = GetResultArray(array, minElement);
PrintArray(newArray);
Console.WriteLine();



int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetMinElement(int[,] inArray)
{
    int[] result = new int[] { 0, 0 };
    int min = inArray[0, 0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > inArray[i, j]) ;
            {
                min = inArray[i, j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] GetResultArray(int[,] inArray, int[] indexes)
{
    int[,] result = new int[inArray.GetLength(0) - 1, inArray.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == indexes[0]) continue;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == indexes[1]) continue;
            result[i, j] = inArray[i, j];
        }
    }
    return result;
}