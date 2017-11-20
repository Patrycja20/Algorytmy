using System;

namespace Zadanie_1C
{
    class Program
    {
        //Czy poniższy algorytm ma własność stopu? 
        //Odp.Tak, pętla się wykona n-razy
        //Jaka jest pesymistyczna złożoność obliczeniowa tego algorytmu?
        //Odp.n
        static int Algorytm(int[] A)
        {
            int i, j, n, m = 0;
            n = A.Length;//n - ilość elementów w tablicy
            for (i = 0; i < n; i++)//pętla się zakończy, gdy i=n 
                //z każdym obrotem pętli zmienną "i" zwiększamy o 1
            {
                j = n - 1;
                while (j > 0)
                {
                    m += 1;
                    j = j / 2;
                }
            }
            return m;
        }
        static void Main(string[] args)
        {
        }
    }
}
