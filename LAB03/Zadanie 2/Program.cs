using System;

namespace Zadanie_2
{
    class Program
    {

        static int Binary_search(int[] Array_of_numbers, int number, int n)
        {
            if (Array_of_numbers.Length == 0) return -1;
            int[] array = Array_of_numbers;

            if (array[array.Length / 2] == number)
                return array.Length / 2;

            if (Array_of_numbers[n / 2] < number)
                return (n / 2) + Binary_search(The_second_half(array), number, n / 2);
            else return Binary_search(The_first_half(array), number, n / 2);
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
            int[] array = { 1, 2, 34, 5, 6, 23, 2333, 11, 434, 90 };
            Array.Sort(array);

            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 6, Binary_search(array, 6, 10));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 11, Binary_search(array, 11, 10));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 34, Binary_search(array, 34, 10));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 90, Binary_search(array, 90, 10));
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
