using System;

class Program
{
    static int porownania;
    static int zamiany;
    static int Podzial(int[] T, int l, int p)
    {
        int i, j, klucz, tmp, index;
        index = (l + p) / 2; // mogą być inne
        klucz = T[index];
        // zamien element centralny z prawym
        tmp = T[index];
        T[index] = T[p];
        T[p] = tmp;
        i = l;
        for (j = l; j < p; j++)
        {
            porownania++;
            if (T[j] <= klucz) // zamień
            {
                zamiany++;
                tmp = T[i]; 
                T[i] = T[j]; 
                T[j] = tmp; i++; 
            }
        }
        // wstaw element centralny na swoje miejsce
        tmp = T[i];
        T[i] = T[p];
        T[p] = tmp;
        return i;
    }

    static void QuickSort(int[] T, int l, int p)
    {
        if (l >= p) return;
        int i = Podzial(T, l, p);
        QuickSort(T, l, i - 1);
        QuickSort(T, i + 1, p);
    }
    static void Wypisz(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
            Console.Write(tab[i] + "  ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {

        int[] tab1 = { -19, 1, 1, 8, 7, -5, 3, 5, 4, 6 };
        int[] tab2 = { 1, 2, 3, 4, 6, 7, 8, 17, 25, 29 };
        int[] tab3 = { 19, 10, 5, 4, 3, 1, 0, -1, -2, -5 };
        int[] tab4 = { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[] tab5 = { 1, 8, 7, -5, 3, 5, 4, 6, 2, 9 };

        // LICZYMY ILE POROWNAN I ZAMIAN
        zamiany = 0;
        porownania = 0;
        QuickSort(tab1, 0, tab1.Length - 1);
        Console.WriteLine("Zamiany: {0}, porownania = {1}",zamiany, porownania);
        //Wypisz(tab1);
        zamiany = 0;
        porownania = 0;
        QuickSort(tab2, 0, tab2.Length - 1);
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab2); 
        zamiany = 0;
        porownania = 0;
        QuickSort(tab3, 0, tab3.Length - 1);
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab3);
        zamiany = 0;
        porownania = 0;
        QuickSort(tab4, 0, tab4.Length - 1);
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab4);
        zamiany = 0;
        porownania = 0;
        QuickSort(tab5, 0, tab5.Length - 1);
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab5);
        Console.ReadKey();
    }
}

