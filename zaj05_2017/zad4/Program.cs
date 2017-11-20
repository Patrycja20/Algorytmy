using System;
using System.Diagnostics;
using System.IO;
//Zadanie 4. Przetestuj i porównaj (Stopwatch) 
//napisane przez nas metody testowania: Wybieranie, 
//szybkie oraz pozycyjne dla losowych tablic zawierających 
//liczby co najwyżej 6-cio cyfrowe.

class Program
{
    static void BabelSort(int[] L)
    {
        int N = L.Length;

        for (int i = 0; i < N; i++)
        {
            for (int j = N - 1; j > i; j--)
            {
                if (L[j] < L[j - 1])
                {
                    int t = L[j - 1]; 
                    L[j - 1] = L[j]; 
                    L[j] = t;
                }
            }
        }
    }

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

    static void Pozycyjne(int[] A, int podstawa)
    {
        int n = A.Length;
        int[] B = new int[n];
        int m = A[0]; //szukamy najwiekszej liczby m
        for (int i = 1; i < n; i++) if (A[i] > m) m = A[i];
        int exp = 1; // podstawa^0 potem podstawa^1 itd az
        while (m / exp > 0) //znajdziemy wartosc wieksza od najwiekszej liczby
        {
            int[] liczniki = new int[podstawa];
            //zliczanie wartosci na pozycjach czyli znajdujemy liczniki
            for (int i = 0; i < n; i++) liczniki[(A[i] / exp) % podstawa]++;
            //sumujemy liczniki
            for (int i = 1; i < podstawa; i++) liczniki[i] += liczniki[i - 1];
            //umieszczmy elementy na swoich pozycjach obnizajac licznik
            for (int i = n - 1; i >= 0; i--) B[--liczniki[(A[i] / exp) % podstawa]] = A[i];
            //kopiujemy ciag wyjsciowy do tablicy poczatkowej
            for (int i = 0; i < n; i++) A[i] = B[i];
            //przechodzimy do następnej pozycji
            exp *= podstawa;
        }
    }

    static int[] Wczytaj(string path, int dlugosc)
    {
        int[] tab = new int[dlugosc];

        StreamReader sr = new StreamReader(path);
        int i = 0;
        while (i < tab.Length)
        {
            tab[i] = Convert.ToInt32(sr.ReadLine());
            i++;
        }
        sr.Close();

        return tab;
    }
    static void Main(string[] args)
    {
        // plik ma 100 000 elementów
        // w domu możemy podmienic na duży
        int[] tab = Wczytaj("plik6cyfrmaly.txt", 100000);
        Stopwatch sw = new Stopwatch();

        sw.Start();
        QuickSort(tab, 0, tab.Length - 1);
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();

        sw.Start();
        Pozycyjne(tab, 10);
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);
        sw.Reset();

        sw.Start();
        BabelSort(tab);
        sw.Stop();
        Console.WriteLine(sw.ElapsedTicks);

        Console.ReadKey();
    }
}

