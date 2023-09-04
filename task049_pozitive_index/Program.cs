// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0)/*rows*/; i++) //0 соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1)/*columns*/; j++) // 1 соответствует столбцам
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}
/* 
//альтернативное решение ниже
void ReplacePozitiveMatrixElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) //0 соответствует строкам
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // 1 соответствует столбцам
        {
            if(i % 2 == 0 && j % 2 == 0) 
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}
*/

void ReplacePozitiveMatrixElem(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) //проходим только по чётным позициям
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) //проходим только по чётным позициям
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
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

int[,] array2d = CreateMatrixRndInt(3, 4, 1, 5);
PrintMatrix(array2d);
Console.WriteLine("**************");
ReplacePozitiveMatrixElem(array2d);
PrintMatrix(array2d);