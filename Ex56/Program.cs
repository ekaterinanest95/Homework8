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

void FindMinSumOfRows (int [,] array, int[] resultArray)
{
    
    int minSum = int.MaxValue;
    int minRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfRow = sumOfRow + array[i, j];
            
        }
        resultArray[i] = sumOfRow;
        if(minSum > sumOfRow) 
        {
            minSum = sumOfRow;
            minRow=i+1;
        }
    }

    Console.WriteLine("минимальная сумма строки: " + $"{minSum}");
    Console.WriteLine("строка, содержащая минимальную сумму: " + $"{minRow}");

}

void ToShowArray(int[] ar)
{
    for(int l=0; l<ar.Length-1 ;l++)
{
    Console.Write($"{ar[l]}" + "; ");
}
Console.Write($"{ar[ar.Length-1]}" + ". ");
}

int rows = 3;
int columns = 4;
int[] resultArray = new int [3];
int[,] matrix = GetArray(rows, columns);
PrintArray(matrix);
Console.WriteLine("Результат: ");
FindMinSumOfRows(matrix, resultArray);
ToShowArray(resultArray);


