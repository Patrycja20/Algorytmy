using System;

namespace Zadanie_1A
{
    class Program
    {
        //Jaką instrukcję należy dodać poza pętlą, 
        //aby sprawdzić, czy w tablicy A był element o wartości x?
        static int Wyszukaj(int[] A, int x)
        {
            int N = A.Length;
            int k = N - 1;
            while (k >= 0 && A[k] != x)
                k -= 1;
            //Odp. if(k==-1) Console.WriteLine("W tablicy nie było elementu o wartości równej x.");
            return k;
        }
        static void Main(string[] args)
        {
            //Podaj także indeks tej wartości 1 która zostanie znaleziona jeżeli wywołamy metodę
            //wyszukaj dla poniższej tablicy
            //Odp.9
            int[] L = { 3, 1, 4, 5, 6, 9, 1, 0, 7, 1, 2, 2, 6 };
            int n = Wyszukaj(L, 1);
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
