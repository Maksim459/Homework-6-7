using System;
using System.Linq;

public class ArrayManipulator
{
    public string[] AddValueToArray(string[] originalArray, string newValue)
    {
        // Проверка на null
        if (originalArray == null || newValue == null)
        {
            return null;
        }

        // Проверка наличия места в массиве
        if (!originalArray.Contains(null))
        {
            // Создаем новый массив большей длины
            string[] newArray = new string[originalArray.Length + 1];
            Array.Copy(originalArray, newArray, originalArray.Length);
            originalArray = newArray;
        }

        // Проверка наличия значения в массиве (без учета регистра)
        if (originalArray.Any(item => item?.Equals(newValue, StringComparison.OrdinalIgnoreCase) == true))
        {
            return originalArray;
        }

        // Добавляем новое значение
        int index = Array.IndexOf(originalArray, null);
        originalArray[index] = newValue;

        return originalArray;
    }
}
