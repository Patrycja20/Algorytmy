using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Wypisz(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + "  ");
            Console.WriteLine();
        }

        static void Scalaj(int[] T, int p, int mid, int k)
        // p - poczatek, k - koniec, mid - srodek 
        // łączy 2 posortowane pod-tablice T[p...mid] i T[mid+1...k] 
        {
            int[] T2 = new int[T.Length]; // tablica pomocnicza 
            int p1 = p, k1 = mid; // pod-tablica 1 
            int p2 = mid + 1, k2 = k; // pod-tablica 2 
            // aż do wyczerpania tablic dokonaj scalenia przy pomocy tablicy pomocniczej 
            int i = p1;
            while ((p1 <= k1) && (p2 <= k2))
            {
                if (T[p1] < T[p2])
                {
                    T2[i] = T[p1];
                    p1++;
                }
                else
                {
                    T2[i] = T[p2];
                    p2++;
                }
                i++;
            }
            while (p1 <= k1)
            {
                T2[i] = T[p1];
                p1++;
                i++;
            }
            while (p2 <= k2)
            {
                T2[i] = T[p2];
                p2++;
                i++;
            }
            // skopiuj z tablicy tymczasowej do oryginalnej 
            for (i = p; i <= k; i++)
                T[i] = T2[i];
        }

        static void MergeSort(int[] T, int p, int k)
        {
            if (p < k)
            {
                int mid = (p + k) / 2; // środek
                MergeSort(T, p, mid); // sortuj lewą połowę
                MergeSort(T, mid + 1, k); // sortuj prawą połowę
                Scalaj(T, p, mid, k); // scalaj
            }
        }

        static void MergeSortIteratively(int[] T)
        {
            int k = 1;  //zaczynamy od przedziałów o długości 1

            while (k < T.Length) // scalamy dopóki długość przedziału mniejsza 
            {
                int i = 0;
                while (i + 2 * k < T.Length)
                {
                    Scalaj(T, i, i + k - 1, i + 2 * k - 1);
                    i = i + 2 * k;
                }
                //scalamy końcówkę
                if (i + k < T.Length)
                    Scalaj(T, i, i + k - 1, T.Length - 1);
                // po każdym kroku podwajamy długośc przedziału
                k = 2 * k;
            }
        }


        static void Main(string[] args)
        {
            int[] tab1 = { -19, 1, 1, 8, 7, -5, 3, 5, 4, 6 };
            int[] tab2 = { 1, 2, 3, 4, 6, 7, 8, 17, 25, 29 };
            int[] tab3 = { 19, 10, 5, 4, 3, 1, 0, -1, -2, -5 };
            int[] tab4 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            int[] tab5 = { 1, 8, 7, -5, 3, 5, 4, 6, 2, 9 };

            //MergeSort(tab1, 0, tab1.Length - 1);
            //Wypisz(tab1);

            MergeSortIteratively(tab1);
            Wypisz(tab1);
            MergeSortIteratively(tab2);
            Wypisz(tab2);
            MergeSortIteratively(tab3);
            Wypisz(tab3);
            MergeSortIteratively(tab4);
            Wypisz(tab4);
            MergeSortIteratively(tab5);
            Wypisz(tab5);

            Console.ReadKey();
        }
    }
}
