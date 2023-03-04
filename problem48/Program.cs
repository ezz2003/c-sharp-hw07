// 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn=m+n. Выведите полученный массив на экран.

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int[,] MakeMatrixSpecialFormula(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      matrix[i, j] = i + j;
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
      Console.Write($"{matrix[i, j],4}");
    }
    Console.WriteLine($"{matrix[i, matrix.GetLength(1) - 1],4}");
  }
}

int rowsMatrix = InputInt("Введите количество строк в матрице");
int columnsMatrix = InputInt("Введите количество столбцов в матрице");
int[,] readyMatrix = MakeMatrixSpecialFormula(rowsMatrix, columnsMatrix);
PrintMatrix(readyMatrix);
