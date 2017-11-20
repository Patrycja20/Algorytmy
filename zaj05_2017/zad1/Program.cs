using System;

//Zadanie 1. Na wykładzie było sortowanie przez wybieranie 
//najmniejszych wartości. Napisz algorytm wybierający 
//wartości największe.

class Program
{
    static void WybieranieMax(int[] L)
    {
        for (int i = L.Length - 1; i >= 0; i--)
        {
            // szukamy najwiekszego elementu w L dla (i, N - 1)
            int k = i;
            for (int j = i-1; j >=0 ; j--)
            {
                if (L[k] < L[j]) k = j;
            }
            // zamieniamy z go z elementem i-tym
            int t = L[k];
            L[k] = L[i];
            L[i] = t;
        }
    }

    static void Wypisz(int[] t)
    {
        for (int i = 0; i < t.Length; i++)
            Console.Write(t[i] + " ");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] t1 = { 9, 2, 1, 8, 4, 7, 6, 10, 5, 3 };
        int[] t2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] t3 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        int[] t4 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };

        WybieranieMax(t1);
        Wypisz(t1);
        WybieranieMax(t2);
        Wypisz(t2);
        WybieranieMax(t3);
        Wypisz(t3);
        WybieranieMax(t4);
        Wypisz(t4);
        Console.ReadKey();
    }
}

