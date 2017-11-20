using System;

namespace Zadanie_3
{
    class Program
    {
        static int[] Sort(int[] array)
        {
            int[] new_array = new int[array.Length];
            int p = 0, k = array.Length - 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0) { new_array[p] = 0; p++; i++; }
                if (array[i] == 2) { new_array[k] = 2; k--; }
            }
            for (int i = p; i < k+1; i++)
            {
                new_array[i] = 1;
            } return new_array;
        }

        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 1, 0, 1, 0, 2, 0, 2, 2, 2, 2, 2, 1, 1, 1, 1, 0, 0, 0, 1, 2, 2 };
            int[] new_array = Sort(array);
            for (int i = 0; i < new_array.Length; i++)
            {
                Console.Write(new_array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
