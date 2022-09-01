//Задача 53. поменять местами первую и последнюю строки массива
Console.WriteLine("Введите количество строк массива: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количетсво толбцов массива: ");
int m = int.Parse(Console.ReadLine());

int [,] array = GetArray (m, n, 0, 100); 
PrintArray(array);
Console.WriteLine("Меняем местами первую и последнюю строки массива");
ChangeRows(array);
PrintArray(array);

int [,] GetArray (int m, int n, int minValue, int maxValue) //получение массива случайных целых чисел
{
    int [,] result = new int [m,n];
    for (int i = 0; i< m; i++)
    {
        for (int j = 0; j< n; j++)
        {
            result [i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int [,] inArray) //вывод массива
{
    for (int i = 0; i< inArray.GetLength(0); i++)
    {
        for (int j = 0; j< inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ChangeRows(int [,] inArray)  //меняет местами первую и последнюю строку массива
{
    int rowCount = inArray.GetLength(0)-1;    //последняя строка
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        int k = inArray[0,i];
        inArray[0, i]= inArray[rowCount, i];
        inArray[rowCount, i] = k;
    }
}