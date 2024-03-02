using System;
using ClassLibrary7;
class Program
{
    static void Main()
    {
       
        ClassLibrary7.ArrayOperations arrayOps = new ClassLibrary7.ArrayOperations();

        int[] inputArray = { 1, 2, 3, 4, 5 };

        int[] reversedArray = arrayOps.ReverseArray(inputArray);
      
        Console.WriteLine("Исходный массив:");
        PrintArray(inputArray);

        Console.WriteLine("Инвертированный массив:");
        PrintArray(reversedArray);
    }

    static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }
}
