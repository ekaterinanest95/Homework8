int rows = 3;
int columns = 4;


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(11);
        }

    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void RewriteRows (int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1)-1; j++)
        {
            int maxRows = i;
            int maxColumns = j;
            for (int k = j + 1; k < inputMatrix.GetLength(1); k++)
            {
               if (inputMatrix[maxRows, maxColumns] < inputMatrix[i, k]) 
               {
                  maxRows = i;
                  maxColumns = k;
               }
            }
            int temp = inputMatrix[i, j];
            inputMatrix[i, j] = inputMatrix[maxRows, maxColumns];
            inputMatrix[maxRows, maxColumns] = temp; 

        }
    }
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Результат: ");
RewriteRows(resultMatrix);
PrintArray(resultMatrix);


