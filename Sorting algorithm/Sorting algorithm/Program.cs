using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        int n = int.Parse(Console.ReadLine());

        int[] B = new int[n];

        Console.WriteLine("Введите элементы массива (упорядоченные по невозрастанию):");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Элемент {i + 1}: ");
            B[i] = int.Parse(Console.ReadLine());
        }


        int[] A = GetUniqueSortedArray(B);


        Console.WriteLine("Преобразованный массив A (по возрастанию):");
        foreach (var item in A)
        {
            Console.Write(item + " ");
        }
    }

    static int[] GetUniqueSortedArray(int[] input)
    {

        int[] uniqueElements = new int[input.Length];
        int uniqueCount = 0;

        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0 || input[i] != input[i - 1]) 
            {
                uniqueElements[uniqueCount] = input[i];
                uniqueCount++;
            }
        }


        int[] result = new int[uniqueCount];
        Array.Copy(uniqueElements, result, uniqueCount);

        BubbleSort(result);

        return result;
    }

    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1]) 
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}
