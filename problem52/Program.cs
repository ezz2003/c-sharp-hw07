﻿// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// 
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int[,] MakeMatrixIntRnd(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = rnd.Next(min, max + 1);
    }
  }
  return matrix;
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
      Console.Write($"{matrix[i, j],4},");
    }
    Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1],4}");
  }
}

double[] ArithmeticMeanColumns(int[,] matrix) // считает по колонкам ср. арифм. 
{
  double[] arrArithmMean = new double[matrix.GetLength(1)];
  for (int j = 0; j < matrix.GetLength(1); j++)
  {
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      sum += matrix[i, j];
    }
    arrArithmMean[j] = Math.Round(sum / matrix.GetLength(0), 1);
  }
  return arrArithmMean;
}

string MakeStrPrintArr(double[] arr) // готовит строку для печати 1D
{
  string strPrn = string.Empty;
  for (int i = 0; i < arr.Length; i++) strPrn += $"{arr[i],4} ";
  return strPrn;
}

int rowsMatrix = InputInt("Введите количество строк в матрице");
int columnsMatrix = InputInt("Введите количество столбцов в матрице");
int[,] readyMatrix = MakeMatrixIntRnd(rowsMatrix, columnsMatrix, 1, 10);
PrintMatrix(readyMatrix);
Console.WriteLine($"Среднее арифметическое матрицы по столбцам: {MakeStrPrintArr(ArithmeticMeanColumns(readyMatrix))}");

