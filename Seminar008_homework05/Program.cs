// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
int n =4;
int [,] result = new int [n,n];
int count = 1;
int i =0;
int j =0;
while (count<=result.GetLength(0)*result.GetLength(1))
          
{
  result[i, j] = count;
  count++;
  if (i <= j + 1 && i + j < result.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= result.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > result.GetLength(1) - 1)
    j--;
  else
    i--;
}

PrintArray(result);
    

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
