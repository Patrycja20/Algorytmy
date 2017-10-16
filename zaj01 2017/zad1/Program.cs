using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

//Napisz algorytm sprawdzający czy dany ciąg jest niemalejący. 
//Zrób dwie wersje algorytmu dla tablicy i dla listy. 
// Oblicz czas wykonania używając klasy Stopwatch.
// Porównaj wyniki dla plików testowych. 

class Program
{
    // Algorytm jest bardzo podobny do wyszukiwania liniowego z wykładu
    // Warunek stopu jest spełniony bo liczba kroków jest co najwyżej n-1
    // poniważ pętla for jest regularna a indeks nie zmienia się wewnątrz pętli

    static bool CzyNiemalejacy(int[] tab)
    {
        for (int i = 0; i < tab.Length - 1; i++)
        {
            if (tab[i + 1] < tab[i])
            {
                return false;
            }
        }
        return true;
    }

    static bool CzyNiemalejacy(List<int> tab)
    {
        for (int i = 0; i < tab.Count - 1; i++)
        {
            if (tab[i + 1] < tab[i])
            {
                return false;
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        int[] tab1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] tab2 = { 1, 2, 1, 3, 4, 5, 6, 7 };
        Console.WriteLine(CzyNiemalejacy(tab1));
        Console.WriteLine(CzyNiemalejacy(tab2));

        // UWAGA
        // Pliki A1.txt, A2.txt, A3.txt i A4.txt należy wkopiować bezpośrednio do katalogu Debug
        // albo samemu zmodyfikować ścieżki

        int[] tab3 = new int[10000000];
        StreamReader sr = new StreamReader("A4.txt");
        string line;
        int idx = 0;
        while ((line = sr.ReadLine()) != null)
        {
            tab3[idx++] = Convert.ToInt32(line);
        }
        sr.Close();
        Stopwatch st = new Stopwatch();
        st.Start();
        bool wynik = CzyNiemalejacy(tab3);
        st.Stop();
        Console.WriteLine(wynik);
        Console.WriteLine("tablica " + tab3.Length + " elementów a tików " + st.ElapsedTicks);

        int[] tab4 = new int[10000000];
        sr = new StreamReader("A3.txt");
        idx = 0;
        while ((line = sr.ReadLine()) != null)
        {
            tab4[idx++] = Convert.ToInt32(line);
        }
        sr.Close();
        st.Reset();
        st.Start();
        wynik = CzyNiemalejacy(tab4);
        st.Stop();
        Console.WriteLine(wynik);
        Console.WriteLine("tablica " + tab4.Length + " elementów a tików " + st.ElapsedTicks);

        int[] tab5 = new int[1000000];
        sr = new StreamReader("A2.txt");
        idx = 0;
        while ((line = sr.ReadLine()) != null)
        {
            tab5[idx++] = Convert.ToInt32(line);
        }
        sr.Close();
        st.Reset();
        st.Start();
        wynik = CzyNiemalejacy(tab5);
        st.Stop();
        Console.WriteLine(wynik);
        Console.WriteLine("tablica " + tab5.Length + " elementów a tików " + st.ElapsedTicks);

        int[] tab6 = new int[100000];
        sr = new StreamReader("A1.txt");
        idx = 0;
        while ((line = sr.ReadLine()) != null)
        {
            tab6[idx++] = Convert.ToInt32(line);
        }
        sr.Close();
        st.Reset();
        st.Start();
        wynik = CzyNiemalejacy(tab6);
        st.Stop();
        Console.WriteLine(wynik);
        Console.WriteLine("tablica " + tab6.Length + " elementów a tików " + st.ElapsedTicks);


        // WNIOSKI
        // ALgorytm wyraznie ma złożoność obliczeniową liniową - proporcjonalną do n
        // Zadanie 10 razy większe wymaga 10 razy więcej tików

        Console.WriteLine();
        // teraz jak działa na liście

        List<int> l3 = new List<int>();
        foreach (int item in tab3)
        {
            l3.Add(item);
        }
        st.Reset();
        st.Start();
        wynik = CzyNiemalejacy(l3);
        st.Stop();
        Console.WriteLine(wynik);
        Console.WriteLine("lista " + l3.Count + " elementów a tików " + st.ElapsedTicks);

        List<int> l5 = new List<int>();
        foreach (int item in tab5)
        {
            l5.Add(item);
        }
        st.Reset();
        st.Start();
        wynik = CzyNiemalejacy(l5);
        st.Stop();
        Console.WriteLine(wynik);
        Console.WriteLine("lista " + l5.Count + " elementów a tików " + st.ElapsedTicks);

        List<int> l6 = new List<int>();
        foreach (int item in tab6)
        {
            l6.Add(item);
        }
        st.Reset();
        st.Start();
        Console.WriteLine(CzyNiemalejacy(l6));
        st.Stop();
        Console.WriteLine("lista " + l6.Count + " elementów a tików " + st.ElapsedTicks);

        // WNIOSKI
        // ALgorytm na liscie ma złożoność obliczeniową liniową 
        // jednakże działa ponad 2 razy wolniej

        Console.ReadKey();
    }
}

