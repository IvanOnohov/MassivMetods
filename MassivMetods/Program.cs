class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 2, 9, 1, 5, 6 };
        int[] array2 = { 5, 4, 6, 3, 2 };
        Console.WriteLine("Массив до сортировки:");
        PrintArray(array);

        SortArray(array);
        Console.WriteLine();
        Console.WriteLine("Отсортированный массив по возрастанию:");
        PrintArray(array);
        Console.WriteLine();
        SortArrayDescending(array);
        Console.WriteLine("Отсортированный массив по убыванию");
        PrintArray(array);
        Console.WriteLine();
        PrintArray(MergeArrays(array, array2));
    }

    static void SortArray(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Меняем местами элементы
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    static void SortArrayDescending(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] < array[j + 1])
                {
                    // Меняем местами элементы
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    static int[] MergeArrays(int[] a, int[] b)
    {
        int[] mergedArray = new int[a.Length+ b.Length];
        Array.Copy(a, 0, mergedArray, 0, a.Length);
        Array.Copy(b, 0, mergedArray, a.Length, b.Length);

        return mergedArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
