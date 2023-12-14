// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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

 int RowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        int minRow = 0;
        int minSum = RowSum(array, 0);

        for (int row = 1; row < numRows; row++)
        {
            int currentSum = RowSum(array, row);

            if (currentSum < minSum)
            {
                minSum = currentSum;
                minRow = row;
            }
        }

        return minRow;
    }

    int RowSum(int[,] array, int row)
    {
        int numCols = array.GetLength(1);
        int sum = 0;

        for (int col = 0; col < numCols; col++)
        {
            sum += array[row, col];
        }

        return sum;
    }


int rows = ReadInt("Введите количество строк массива: ");
int cols = ReadInt("Введите количество столбцов массива: ");
int[,]matrix =  GenerateMatrix(rows, cols, 1, 100);
PrintMatrix(matrix);
int minRow = RowWithMinSum(matrix);
Console.WriteLine($"Строка с индексом: {minRow}");




