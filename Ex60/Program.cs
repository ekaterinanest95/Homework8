
int[,,] GetArray(int m, int n, int l)
{
    int[,,] array = new int[m, n, l];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(10, 100);
            }
            
        }

    }
    return array;
}

void PrintArray(int[,,] matrix)
{
    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
            Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
}

int [,,] array3D = GetArray(2, 2, 2);
Console.WriteLine("Массив с координатами: ");
PrintArray(array3D);




