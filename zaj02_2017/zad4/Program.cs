using System;
using System.Collections.Generic;

//Przetestuj algorytm sortowania bąbelkowego w 
//zależności od danych wejściowych (ciąg posortowany, 
//ciąg posortowany malejąco, ciąg losowy). 
//Policz liczbę porównań i zamian. 
//Zmodyfikuj algorytm tak by kończył działanie 
//gdy nie ma już co zamieniać. 
//Zbadaj liczbę porównań i zamian. 

class Program
{
    static void Babelkowe(int[] L)
    {
        int N = L.Length;
        int porownania = 0;
        int zamiany = 0;
        for (int i = 0; i < N - 1; i++)
        {
            porownania++; // i< N-1
            for (int j = N - 1; j > i; j--)
            {
                porownania++;// j>i
                porownania++;// L[j] < L[j - 1]
                if (L[j] < L[j - 1])
                {
                    int t = L[j - 1];
                    L[j - 1] = L[j];
                    L[j] = t;
                    zamiany++;
                }
            }
            porownania++; // gdy j == i 
        }
        porownania++; // gdy i == N-1
        Console.WriteLine("porownan {0}, zamian {1}", porownania, zamiany);
    }

    static void Wypisz(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
            Console.Write(tab[i] + " ");
        Console.WriteLine();
    }

    static void BabelkoweUlepszone(int[] L)
    {
        int N = L.Length;
        int porownania = 0;
        int zamiany = 0;
        for (int i = 0; i < N - 1; i++)
        {
            porownania++; // i< N-1
            int ileByłoZamian = 0; // zamiany w tym obrocie petli
            for (int j = N - 1; j > i; j--)
            {
                porownania++;// j>i
                porownania++;// L[j] < L[j - 1]
                if (L[j] < L[j - 1])
                {
                    int t = L[j - 1];
                    L[j - 1] = L[j];
                    L[j] = t;
                    zamiany++;
                    ileByłoZamian++; // dodatkowa operacja
                }
            }
            // nie bylo w tym obrocie zamian to konczymy brutalnie
            porownania++; // dodatkowe poniższe porównaniie
            if (ileByłoZamian == 0) break;
            porownania++; // gdy j == i 
        }
        porownania++; // gdy i == N-1
        Console.WriteLine("porownan {0}, zamian {1}", porownania, zamiany);
    }

    static void Main(string[] args)
    {
        int[] losowa = { 4, 14, 0, 2, 0, 1, 4, 1, 6, 2, 0, 8, 1, 12, 1 };
        int[] rosnaca = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int[] malejaca = { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

        Babelkowe(losowa);
        Wypisz(losowa);
        Babelkowe(rosnaca);
        Wypisz(rosnaca);
        Babelkowe(malejaca);
        Wypisz(malejaca);

        Console.WriteLine();

        // Poprawienie niewiele zmienia, polepsza sie tylko
        //  w przypadkach gdy ciąg jest posortowany rosnąco 
        // lub prawie posortowany rosnąco
        // tylko wtedy liczba porównań spadnie
        // w wielu innych przypadkach się zwiększy
        // liczba zamian sie nie zmieni

        int[] losowa1 = { 4, 14, 0, 2, 0, 1, 4, 1, 6, 2, 0, 8, 1, 12, 1 };
        int[] rosnaca1 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
        int[] malejaca1 = { 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };

        BabelkoweUlepszone(losowa1);
        Wypisz(losowa1);
        BabelkoweUlepszone(rosnaca1);
        Wypisz(rosnaca1);
        BabelkoweUlepszone(malejaca1);
        Wypisz(malejaca1);
        
        Console.ReadKey();
    }
}

