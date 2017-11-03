using System;

namespace Zadanie_2
{
    class Program
    {
        class Start_from_the_middle
        {
            int[] random = { 23, 43, 123, 75, 988, 234, 54, 234, 64, 23, 54, 2344 };
            int[] increasing = { 1, 2, 3, 65, 344, 3342, 4444, 5453, 45345 };
            int[] decreasing = { 89908, 12323, 1223, 123, 111, 65, 34, 33, 3, 2 };
            int[] constant = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

            int comparisons, swaps;

            public Start_from_the_middle()
            {
                comparisons = 0; swaps = 0;
            }

            int Division(int[] array, int first, int last)
            {
                int i, j, key, tmp, index;
                index = (first + last) / 2;
                key = array[index];
                tmp = array[index];
                array[index] = array[last];
                array[last] = tmp;
                i = first;
                swaps++;
                for (j = first; j < last; j++)
                {
                    comparisons++;
                    if (array[j] <= key)
                    { tmp = array[i]; array[i] = array[j]; array[j] = tmp; i++; swaps++; }
                }
                comparisons += last - first;
                tmp = array[i];
                array[i] = array[last];
                array[last] = tmp;
                swaps++;
                return i;
            }
            void QuickSort(int[] array, int first, int last)
            {
                comparisons++;
                if (first >= last) return;
                int i = Division(array, first, last);
                QuickSort(array, first, i - 1);
                QuickSort(array, i + 1, last);
            }
            public void Results()
            {
                QuickSort(random, 0, random.Length - 1); View(random);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(increasing, 0, increasing.Length - 1); View(increasing);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(decreasing, 0, decreasing.Length - 1); View(decreasing);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(constant, 0, constant.Length - 1); View(constant);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
            }
        }

        class Start_from_the_left
        {
            int[] random = { 23, 43, 123, 75, 988, 234, 54, 234, 64, 23, 54, 2344 };
            int[] increasing = { 1, 2, 3, 65, 344, 3342, 4444, 5453, 45345 };
            int[] decreasing = { 89908, 12323, 1223, 123, 111, 65, 34, 33, 3, 2 };
            int[] constant = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

            int comparisons, swaps;
            public Start_from_the_left()
            {
                comparisons = 0; swaps = 0;
            }

            int Division(int[] array, int first, int last)
            {
                int i, j, key, tmp, index;
                index = first;
                key = array[index];

                tmp = array[index];
                array[index] = array[last];
                array[last] = tmp;
                i = first;
                swaps++;
                for (j = first; j < last; j++)
                {
                    comparisons++;
                    if (array[j] <= key)
                    { tmp = array[i]; array[i] = array[j]; array[j] = tmp; i++; swaps++; }
                }
                comparisons += last - first;
                tmp = array[i];
                array[i] = array[last];
                array[last] = tmp;
                swaps++;
                return i;
            }
            void QuickSort(int[] array, int first, int last)
            {
                comparisons++;
                if (first >= last) return;
                int i = Division(array, first, last);
                QuickSort(array, first, i - 1);
                QuickSort(array, i + 1, last);
            }
            public void Results()
            {
                QuickSort(random, 0, random.Length - 1); View(random);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(increasing, 0, increasing.Length - 1); View(increasing);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(decreasing, 0, decreasing.Length - 1); View(decreasing);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(constant, 0, constant.Length - 1); View(constant);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
            }
        }

        class Start_from_the_right
        {
            int[] random = { 23, 43, 123, 75, 988, 234, 54, 234, 64, 23, 54, 2344 };
            int[] increasing = { 1, 2, 3, 65, 344, 3342, 4444, 5453, 45345 };
            int[] decreasing = { 89908, 12323, 1223, 123, 111, 65, 34, 33, 3, 2 };
            int[] constant = { 4, 4, 4, 4, 4, 4, 4, 4, 4, 4 };

            int comparisons, swaps;
            public Start_from_the_right()
            {
                comparisons = 0; swaps = 0;
            }

            int Division(int[] array, int first, int last)
            {
                int i, j, key, tmp, index;
                index = last;
                key = array[index];

                i = first;
                for (j = first; j < last; j++)
                {
                    comparisons++;
                    if (array[j] <= key)
                    { tmp = array[i]; array[i] = array[j]; array[j] = tmp; i++; swaps++; }
                }
                comparisons += last - first;
                tmp = array[i];
                array[i] = array[last];
                array[last] = tmp;
                swaps++;
                return i;
            }
            void QuickSort(int[] array, int first, int last)
            {
                comparisons++;
                if (first >= last) return;
                int i = Division(array, first, last);
                QuickSort(array, first, i - 1);
                QuickSort(array, i + 1, last);
            }
            public void Results()
            {
                QuickSort(random, 0, random.Length - 1); View(random);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(increasing, 0, increasing.Length - 1); View(increasing);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(decreasing, 0, decreasing.Length - 1); View(decreasing);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
                QuickSort(constant, 0, constant.Length - 1); View(constant);
                Console.WriteLine("Porównania: {0} Zamiany: {1}", comparisons, swaps);
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
            Start_from_the_middle middle = new Start_from_the_middle();
            Start_from_the_left left = new Start_from_the_left();
            Start_from_the_right right = new Start_from_the_right();

            Console.WriteLine("Element startowy = środek");
            middle.Results();
            Console.WriteLine("\nElement startowy = lewy");
            left.Results();
            Console.WriteLine("\nElement startowy = prawy");
            right.Results();

            Console.ReadKey();
        }
    }
}
