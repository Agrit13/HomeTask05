//  Задайте двумерный массив. 
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

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

void SwapRows(int[,] array)
{
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        if (numRows >= 2)
        {
            int[] tempRow = new int[numCols];
            for (int col = 0; col < numCols; col++)
            {
                tempRow[col] = array[0, col];
            }
            for (int col = 0; col < numCols; col++)
            {
                array[0, col] = array[numRows - 1, col];
            }

            for (int col = 0; col < numCols; col++)
            {
                array[numRows - 1, col] = tempRow[col];
            }
        }

}

int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,]matrix =  GenerateMatrix(rows, cols, 1, 100);
PrintMatrix(matrix);
SwapRows(matrix);
Console.WriteLine("Массив после замены первой и последней строк:");
PrintMatrix(matrix);



