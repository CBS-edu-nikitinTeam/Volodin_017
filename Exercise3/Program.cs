using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 7, 12, 4, 1, 5, 2 };

            array.AscendingSort();

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }

    public static class ArrayExtension
    {
        public static void AscendingSort(this int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 1; j < array.Length; j++)
                {
                    if (array[j] < array[j - 1]) {
                        int temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
    }
}
