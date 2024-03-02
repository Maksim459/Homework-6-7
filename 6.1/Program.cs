using System;
using System.ComponentModel;
using System.Text;

namespace H
{
    internal class Program
    {
        public static string[] AddValueToArray(string[] array, string value)
        {
            bool bisAdd = false;
            if (array == null || string.IsNullOrEmpty(value))
            {
                return array;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != null)
                {
                    if (array[i].ToUpper() == value.ToUpper())
                    {
                        return array;
                    }
                }

            }

            foreach (string S in array)
            {
                if (S != null)
                {
                    if (S.ToUpper() == value.ToUpper())
                    {
                        return array;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (string.IsNullOrEmpty(array[i]))
                {
                    array[i] = value;
                    bisAdd = true;
                    return array;
                }
            }


            if (!bisAdd)
            {
                Array.Resize(ref array, array.Length + 1);
                array[array.Length - 1] = value;
            }
            return array;
        }
        static void Main(string[] args)
        {
            string[] array = { "a", "b", "c" };

            array = AddValueToArray(array, "");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(array.Length);
            Console.ReadLine();



        }


    }
}