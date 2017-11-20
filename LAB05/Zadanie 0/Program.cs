using System;

namespace Zadanie_0
{
    class Program
    {
        static void Wybieranie(int[] L)
        {
            int porównania = 0, zamiany = 0;
            for (int i = 0; i < L.Length; i++)
            { // szukamy najmniejszego elementu w L dla (i, N - 1)
                porównania++;
                int k = i;
                for (int j = i + 1; j < L.Length; j++)
                {
                    porównania++;
                    if (L[k] > L[j]) k = j;
                    porównania++;
                }
                // zamieniamy z go z elementem i-tym
                int t = L[k]; L[k] = L[i]; L[i] = t;
                zamiany++;
            }
            Console.WriteLine("Porównania: {0}, zamiany: {1}", porównania, zamiany);
        }

        static void Wstawianie(int[] L)
        {
            int porównania = 0, zamiany = 0;
            int k, j;
            for (int i = 1; i < L.Length; i++)
            {
                porównania++;
                k = L[i];
                j = i;
                while (j > 0 && L[j - 1] > k)
                {
                    porównania++;
                    porównania++;
                    L[j] = L[j - 1]; // przesuwam elementy
                    zamiany++;
                    j--;
                }
                L[j] = k; // wstawiam w odpowiednie miejsce
                zamiany++;
            }
            porównania++;
            Console.WriteLine("Porównania: {0}, zamiany: {1}", porównania, zamiany);
        }

        static void Wypisz(int[] L)
        {
            int i;
            Console.Write("\n");
            for (i = 0; i < L.Length - 1; i++)
            {
                Console.Write(L[i] + " ");
            }
            Console.Write(L[i] + "\n\n");
        }

        static void Main(string[] args)
        {
            Wypisz(new int[] { 2, 452, 3, 6, 17, 76, 2, 75, 22, 42, 65, 67, 89 });
            Wybieranie(new int[] { 2, 452, 3, 6, 17, 76, 2, 75, 22, 42, 65, 67, 89 });
            Wstawianie(new int[] { 2, 452, 3, 6, 17, 76, 2, 75, 22, 42, 65, 67, 89 });
            Wypisz(new int[] { 1, 3, 5, 6, 8, 23, 43, 66, 346, 532, 656, 2346 });
            Wybieranie(new int[] { 1, 3, 5, 6, 8, 23, 43, 66, 346, 532, 656, 2346 });
            Wstawianie(new int[] { 1, 3, 5, 6, 8, 23, 43, 66, 346, 532, 656, 2346 });
            Wypisz(new int[] { 9099, 2983, 3212, 132, 112, 67, 45, 35, 32, 2 });
            Wybieranie(new int[] { 9099, 2983, 3212, 132, 112, 67, 45, 35, 32, 2 });
            Wstawianie(new int[] { 9099, 2983, 3212, 132, 112, 67, 45, 35, 32, 2 });
            Wypisz(new int[] { 232, 232, 232, 232, 232, 232, 232, 232, 232, 232 });
            Wybieranie(new int[] { 232, 232, 232, 232, 232, 232, 232, 232, 232, 232 });
            Wstawianie(new int[] { 232, 232, 232, 232, 232, 232, 232, 232, 232, 232 });

            Console.ReadKey();
        }
    }
}
