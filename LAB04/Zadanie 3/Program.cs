using System;

namespace Zadanie_3
{
    class Program
    {
        static int Division(int[] array, int first, int last)
        {
            int i, j, key, tmp, index;
            index = first;
            key = array[index];//jako element kluczowy wybieramy lewy
            i = last;//będzimy posuwać się od strony prawej
            for (j = last; j > first; j--)
            {
                if (array[j] >= key)//zamieniamy elementy po porównaniu z kluczem
                { tmp = array[i]; array[i] = array[j]; array[j] = tmp; i--; }
            }
            tmp = array[i];//wstawiamy nasz kluczowy element już na właściwe miejsce
            array[i] = array[index];
            array[index] = tmp;
            return i;
        }
        static void QuickSort(int[] array, int first, int last)
        {
            if (first >= last) return;
            int i = Division(array, first, last);
            QuickSort(array, first, i - 1);
            QuickSort(array, i + 1, last);
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
            int[] constant = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] random2 = new int[] { 1, 8, 7, -5, 3, 5, 4, 6, 2, 9 };
            QuickSort(random, 0, random.Length - 1);
            View(random);
            QuickSort(increasing, 0, increasing.Length - 1);
            View(increasing);
            QuickSort(decreasing, 0, decreasing.Length - 1);
            View(decreasing);
            QuickSort(constant, 0, constant.Length - 1);
            View(constant);
            QuickSort(random2, 0, random2.Length - 1);
            View(random2);

            Console.ReadKey();
        }
    }
}
