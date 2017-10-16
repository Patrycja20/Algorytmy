using System;


namespace Zadanie_4
{
    class Program
    {
        static int[] SortujBąbelkowo(int[] tablica)
        {
            int p;
            int porówniania = 0, zamiany = 0; int i = 0;
            for (int n = 0; n < tablica.Length; n++)
            {
                for (int k = i + 1; k < tablica.Length; k++)
                {
                    porówniania++;
                    if (tablica[i] > tablica[k]) { p = tablica[i]; tablica[i] = tablica[k]; tablica[k] = p; zamiany++; }
                    i++;
                }
                i = 0;
            }
            Console.WriteLine("Porównania: {0}, Zamiany: {1}", porówniania, zamiany);
            return tablica;
        }
        //złożoność czasowa n^2

        static int[] SortujBąbelkowoLepiej(int[] tablica)
        {
            int p;
            int porówniania = 0, zamiany = 0, zamiany1, i= 0;
            for (int n = 0; n < tablica.Length; n++)
            {
                zamiany1 = 0;
                for (int k = i + 1; k < tablica.Length; k++)
                {
                    porówniania++;
                    if (tablica[i] > tablica[k]) { p = tablica[i]; tablica[i] = tablica[k]; tablica[k] = p; zamiany++; zamiany1++; }
                    i++;
                }
                if (zamiany1 == 0) break;
                porówniania++;
                i =0;
            }
            Console.WriteLine("Porównania: {0}, Zamiany: {1}", porówniania, zamiany);
            return tablica;
        }

        static void Wyświetl(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                Console.Write(tab[i] + ",");
            }
            Console.Write(tab[tab.Length - 1] + "\n");
        }

        static void Main(string[] args)
        {
            int[] posortowany = { 1, 2, 3, 4, 5, 6, 7, 77, 234 };
            int[] malejący = { 1342, 1243, 23, 9, 7, 4, 3, 1 };
            int[] losowy = { 1, 6, 3, 6, 4, 6, 8, 2, 4, 12 };

            Wyświetl(SortujBąbelkowo(posortowany));
            Wyświetl(SortujBąbelkowo(malejący));
            Wyświetl(SortujBąbelkowo(losowy));
            Console.WriteLine();

            posortowany = new int[]{ 1, 2, 3, 4, 5, 6, 7, 77, 234 };
            malejący = new int[]{ 1342, 1243, 23, 9, 7, 4, 3, 1 };
            losowy = new int[]{ 1, 6, 3, 6, 4, 6, 8, 2, 4, 12 };
            Wyświetl(SortujBąbelkowoLepiej(posortowany));
            Wyświetl(SortujBąbelkowoLepiej(malejący));
            Wyświetl(SortujBąbelkowoLepiej(losowy));

            Console.ReadKey();
        }
    }
}
