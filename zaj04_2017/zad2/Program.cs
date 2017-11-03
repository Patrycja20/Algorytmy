using System;

class Program
{
    static int porownania;
    static int zamiany;

    //element srodkowy
    //static int Podzial(int[] T, int l, int p)
    //{
    //    int i, j, klucz, tmp, index;
    //    index = (l + p) / 2; // mogą być inne
    //    klucz = T[index];
    //    // zamien element centralny z prawym
    //    tmp = T[index];
    //    T[index] = T[p];
    //    T[p] = tmp;
    //    i = l;
    //    for (j = l; j < p; j++)
    //    {
    //        porownania++;
    //        if (T[j] <= klucz) // zamień
    //        {
    //            zamiany++;
    //            tmp = T[i];
    //            T[i] = T[j];
    //            T[j] = tmp; i++;
    //        }
    //    }
    //    // wstaw element centralny na swoje miejsce
    //    tmp = T[i];
    //    T[i] = T[p];
    //    T[p] = tmp;
    //    return i;
    //}

    //element prawy
    static int Podzial(int[] T, int l, int p)
    {
        int i, j, klucz, tmp, index;
        index = p; //prawy
        klucz = T[index];
        //// zamien element centralny z prawym
        //tmp = T[index];
        //T[index] = T[p];
        //T[p] = tmp;
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

    
    
    
    //// element lewy
    //static int Podzial(int[] T, int l, int p)
    //{
    //    int i, j, klucz, tmp, index;
    //    index = l; //lewy
    //    klucz = T[index];
    //    // zamien element lewy z prawym
    //    tmp = T[index];
    //    T[index] = T[p];
    //    T[p] = tmp;
    //    i = l;
    //    for (j = l; j < p; j++)
    //    {
    //        porownania++;
    //        if (T[j] <= klucz) // zamień
    //        {
    //            zamiany++;
    //            tmp = T[i];
    //            T[i] = T[j];
    //            T[j] = tmp; i++;
    //        }
    //    }
    //    // wstaw element centralny na swoje miejsce
    //    tmp = T[i];
    //    T[i] = T[p];
    //    T[p] = tmp;
    //    return i;
    //}
    static void QuickSort(int[] T, int l, int p)
    {
        porownania++; // dodajemy też to porównanie
        if (l >= p) return;
        int i = Podzial(T, l, p);
        Console.Write(i+" "); // punkty podziału, ile punktów tyle podziałów
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

        zamiany = 0;
        porownania = 0;
        QuickSort(tab1, 0, tab1.Length - 1);
        Console.WriteLine();
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab1);
        zamiany = 0;
        porownania = 0;
        QuickSort(tab2, 0, tab2.Length - 1);
        Console.WriteLine();
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab2); 
        zamiany = 0;
        porownania = 0;
        QuickSort(tab3, 0, tab3.Length - 1);
        Console.WriteLine();
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab3);
        zamiany = 0;
        porownania = 0;
        QuickSort(tab4, 0, tab4.Length - 1);
        Console.WriteLine();
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab4);
        zamiany = 0;
        porownania = 0;
        QuickSort(tab5, 0, tab5.Length - 1);
        Console.WriteLine();
        Console.WriteLine("Zamiany: {0}, porownania = {1}", zamiany, porownania);
        //Wypisz(tab5);
        Console.ReadKey();
    }
}


// element srodkowy
//Zamiany: 25, porownania = 42
//Zamiany: 7, porownania = 32
//Zamiany: 12, porownania = 34
//Zamiany: 45, porownania = 64
//Zamiany: 5, porownania = 39

//element prawy
//Zamiany: 19, porownania = 37
//Zamiany: 45, porownania = 64
//Zamiany: 20, porownania = 64
//Zamiany: 45, porownania = 64
//Zamiany: 19, porownania = 41

// element lewy 
//Zamiany: 11, porownania = 41
//Zamiany: 0, porownania = 64
//Zamiany: 25, porownania = 64
//Zamiany: 45, porownania = 64
//Zamiany: 8, porownania = 37

// Przypadek ciągu stałego jest NAJGORSZY
// Ciąg posortowany daje słaby wynik gdy bierzemy element prawy jako klucz ale ma dużo porównań

//7 5 4 1 3 9  - było 6 podziałów
//Zamiany: 19, porownania = 37

//9 8 7 6 5 4 3 2 1 - było 9 podziałów
//Zamiany: 45, porownania = 64

//0 9 1 8 2 7 3 6 4 - było 9 podziałów
//Zamiany: 20, porownania = 64

//9 8 7 6 5 4 3 2 1 - było 9 podziałów
//Zamiany: 45, porownania = 64

//9 2 0 7 6 4 - było 6 podziałów
//Zamiany: 19, porownania = 41
