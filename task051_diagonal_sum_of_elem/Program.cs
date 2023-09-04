// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //0 соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 соответствует столбцам
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
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i, j], 5}"); //5 это длина строки вместе с выводимым числом
        }
        Console.WriteLine("|");
    }
}

int SumMainElemMatrix(int[,] matrix)
{
    int sum = 0;
    //int minSize = matrix.GetLength(0) < matrix.GetLength(1) ? matrix.GetLength(0) : matrix.GetLength(1);
    //for (int i = 0; i < minSize; i++)
    //альтернативное решение
    for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] array2d = CreateMatrixRndInt(7, 3, 1, 5);
PrintMatrix(array2d);
Console.WriteLine("******************");
int result = SumMainElemMatrix(array2d);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {result}");
