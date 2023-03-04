// 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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

void SquaresForEvenIndexes (int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i+=2)
    {
        for (int j = 0; j < matr.GetLength(1); j+=2)
        {
            matr[i, j] *= matr[i, j];
        }
    }
    // return matr;
}

int rowsMatrix = InputInt("Введите количество строк в матрице");
int columnsMatrix = InputInt("Введите количество столбцов в матрице");
Console.Clear();
int[,] readyMatrix = MakeMatrixIntRnd(rowsMatrix, columnsMatrix, -9, -1);
PrintMatrix(readyMatrix);
Console.WriteLine("-------------------------------");
SquaresForEvenIndexes(readyMatrix);
PrintMatrix(readyMatrix);
