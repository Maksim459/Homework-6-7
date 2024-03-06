using System;

class Program
{
    static void Main()
    {
        
        int[,] array1 = { { 1, 1 }, { 1, 1 } };
        int[,] array2 = { { 2, 3 }, { 4, 5 } };

      
        int[,] result = AddArrays(array1, array2);

        
        Console.WriteLine("Результат сложения:");
        PrintArray(result);
    }

   
    static int[,] AddArrays(int[,] arr1, int[,] arr2)
    {
        int rows = arr1.GetLength(0);
        int cols = arr1.GetLength(1);

        int[,] result = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = arr1[i, j] + arr2[i, j];
            }
        }

        return result;
    }

    
    static void PrintArray(int[,] arr)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
