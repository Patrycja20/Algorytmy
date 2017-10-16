using System;
using System.Diagnostics;

namespace Zadanie_2
{
    class Program
    {
        static bool Czy_Pierwsza(int liczba)
        {
            if (liczba == 2) return true;
            for (int i = 2; i < liczba; i++)
            {
                if (liczba % i == 0) return false;
            }
            return true;
        }
        static void Czy_Pierwsze(bool[] liczby)
        {
            for (int i = 1; i < liczby.Length - 1; i++)
            {
                liczby[i] = Czy_Pierwsza(i + 1);
            }
        }


        //sito Eratostenesa

        static void Czy_Pierwsze(int[] liczby)
        {
            liczby[0] = 0;
            for (int i = 1; i < liczby.Length; i++)
            {
                if (liczby[i] != 0)
                {
                    for (int k = i + 1; k < liczby.Length; k++)
                    {
                        if (liczby[k] % liczby[i] == 0) liczby[k] = 0;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            Console.WriteLine("Liczby pierwsze na przedziale <1,30>?\n");
            bool[] liczby = new bool[30];
            time.Start();
            Czy_Pierwsze(liczby);
            time.Stop();
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby[i] == true) Console.Write("{0}, ", i + 1);
            }
            Console.WriteLine("Czas: " + time.ElapsedTicks);

            Console.WriteLine("Liczby pierwsze na przedziale <1,30>?\n");
            int[] liczby1 = new int[30];
            for (int i = 0; i < liczby1.Length; i++)
            {
                liczby1[i] = i + 1;
            }
            time.Reset();
            time.Start();
            Czy_Pierwsze(liczby);
            time.Stop();
            for (int i = 0; i < liczby.Length; i++)
            {
                if (liczby1[i] != 0) Console.Write("{0}, ", i + 1);
            }
            Console.WriteLine("Czas: " + time.ElapsedTicks);

            Console.ReadKey();
        }
    }
}
