using System;

namespace Zadanie_3B
{
    class Program
    {
        static int[] Sort(int[] array, int first,int second, int third)
        {
            if (first == second || second == third || first == third)
            { Console.WriteLine("Podano złe warunki sortowania!"); return array; }
            int[] new_array = new int[array.Length];
            int start = 0; int end = array.Length-1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == first) new_array[start++] = first;
                if (array[i] == third) new_array[end--] = third;
            }
            for (int i = start; i < end+1; i++)
                new_array[i] = second;
            return new_array;
        }

        static void Main(string[] args)
        {
            int[] array = { 1, 2, 2, 2, 2, 2, 0, 0, 0, 1, 0, 2, 1, 0 };
            int[] new_array = Sort(array, 2, 1, 0);
            for (int i = 0; i < new_array.Length; i++)
                Console.Write(new_array[i]+" ");
            Console.Write("\n");
            new_array = Sort(array, 1, 0, 2);
            for (int i = 0; i < new_array.Length; i++)
                Console.Write(new_array[i] + " ");
            Console.Write("\n");
            new_array = Sort(array, 0, 1, 2);
            for (int i = 0; i < new_array.Length; i++)
                Console.Write(new_array[i] + " ");

            Console.ReadKey();
        }
    }
}
