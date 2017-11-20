using System;
//Zadanie 2. 
//Na wykładzie były algorytmy przez wstawianie od najmniejszego do największego. 
//Opracuj algorytmy wstawiające od najwiekszego do najmniejszego.


class Program
{
 
    static void Wstawianie(int[] L)
    {
        int k, j;
        for (int i = L.Length - 2; i >= 0; i--)
        {
            k = L[i];
            j = i;
            while (j < L.Length - 1 && L[j + 1] < k)
            {
                L[j] = L[j + 1]; // przesuwam elementy
                j++;
            }
            L[j] = k; // wstawiam w odpowiednie miejsce
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
 
        Wstawianie(t1);
        Wypisz(t1);
        Wstawianie(t2);
        Wypisz(t2);
        Wstawianie(t3);
        Wypisz(t3);
        Wstawianie(t4);
        Wypisz(t4);
       
        Console.ReadKey();
    }
}

