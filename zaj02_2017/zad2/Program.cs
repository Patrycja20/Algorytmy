using System;
using System.Collections.Generic;

//Przywódcą ciągu jest element, który występuje w 
//ciągu więcej razy niż połowa długości tego ciągu. 
//Naszym problemem jest policzenie przywódcy ciągu 
//danego w tablicy A[1..n]. Dla uproszczenia przyjmijmy, 
//że w tym ciągu jest przywódca. 
//Zbadaj złożoność stworzonego algorytmu. 

class Program
{
    // Array Sort  z .NET ma złożoność O(nlgn) 
    // korzysta z HeapSort (sortowanie stogowe) 
    // oraz QuickSort (sortowanie szybkie)
    // a dla bardzo krótkich tablic 
    // z InsetSort (sortowanie przez wstawianie)
    // omówimy te metody na dalszych wykladach

    // jest to napisane w dokumentacji na MSDN 
    // https://msdn.microsoft.com/en-us/library/6tf1f0bc(v=vs.110).aspx
    // w sekcji REMARKS na końcu jest konkluzja:
    // For arrays that are sorted by using the Heapsort and Quicksort algorithms, 
    // in the worst case, this method is an O(n log n) operation, where n is the Length of array.

    static int Leader(int[] tab)
    {
        Array.Sort(tab); // zlozoność nlgn
        return tab[tab.Length / 2];
    }

    static int Przywódca(int[] tab)
    {
        int count = 0;
        int przywodzca = -1;
        int i = 0;
        while (i < tab.Length)
        {
            if (count == 0)
            {
                przywodzca = tab[i];
                count++;
            }
            else
            {
                if (przywodzca == tab[i])
                    count++;
                else
                    count--;
            }
            i++;
        }
        // zlozonosc liniowa O(n);
        //  wykonuje się tylko n obrotow pętli

        return przywodzca;
    }

    static void Main(string[] args)
    {

        int[] A = { 1, 2, 3, 4, 1, 2, 1, 3, 1, 1, 1 };
        int[] B = { 1, 4, 3, 1, 4, 1, 3, 1, 3, 1, 1, 1 };
        int[] C = { 2, 3, 2, 2, 3, 2, 2 };
        int[] D = { 4, 1, 0, 1, 1, 0, 1, 2, 0, 1, 4, 1, 1, 2, 0, 1, 1, 1, 1 };

        Console.WriteLine(Przywódca(A));
        Console.WriteLine(Przywódca(B));
        Console.WriteLine(Przywódca(C));
        Console.WriteLine(Przywódca(D));

        Console.WriteLine();

        Console.WriteLine("Leader A: " + Leader(A));
        Console.WriteLine("Leader B: " + Leader(B));
        Console.WriteLine("Leader C: " + Leader(C));
        Console.WriteLine("Leader D: " + Leader(D));

        Console.ReadKey();
    }
}

