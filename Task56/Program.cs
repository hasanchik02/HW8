// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] GetRandomMatrix (int rows, int columns, int leftRange, int rightRange)
{
    int [,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void SumRows (int [,] matrix)
{
    int min = 0;
    int rows = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        min += matrix[0, i];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int res = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            res += matrix[i,j];
            if (res < min) 
            {
               min = res; 
               rows = i;
            }
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой {rows}");
}

void Printmatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 3;
const int COLUMNS = 4;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 10;

int [,] array = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Printmatrix(array);

Console.WriteLine();
SumRows(array);