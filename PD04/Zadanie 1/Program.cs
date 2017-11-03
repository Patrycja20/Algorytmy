using System;

namespace Zadanie_1
{
    class Program
    {
        //a
        static int Division(int[] array, int first, int last)
        {
            int i, j, key, tmp, index;
            index = (first + last) / 2;// (1) wskaż na środkowy element tablicy
            key = array[index];// (2) zapamiętaj wartość wskazanego elementu jako klucza

            i = first; j = last;// (3) wskaż na elementy lewy (pierwszy) i prawy (ostatni) ciągu 
            while (i <= j)// (4) wykonuj, aż numer elementu lewego stanie się większy od numeru elementu prawego
            {
                while (array[i] < key)// (a) dopóki, zaczynając od wskazanego lewego elementu ciągu, nie znajdziesz elementu lewego większego lub równego kluczowi, testuj kolejne elementy
                {
                    i++;
                }
                while (array[j] > key)// (b) dopóki, zaczynając od wskazanego prawego elementu ciągu, nie znajdziesz elementu prawego mniejszego lub równego kluczowi, testuj kolejne elementy
                {
                    j--;
                }
                if (i <= j)// c. jeśli numer lewego elementu jest mniejszy lub równy numerowi prawego elementu, to wykonaj:
                { tmp = array[i]; array[i] = array[j]; array[j] = tmp; i++; j--; }// I. zamień te wskazane elementy II. wskaż następne elementy lewy i prawy
            }
            return i;// (5) zapamiętaj numery elementów prawego = i i lewego = i - 1
        }
        static void QuickSort(int[] array, int first, int last)
        {
            if (first >= last) return;
            int i = Division(array, first, last);
            //Sortuj elementy od początku do lewego i od prawego do końca.
            QuickSort(array, first, i-1);
            QuickSort(array, i, last);
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
            int[] random = { -19, 1, 1, 8, 7, -5, 3, 5, 4, 6 };
            View(random);
            QuickSort(random, 0, random.Length - 1);
            View(random);

            Console.ReadKey();
        }
    }
}
