// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] tempMatrix =new int [row, col];
    Random rand = new Random();

    for (int i = 0; i < tempMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        {
            tempMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return tempMatrix;
}

void PrintMatrix(int[,] matrixforPrint)
{
 for (int i = 0; i < matrixforPrint.GetLength(0); i++)
{
    for (int j =0; j < matrixforPrint.GetLength(1); j++)
    {
        System.Console.Write(matrixforPrint[i, j] + "\t");
     }
     System.Console.WriteLine();
}
}

int Position(int[,] array, int row, int col)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            return array[row, col];
        }
        else
        {
            return int.MinValue;
        }
    }

int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,]matrix =  GenerateMatrix(rows, cols, 1, 100);
PrintMatrix(matrix);
int Rows = ReadInt("Введите номер строки элемента в массиве: ");
int Cols = ReadInt("Введите номер столбца элемента в массиве: ");
int result = Position(matrix, Rows, Cols);
if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента на позиции ({Rows}, {Cols}): {result}");
        }
        else
        {
            Console.WriteLine($"Элемента на позиции ({Rows}, {Cols}) не существует.");
        }