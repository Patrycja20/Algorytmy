using System;
//Zadanie 0. Przygotuj kilka tablic do testowania: 
//losową, uporządkowana rosnąco, uporządkowaną malejąco, 
//stałą. Zmodyfikuj kod algorytmów przez wstawianie i 
//wybieranie z wykładu tak aby zliczać liczbę porównań 
//i zamian (dla wstawiania właściwie przesunięć).
//Przeprowadź odpowiednie testy. 

class Program
{
    static void Wybieranie(int[] L)
    {
        int porownania=0;
        int zamiany=0;
        for (int i = 0; i < L.Length; i++)
        {
            porownania++;
            // szukamy najmniejszego elementu w L dla (i, N - 1)
            int k = i;
            for (int j = i + 1; j < L.Length; j++)
            {
                porownania++;
                if (L[k] > L[j]) k = j;
                porownania++;
            }
            porownania++;
            // zamieniamy z go z elementem i-tym
            int t = L[k]; 
            L[k] = L[i]; 
            L[i] = t;
            zamiany++;
        }
        porownania++;
        Console.WriteLine("porownania {0} zamiany {1}", porownania, zamiany);
    }
    static void Wstawianie(int[] L)
    {
        int zamiany = 0;
        int porownania = 0;
        int k, j;
        for (int i = 1; i < L.Length; i++)
        {
            porownania++;
            k = L[i];
            j = i;
            while (j > 0 && L[j - 1] > k)
            {
                porownania++;
                porownania++;
                L[j] = L[j - 1]; // przesuwam elementy
                zamiany++;
                j--;
            }
            L[j] = k; // wstawiam w odpowiednie miejsce
            zamiany++;
            porownania++;
        }
        porownania++;
        Console.WriteLine("porownania {0} zamiany {1}",porownania,zamiany );
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

        //Wybieranie(t1);
        //Wypisz(t1);
        //Wstawianie(t1);
        //Wypisz(t1);
        //Wstawianie(t1);
        //Wstawianie(t2);
        //Wstawianie(t3);
        //Wstawianie(t4);
        Wybieranie(t1);
        Wybieranie(t2);
        Wybieranie(t3);
        Wybieranie(t4);
        Console.ReadKey();
    }
}

