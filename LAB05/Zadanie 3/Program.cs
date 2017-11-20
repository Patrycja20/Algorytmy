using System;
using System.IO;

namespace Zadanie_3
{
    class Program
    {
        //Wybieranie________________________________________________________
        static void Wybieranie(int[] L)
        {
            for (int i = 0; i < L.Length; i++)
            { // szukamy najmniejszego elementu w L dla (i, N - 1)
                int k = i;
                for (int j = i + 1; j < L.Length; j++)
                {
                    if (L[k] > L[j]) k = j;
                }
                // zamieniamy z go z elementem i-tym
                int t = L[k]; L[k] = L[i]; L[i] = t;
            }
        }
        //Wstawianie________________________________________________________
        static void Wstawianie(int[] L)
        {
            int k, j;
            for (int i = 1; i < L.Length; i++)
            {
                k = L[i];
                j = i;
                while (j > 0 && L[j - 1] > k)
                {
                    L[j] = L[j - 1]; // przesuwam elementy
                    j--;
                }
                L[j] = k; // wstawiam w odpowiednie miejsce
            }
        }
        //Szybkie___________________________________________________________
        static int Podzial(int[] T, int l, int p)
        {
            int i, j, klucz, tmp, index;
            index = (l + p) / 2; // mogą być inne
            klucz = T[index];
            // zamien element centralny z prawym
            tmp = T[index];
            T[index] = T[p];
            T[p] = tmp;
            i = l;
            for (j = l; j < p; j++)
            {
                if (T[j] <= klucz) // zamień
                { tmp = T[i]; T[i] = T[j]; T[j] = tmp; i++; }
            }
            // wstaw element centralny na swoje miejsce
            tmp = T[i];
            T[i] = T[p];
            T[p] = tmp;
            return i;
        }
        static void QuickSort(int[] T, int l, int p)
        {
            if (l >= p) return;
            int i = Podzial(T, l, p);
            QuickSort(T, l, i - 1);
            QuickSort(T, i + 1, p);
        }
        //Scalanie__________________________________________________________
        static void Scalaj(int[] T, int p, int mid, int k)
        // p - poczatek, k - koniec, mid - srodek
        // łączy 2 posortowane tablice T[p...mid] i T[mid+1...k]
        {
            int[] T2 = new int[T.Length]; // tablica pomocnicza
            int p1 = p, k1 = mid; // pod-tablica 1
            int p2 = mid + 1, k2 = k; // pod-tablica 2
            // aż do wyczerpania tablic dokonaj scalenia przy pomocy tablicy pomocniczej
            int i = p1;
            while ((p1 <= k1) && (p2 <= k2))
            {
                if (T[p1] < T[p2])
                { T2[i] = T[p1]; p1++; }
                else
                { T2[i] = T[p2]; p2++; }
                i++;
            }
            while (p1 <= k1)
            { T2[i] = T[p1]; p1++; i++; }
            while (p2 <= k2)
            { T2[i] = T[p2]; p2++; i++; }
            // skopiuj z tablicy tymczasowej do oryginalnej
            for (i = p; i <= k; i++) T[i] = T2[i];
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
        //Bąbelkowe________________________________________________________
        static void BubbleSort(int[] L)
        {
            int N = L.Length;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = N - 1; j > i; j--)
                {
                    if (L[j] < L[j - 1])
                    {
                        int t = L[j - 1]; L[j - 1] = L[j]; L[j] = t;
                    }
                }
            }
        }
        //Bąbelkowe_poprawione_____________________________________________
        static void BubbleSortCorrected(int[] L)
        {
            int N = L.Length;
            int p = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = N - 1; j > i; j--)
                {
                    if (L[j] < L[j - 1])
                    {
                        int t = L[j - 1]; L[j - 1] = L[j]; L[j] = t; p++;
                    }
                } if (p != 0) return;
                p = 0;
            }
        }
        
        static void Main(string[] args)
        {
            

            Console.ReadKey();
        }
    }
}
