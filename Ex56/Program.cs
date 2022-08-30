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
int[] resultArray = new int [3];

void FindMinSumOfRows (int [,] array, int[] resultArray)
{
    
    int minSum = int.MaxValue;
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
        }
    }

    Console.WriteLine(minSum);

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;

        }
        index++;
    }
    return position;

}

void ToShowArray(int[] ar)
{
    for(int l=0; l<ar.Length-1 ;l++)
{
    Console.Write($"{ar[l]}" + "; ");
}
Console.Write($"{ar[ar.Length-1]}" + ". ");
}

int[,] matrix = GetArray(rows, columns);
PrintArray(matrix);
Console.WriteLine("Результат: ");
FindMinSumOfRows(matrix, resultArray);
ToShowArray(resultArray);


