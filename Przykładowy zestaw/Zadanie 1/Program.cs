using System;

namespace Zadanie_1
{
    class Program
    {

        static int Metoda(int[] L)
        {
            var r = new Random();
            int n = L.Length;
            while (n > 1)
            {
                int i = r.Next(n);
                int x = L[i];
                L[i] = L[n - 1];
                L[n - 1] = x;
                int j = r.Next(n - 1);
                int y = L[j];
                L[j] = L[n - 2];
                L[n - 2] = y;
                if (x % 2 != y % 2)
                {
                    if (x % 2 == 1)
                        L[n - 2] = x;
                    else
                        L[n - 2] = y;
                    n--;
                }
                else n = n - 2;
            }
            return L[0];
        }
        //Niezmiennikiem w tej pętli będzie parzysta, bądź nieparzysta
        //liczba parzystych i nieparzystych elementów w tablicy
        //Zakładając pesymistycznie cały czas, będą wylosowywane: 
        //parzysty i nieparzysty element. Wtedy pesymistyczna złożoność obliczeniowa wynosi n-1.
        static void Main(string[] args)
        {

        }
    }
}
