using System;

namespace Zadanie_4
{
    class Program
    {
        static int Horner(int[] L)
        {
            int s = 0;
            for (int i = 0; i < L.Length; i++)
            {
                s = s * 10 + L[i];
            }
            return s;
        }

        static void Kaprekar(int n)
        {
            if (n % 1111 != 0)
            {
                while (n != 6174)
                {
                    int[] C = new int[4];
                    int i = 0;
                    while (n > 0)
                    {
                        C[i] = n % 10;
                        i++;
                        n = n / 10;
                    }
                    Array.Sort(C);
                    var n2 = Horner(C);
                    Array.Reverse(C);
                    var n1 = Horner(C);
                    n = n1 - n2;
                    Console.WriteLine(n);
                }
            }
        }

        static void Main(string[] args)
        {
            for (int i = 1000; i < 10000; i++)
            {
                Kaprekar(i);
                Console.WriteLine();
            }

            Console.WriteLine("STOP");

            Console.ReadKey();
        }
    }
}
