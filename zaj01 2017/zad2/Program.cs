using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

//Napisz "prymitywny" algorytm wyznaczający liczby pierwsze 
//(prymitywny znaczy dzielenie przez wszystkie mniejsze liczby). 
//Oblicz czas wykonania używając klasy Stopwatch. 
//Jak można poprawić taki algorytm?
// Znajdź informacje o sicie Eratostenesa i zaimplementuj je. 
// Oblicz czas wykonania poprawionych algorytmów używając 
// klasy Stopwatch. Porównaj wyniki. 

class Program
{
    static void CzyPierwszaPrymitywnie(bool[] A)
    {
        for (int l = 2; l < A.Length; l++)
        {
            for (int i = 2; i < l; i++)
            {
                if (l % i == 0)
                {
                    A[l] = false;
                }
            }
        }
    }

    static void CzyPierwszaBrutalnie(bool [] A)
    {
        for (int l = 2; l < A.Length; l++)
        {
            for (int i = 2; i < l; i++)
            {
                if (l % i == 0)
                {
                    A[l] = false;
                    break; // po co dalej sprawdzac
                }
            }
        }
    }

    static void CzyPierwsza(bool[] A)
    {
        for (int l = 2; l < A.Length; l++)
        {
            for (int i = 2; i <=Math.Sqrt(l); i++)
            {
                if (l % i == 0)
                {
                    A[l] = false;
                    break;
                }
            }
        }
    }

    // https://pl.wikipedia.org/wiki/Sito_Eratostenesa

    static void Sito(bool[] A)
    {
        for (int i = 2; i <=Math.Sqrt( A.Length); i++)
        {
            if (A[i] == true)
            {
                for (int k = i*i ; k < A.Length; k = k + i)
                {
                    A[k] = false;
                }
            }
        }
    }

    // Uwaga 
    // w zadaniu bierzemy tablicę typu bool i dla indeksów które są liczbami pierwszymi wpisujemy wartość true
    // a dla indeksów które nie są liczbami pierwszym wpisujemy false

    static void Main(string[] args)
    {
        // najpierw sprawdzenie dla małych wartości
        bool[] liczbyPierwsze1 = new bool[100];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        CzyPierwszaPrymitywnie(liczbyPierwsze1);
        for (int i = 0; i < liczbyPierwsze1.Length; i++)
        {
            if (liczbyPierwsze1[i])
            {
                Console.Write(i+" ");
            }
        }
        Console.WriteLine();
        liczbyPierwsze1 = new bool[100];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        CzyPierwszaBrutalnie(liczbyPierwsze1);
        for (int i = 0; i < liczbyPierwsze1.Length; i++)
        {
            if (liczbyPierwsze1[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        liczbyPierwsze1 = new bool[100];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        CzyPierwsza(liczbyPierwsze1);
        for (int i = 0; i < liczbyPierwsze1.Length; i++)
        {
            if (liczbyPierwsze1[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
        liczbyPierwsze1 = new bool[100];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        Sito(liczbyPierwsze1);
        for (int i = 0; i < liczbyPierwsze1.Length; i++)
        {
            if (liczbyPierwsze1[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();

        // teraz będziemy badać złożoność obliczeniową
        Console.WriteLine();
        Stopwatch st = new Stopwatch();

        liczbyPierwsze1 = new bool[10000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwszaPrymitywnie(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("prymitywnie elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        liczbyPierwsze1 = new bool[100000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwszaPrymitywnie(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("prymitywnie elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        Console.WriteLine();

        liczbyPierwsze1 = new bool[10000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwszaBrutalnie(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("brutalnie elementów "+liczbyPierwsze1.Length +" tików "+ st.ElapsedTicks);
        st.Reset();

        liczbyPierwsze1 = new bool[100000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwszaBrutalnie(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("brutalnie elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        liczbyPierwsze1 = new bool[1000000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwszaBrutalnie(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("brutalnie elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        Console.WriteLine();

        liczbyPierwsze1 = new bool[10000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwsza(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("z sqrt elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        liczbyPierwsze1 = new bool[100000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwsza(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("z sqrt elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        liczbyPierwsze1 = new bool[1000000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        CzyPierwsza(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("z sqrt elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        Console.WriteLine();

        liczbyPierwsze1 = new bool[10000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        Sito(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("sito elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        liczbyPierwsze1 = new bool[100000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        Sito(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("sito elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();

        
        liczbyPierwsze1 = new bool[1000000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        Sito(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("sito elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();
        
        liczbyPierwsze1 = new bool[10000000];
        for (int i = 2; i < liczbyPierwsze1.Length; i++)
        {
            liczbyPierwsze1[i] = true;
        }
        st.Start();
        Sito(liczbyPierwsze1);
        st.Stop();
        Console.WriteLine("sito elementów " + liczbyPierwsze1.Length + " tików " + st.ElapsedTicks);
        st.Reset();
        
        // Wnioski

        // Algorytm prymitywny ma własność stopu 
        // Obie pętle for są regularne a wewnątrz pętli indeksy sie nie zmieniają
        // wyrażnie ma złożoność kwadratową zadanie 10 razy większe wykonuje się 100 razy dłużej

        // Algorytm brutalny ma własność stopu 
        // Obie pętle for są regularne a wewnątrz pętli indeksy sie nie zmieniają
        // poprawa polega na tym, że gdy wiemy, że liczba nie jest pierwsza to dalej nie sprawdzamy
        // zlozonosc jest już mniejsza niż kwadratowa

        // Algorytm z sqrt ma własność stopu 
        // Obie pętle for są regularne a wewnątrz pętli indeksy sie nie zmieniają
        // Wewnętrzna pętla Math niejszy zakres a więc dla rozmiaru n złożoność
        // na pewno jest mniejsza niż n *SQRT(n) a jeszcze jest poprawa
        // taka, że gdy wiemy, że liczba nie jest pierwsza to dalej nie sprawdzamy
        
       // Sito Eratostenesa wyrażnie ma złożoność tylko nieco większą niż liniowa
        // ma oczywiście własność stopu bo obie pętle są regularne

 
        Console.ReadKey();
    }
}

