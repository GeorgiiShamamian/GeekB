﻿// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

double[,] GetArray(int m, int n, int minValue, int maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void WriteArrayToConsole(double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            System.Console.Write($"{doubleArray[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

double[,] GetMultArray(double[,] firstArray, double[,] secondArray)
{
    double[,] resultArray = new double [firstArray.GetLength(0), secondArray.GetLength(1)];
    for (int i = 0; i < firstArray.GetLength(0); i++)
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray.GetLength(1); k++)
            {
                resultArray [i, j] += firstArray [i, k] * secondArray [k, j];
            }
            resultArray [i, j] = Math.Round(resultArray[i, j], 2);
        }
    return resultArray;
}

int rows1 = 3;
int columns1 = 5;
int rows2 = columns1;
int columns2 = 3;
double[,] Array1 = GetArray(rows1, columns1, -10, 10);
double[,] Array2 = GetArray(rows2, columns2, -10, 10);
double[,] result = GetMultArray(Array1, Array2);
System.Console.WriteLine("Массив 1 > ");
WriteArrayToConsole(Array1);
System.Console.WriteLine($"\nМассив 2 > ");
WriteArrayToConsole(Array2);
System.Console.WriteLine($"\nПроизведение массивов > ");
WriteArrayToConsole(result);