// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int [,] array = GetArray (3, 4, 1, 10);
PrintArray(array);
  
int [,] GetArray (int rows, int cols, int minValue, int maxValue) //создание массива
{   int [,] array = new int [rows,cols];
    for (int i=0; i < rows; i++)
    {
        for (int j =0; j <cols; j++)
        {
            array [i,j]= new Random().Next(minValue, maxValue);
        }
    }
    return array;
}
void PrintArray(int [,] array) //вывод на печать
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); j++)
        {

            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}


int SumLineElements(int[,] array, int i) // сумма элементов в каждой строке
{
  int sum = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sum += array[i,j];
    
  } Console.WriteLine($"Сумма чисел строки {i+1} равна {sum} ");
  return sum;
}
int minSum = 0; //поиск строки с наименьшей суммой
int sum = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
  int sumLine = SumLineElements(array, i);
  if (sum > sumLine)
  {
    sum = sumLine;
    minSum = i; 
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой элементов");