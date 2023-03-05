﻿// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// 
// m = 3, n = 4.
// 
// 0,5 7 -2 -0,2
// 
// 1 -3,3 8 -9,9
// 
// 8 7,8 -7,1 9
// 

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

double[,] MakeMatrixIntDouble(int rows, int columns, int min, int max)
{
  double[,] matrix = new double[rows, columns];
  Random rnd = new Random();
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
  }

  return matrix;
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write($"{matrix[i, j],7}");
    }
    Console.WriteLine();
  }
}

int rowsMatrix = InputInt("Введите количество строк в матрице");
int columnsMatrix = InputInt("Введите количество столбцов в матрице");
double[,] readyMatrix = MakeMatrixIntDouble(rowsMatrix, columnsMatrix, -99, 100);
PrintMatrix(readyMatrix);
