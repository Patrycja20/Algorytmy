using System;

namespace Zadanie_2
{
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
            Wstawianie(losowa);
            Wypisz(rosnąca);
            Wstawianie(rosnąca);
            Wypisz(malejąca);
            Wstawianie(malejąca);
            Wypisz(stała);
            Wstawianie(stała);

            Console.ReadKey();
        }
    }
}
