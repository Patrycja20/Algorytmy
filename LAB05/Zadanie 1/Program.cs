using System;

namespace Zadanie_1
{
    class Program
    {
        static void Wybieranie(int[] L)
        {
            for (int i = L.Length - 1; i >= 0; i--)
            { // szukamy największego elementu w L dla (i, N - 1)
                int k = i;
                for (int j = i - 1; j >= 0; j--)
                {
                    if (L[k] < L[j]) k = j;
                }
                // zamieniamy z go z elementem i-tym
                int t = L[k]; L[k] = L[i]; L[i] = t;
            }
            Wypisz(L);
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
            int[] losowa = { 2, 452, 3, 6, 17, 76, 2, 75, 22, 42, 65, 67, 89 };
            int[] rosnąca = { 1, 3, 5, 6, 8, 23, 43, 66, 346, 532, 656, 2346 };
            int[] malejąca = { 9099, 2983, 3212, 132, 112, 67, 45, 35, 32, 2 };
            int[] stała = { 232, 232, 232, 232, 232, 232, 232, 232, 232, 232 };

            Wypisz(losowa);
            Wybieranie(losowa);
            Wypisz(rosnąca);
            Wybieranie(rosnąca);
            Wypisz(malejąca);
            Wybieranie(malejąca);
            Wypisz(stała);
            Wybieranie(stała);

            Console.ReadKey();
        }
    }
}
