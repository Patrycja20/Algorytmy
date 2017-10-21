using System;

namespace Zadanie_2
{
    class Program
    {
        static int[] Złącz_Niemalejąco(int[] c1, int[] c2)
        {
            int[] nowy = new int[c1.Length + c2.Length];
            int w1 = 0, w2 = 0;
            for (int i = 0; i < nowy.Length; i++)
            {
                if (c1[w1] < c2[w2])
                {
                    nowy[i] = c1[w1++];
                    if (w1 == c1.Length)
                    {
                        while (i < nowy.Length && w2<c2.Length)
                        {
                            nowy[++i] = c2[w2++];
                        } break;
                    }
                }
                else
                {
                    nowy[i] = c2[w2++];
                    if (w2 == c2.Length)
                    {
                        while (i < nowy.Length && w1<c1.Length)
                        {
                            nowy[++i] = c1[w1++];
                        } break;
                    }
                }
            }
            return nowy;
        }
        static void Main(string[] args)
        {
            int[] ciąg1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] ciąg2 = new int[] { 4, 5, 6, 45, 78, 99 };

            int[] nowy = new int[ciąg1.Length + ciąg2.Length];
            nowy = Złącz_Niemalejąco(ciąg1, ciąg2);

            for (int i = 0; i < nowy.Length; i++)
            {
                Console.Write(nowy[i]+",");   
            }

            Console.ReadKey();
        }
    }
}
