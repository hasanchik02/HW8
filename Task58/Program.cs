// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// (допустимый вариант)
// 6 16
// 9 6

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

int [,] MultyM (int [,] matrix1, int [,] matrix2)
{
    int [,] result = new int [matrix1.GetLength(0),matrix1.GetLength(1)];
     for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        int multy = 0;
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            multy = matrix1[i,j] * matrix2[i,j];
            result [i,j] = multy;
        }
    }
    return result;
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

const int ROWS = 2;
const int COLUMNS = 2;
const int LEFTRANGE = 1;
const int RIGHTRANGE = 10;

int [,] array1 = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Printmatrix(array1);
Console.WriteLine();
int [,] array2 = GetRandomMatrix(ROWS, COLUMNS, LEFTRANGE, RIGHTRANGE);
Printmatrix(array2);
Console.WriteLine();
int [,] array3 = MultyM(array1,array2);
Printmatrix(array3);
