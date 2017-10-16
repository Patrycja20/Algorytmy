using System;

namespace Zadanie_3
{
    class Program
    {
        //Liczba króków potrzebnych do wykonania wszystkich operacji to log n

        static int Wyszukaj(int[] tablica, int liczba)
        {
            int l = 1, p = tablica.Length; int s = (p + l) / 2;
            while (tablica[s - 1] != liczba)
            {
                if (tablica[s - 1] > liczba) p = s - 1;
                if (tablica[s - 1] < liczba) l = s + 1;
                s = (p + l) / 2;
            } return s-1;
        }

        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 5, 7, 8, 9, 12, 14, 15, 17, 19, 20 };
            Console.WriteLine("Element 14 znaleziono pod indeksem: {0}", Wyszukaj(tab,14));
            Console.WriteLine("Element 1 znaleziono pod indeksem: {0}", Wyszukaj(tab, 1));
            Console.WriteLine("Element 20 znaleziono pod indeksem: {0}", Wyszukaj(tab, 20));



            Console.ReadKey();
        }
    }
}
