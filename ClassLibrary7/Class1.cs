using System;

namespace ClassLibrary7
{
    public class ArrayOperations
    {
        
        public int[] ReverseArray(int[] array)
        {
            int length = array.Length;
            int[] reversedArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                reversedArray[i] = array[length - 1 - i];
            }

            return reversedArray;
        }
    }
}
