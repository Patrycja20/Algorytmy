using System;

class Program
{
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
            if (T[j] <= klucz) // zamień
            {
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
    //Opracuj algorytm znajdowania k-tego 
    // elementu nieposortowanego ciągu 
    // metodą dziel i zwyciężaj 
    //(wsk. jest to algorytm Hoare'a).

    // Złożonośc oczekiwana jest liniowa Θ(n)

    static int Hoare(int[] T, int l, int p, int k)
    {
        if (l == p) return T[l];// l musi być równe k
        int i = Podzial(T, l, p);
        if (i == k) return T[i];
        if (i < k) return Hoare(T, i + 1, p, k);
        else return Hoare(T, l, i - 1, k);
    }

    static void Main(string[] args)
    {
        int[] tab2 = { -19, 1, 1, 8, 7, -5, 3, 5, 4, 6 };

        Console.WriteLine(Hoare(tab2, 0, tab2.Length - 1, 0));
        Console.WriteLine(Hoare(tab2, 0, tab2.Length - 1, 2));
        Console.WriteLine(Hoare(tab2, 0, tab2.Length - 1, 5));
        Console.WriteLine(Hoare(tab2, 0, tab2.Length - 1, 7));
        Console.WriteLine(Hoare(tab2, 0, tab2.Length - 1, 9));

        Console.ReadKey();
    }
}

