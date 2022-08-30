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

int[,] array = GetArray(rows, columns);
PrintArray(array);

//int FindMinSumOfRow (int [,] array)
//{
    int sumOfRow = 0;
    int minSum = int.MaxValue;
    int numberOfRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRow = sumOfRow + array[i, j];
            
        }
        Console.WriteLine(sumOfRow);
        if(minSum > sumOfRow) 
        {
            minSum = sumOfRow;
            Console.WriteLine(minSum);
        }
        numberOfRow ++;
    }
    //return minSum;
    Console.WriteLine(minSum);

//}

//int[,] matrix = GetArray(rows, columns);
//PrintArray(matrix);
//Console.WriteLine("Результат: ");
//Console.Write($"{FindMinSumOfRow(matrix)}");

