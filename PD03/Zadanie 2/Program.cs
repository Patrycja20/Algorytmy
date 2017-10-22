using System;

namespace Zadanie_2
{
    class Program
    {
        static int Search(int[] Array_of_numbers, int number, int n)
        {
            if (Array_of_numbers.Length == 0) return -1;
            int[] array = Array_of_numbers;

            if (array[array.Length / 3] == number)
                return array.Length / 3;

            if (array[2 * array.Length / 3] == number)
                return 2 * array.Length / 3;


            if (Array_of_numbers[n / 3] < number && number < array[2 * array.Length / 3])
                return n / 3 + Search(second_part(array), number, n / 3);
            else if (number > array[2 * array.Length / 3]) return 2 * n / 3 + Search(third_part(array), number, n / 3);
            else return Search(first_part(array), number, n / 3);
        }

        static int[] first_part(int[] array)
        {
            int stop = array.Length / 3;
            int[] new_array = new int[stop];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[i];
            } return new_array;
        }

        static int[] second_part(int[] array)
        {
            int start = array.Length / 3, stop = 2 * array.Length / 3;
            int[] new_array = new int[stop - start];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[start++];
            } return new_array;
        }

        static int[] third_part(int[] array)
        {
            int start = 2 * array.Length / 3, stop = array.Length;
            int[] new_array = new int[stop - start];
            for (int i = 0; i < new_array.Length; i++)
            {
                new_array[i] = array[start++];
            } return new_array;
        }


        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}",10,Search(array,10,11));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 0, Search(array, 0, 11));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 5, Search(array, 5, 11));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 6, Search(array, 6, 11));
            Console.WriteLine("Element {0} znajduje się w tablicy na pozycji: {1}", 8, Search(array, 8, 11));



            Console.ReadKey();
        }
    }
}
