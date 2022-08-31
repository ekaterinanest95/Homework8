﻿int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
        }

    }
    return array;
}

void ProductOfArrays (int[,] ar1, int [,] ar2, int[,] resultArray)
{
    for (int i = 0; i < ar1.GetLength(0); i++)
    {

        for (int j = 0; j < ar1.GetLength(1); j++)
        {
            for(int k = 0; k < ar1.GetLength(1); k++)
            {
                resultArray[i,j]=resultArray[i,j]+(ar1[i,k]*ar2[k,j]);
            } 
        }
    }
} 

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int [,] array1 = GetArray(2, 2);
PrintArray(array1);
Console.WriteLine();
int [,] array2 = GetArray(2, 2);
PrintArray(array2);
Console.WriteLine("Результат: ");
int[,] resultArray = new int [2, 2];
ProductOfArrays (array1, array2, resultArray);
PrintArray(resultArray);





