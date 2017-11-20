using System;

namespace Zadanie_3C
{
    class Program
    {
        static void Compartment(int[] array, int x, int start, int end)
        {
            if (x >= array[0] || x < array[array.Length - 1])
            { Console.WriteLine("X poza zakresem"); return; }
            if (x == array[array.Length - 1])
            { Console.WriteLine("[" + array[array.Length - 2] + " , " + array[array.Length - 1] + "]"); return; }
            if (end - start <= 1)
            {
                if (((start + 1) < array.Length) && (array[start]) >= x && (array[start + 1] < x))
                    Console.WriteLine("[" + array[start] + " , " + array[end] + ")");
                return;
            }
            int mid = (start + end) / 2;
            Compartment(array, x, start, mid);
            Compartment(array, x, mid, end);
        }

        static void Main(string[] args)
        {
            int[] array = { 9, 8, 6, 5, 3, 2, -3 };
            int x;
            Compartment(array, 7, 0, array.Length - 1);
            Compartment(array, 4, 0, array.Length - 1);
            Compartment(array, 0, 0, array.Length - 1);
            Compartment(array, 5, 0, array.Length - 1);
            Compartment(array, 3, 0, array.Length - 1);
            Compartment(array, 2, 0, array.Length - 1);
            Compartment(array, 1, 0, array.Length - 1);
            Compartment(array, -3, 0, array.Length - 1);


            Console.ReadKey();
        }
    }
}
