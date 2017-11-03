using System;

namespace Zadanie_5
{
    class Program
    {
        static void Merging(int[] array, int first, int middle, int last)
        {
            int i, j; int[] new_array = new int[array.Length];

            //zapisujemy lewą częsć podtablicy w tablicy pomocniczej
            for (i = middle + 1; i > first; i--)
                new_array[i - 1] = array[i - 1];

            //zapisujemy prawą częsć podtablicy w tablicy pomocniczej
            for (j = middle; j < last; j++)
                new_array[last + middle - j] = array[j + 1];

            //scalamy dwie podtablice z tablicy pomocniczej i zapisujemy we właściwej tablicy
            for (int k = first; k <= last; k++)
                if (new_array[j] < new_array[i])
                    array[k] = new_array[j--];
                else
                    array[k] = new_array[i++];
        }
        static void Sort_and_connect(int[] array)
        {
            int k = 1;//zaczynamy od przedziałów o długości 1

            while (k < array.Length)//scalamy dopóki długość przedziału nie osiągnie długości wielkości tablicy
            {
                int i = 0;
                while (i + 2 * k < array.Length)
                {
                    Merging(array, i, i + k - 1, i + 2 * k - 1);
                    i = i + 2 * k;
                }
                if (i + k < array.Length)
                    Merging(array, i, i + k - 1, array.Length - 1);
                k = 2 * k;//będziemy scalać dwie tablice, więc długość przedziału zawsze będzie parzysta
            }
        }
        static void View(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            } Console.WriteLine(array[array.Length - 1]);
        }

        static void Main(string[] args)
        {
            int[] random = new int[] { -19, 1, 1, 8, 7, -5, 3, 5, 4, 6 };
            int[] increasing = new int[] { 1, 2, 3, 4, 6, 7, 8, 17, 25, 29 };
            int[] decreasing = new int[] { 19, 10, 5, 4, 3, 1, 0, -1, -2, -5 };

            View(random);
            Sort_and_connect(random);
            Console.WriteLine("Po posortowaniu: ");
            View(random);
            Console.WriteLine("________________________________");
            View(increasing);
            Sort_and_connect(increasing);
            Console.WriteLine("Po posortowaniu: ");
            View(increasing);
            Console.WriteLine("________________________________");
            View(decreasing);
            Sort_and_connect(decreasing);
            Console.WriteLine("Po posortowaniu: ");
            View(decreasing);




            Console.ReadKey();
        }
    }
}
