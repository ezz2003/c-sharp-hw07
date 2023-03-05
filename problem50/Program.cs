// Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// 
// Например, задан массив:
// 
// 1 4 7 2
// 
// 5 9 2 3
// 
// 8 4 2 4
// 
// 1, 7->такого элемента в массиве нет

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

string SearchElement(int[,] matrix, int row, int column)
{
  if (row >= matrix.GetLength(0) |
      column >= matrix.GetLength(1) |
      row < 0 | column < 0)
  { return "Такого элемента в массиве нет"; }
  return $"{matrix[row, column]}";
}

int rowsMatrix = 7;
int columnsMatrix = 12;
int[,] readyMatrix = MakeMatrixIntRnd(rowsMatrix, columnsMatrix, -99, 100);
PrintMatrix(readyMatrix);
Console.WriteLine("Будет выведено значение элемента матрицы по номеру строки и номеру столбца");
int rowToCheck = InputInt("Введите номер строки в матрице");
int columnToCheck = InputInt("Введите номер столбца в матрице");
Console.WriteLine(SearchElement(readyMatrix, rowToCheck, columnToCheck));

