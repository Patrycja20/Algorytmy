using System;

namespace Zadanie_1
{
    class Program
    {
        static int Leader(int[] array, int n)
        {
            if (n == 1) return array[0];
            else
            {
                int[] first_half = The_first_half(array);
                int[] second_half = The_second_half(array);
                int Leader1 = Leader(first_half, n / 2);
                int Leader2 = Leader(second_half, n / 2);
                if (Leader1 == Leader2) return Leader1;
                int i1 = 0, i2 = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == Leader1) i1++;
                    if (array[i] == Leader2) i2++;
                }
                if (i1 > array.Length / 2) return Leader1;
                if (i2 > array.Length / 2) return Leader2;
                return -1;
            }
        }

        static int[] The_first_half(int[] array)
        {
            int stop = array.Length / 2;
            int[] new_array = new int[stop];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i];
            } return new_array;
        }

        static int[] The_second_half(int[] array)
        {
            int start = array.Length / 2, stop = array.Length;
            int[] new_array = new int[stop - start];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[start++];
            } return new_array;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 3, 3, 3, 3, 3, 1, 9, 6, 2, 3, 1, 1, 3, 3, 3, 4 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" "); 
            }
            Console.WriteLine("Długość tej tablicy to: {0}",array.Length);
            Console.WriteLine("Liderem w tablicy jest: {0}", Leader(array, array.Length));
            Console.ReadKey();
        }
    }
}
