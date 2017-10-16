using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Zadanie_1
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
        static void Czy_Pierwsze(long[] liczby)
        {
            liczby[0] = 0;
            for (long i = 1; i < liczby.Length; i++)
            {
                if (liczby[i] != 0)
                {
                    for (long k = i + 1; k < liczby.Length; k++)
                    {
                        if (liczby[k] % liczby[i] == 0) liczby[k] = 0;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();
            var csv = new StringBuilder();

            csv.AppendLine("Prymitywnie");

            Console.WriteLine("Liczby pierwsze na przedziale <1,3000>?\n");
            bool[] l1 = new bool[3000];
            time.Start();
            Czy_Pierwsze(l1);
            time.Stop();
            Console.WriteLine("\nCzas: " + time.ElapsedTicks);
            csv.AppendLine("<1,3000> " + time.ElapsedTicks);

            Console.WriteLine("Liczby pierwsze na przedziale <1,9999>?\n");
            l1 = new bool[9999];
            time.Start();
            Czy_Pierwsze(l1);
            time.Stop();
            Console.WriteLine("\nCzas: " + time.ElapsedTicks);
            csv.AppendLine("<1,3000> " + time.ElapsedTicks);


            csv.AppendLine("Sito Eratostenesa");

            Console.WriteLine("Liczby pierwsze na przedziale <1,3000>?\n");
            long[] l2 = new long[3000];
            for (long i = 0; i < l2.Length; i++)
            {
                l2[i] = i + 1;
            }
            time.Start();
            Czy_Pierwsze(l2);
            time.Stop();
            Console.WriteLine("\nCzas: " + time.ElapsedTicks);
            csv.AppendLine("<1,3000> "+ time.ElapsedTicks);

            Console.WriteLine("Liczby pierwsze na przedziale <1,9999>?\n");
            l2 = new long[9999];
            for (long i = 0; i < l2.Length; i++)
            {
                l2[i] = i + 1;
            }
            time.Start();
            Czy_Pierwsze(l2);
            time.Stop();
            Console.WriteLine("\nCzas: " + time.ElapsedTicks);
            csv.AppendLine("<1,3000> " + time.ElapsedTicks);

            File.WriteAllText("Wyniki.csv", csv.ToString());

            Console.ReadKey();
        }
    }
}
