using System;

namespace Zadanie_6
{
    class Program
    {

        static void AlgorytmA(int n)
        {
            //A
            int i = 1;

            int m = 0;

            while (i < n)//pętla wykona się lg(n)
            {

                i = 2 * i;//2^n

                for (int j = 0; j < n; j++)//wykona się tyle razy co n, a tak naprawde n*lg(n)
                    m = m + 1;

            }
        }

        static void AlgorytmB(int n)
        {
            //B
            int r = 0;

            for (int i = 1; i <= n - 1; i++)//prawie tyle co n

                for (int j = i + 1; j <= n; j++)// zawsze n - 1

                    for (int k = 1; k <= j; k++)// zawsze n - 2
                        r = r + 1;
            // sumarycznie n*(n-1)*(n-2)

        }

        static void Main(string[] args)
        {
            
            Console.ReadKey();
        }
    }
}
