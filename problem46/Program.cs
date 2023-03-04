// 46. Задайте двумерный массив размером M x N, заполненный случайными целыми числами

int InputInt(string message)
{
  Console.Write(message + ": ");
  return Convert.ToInt32(Console.ReadLine());
}

int[,] MakeMatrixIntRnd(int rows, int columns, int min, int max)
{
  int[,] matrix = new int[rows, columns];
  Random rnd = new Random();
  for (int i = 0; i < rows; i++)  // matrix.GetLength(0) 1 измерение(строки)
  {
    for (int j = 0; j < columns; j++) // matrix.GetLength(1) 2 измерение(столбцы)
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

int rowsMatrix = InputInt("Введите количество строк в матрице");
int columnsMatrix = InputInt("Введите количество столбцов в матрице");
int[,] readyMatrix = MakeMatrixIntRnd(rowsMatrix, columnsMatrix, -99, 100);
PrintMatrix(readyMatrix);
