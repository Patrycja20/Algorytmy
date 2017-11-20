using System;

namespace Zadanie_3A
{
    class Program
    {
        //L1[k] - L2[l] = m <=> L1[k] = L2[l] + m
        static bool Is_m(int[] L1, int[] L2, int m)
        {
            int k = 0, l = 0;
            while (k < L1.Length && l < L2.Length)
            {
                if (L1[k] == L2[l] + m) return true;
                if (L1[k] < L2[l] + m) k++;
                else if(L1[k] > L2[l] + m) l++;//warunek niepotrzebny, ale ułatwia zrozumienie działania
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] L1 = { 1,2,3,4,5};
            int[] L2 = {1,1,1,3,45 ,30,90,100};
            Console.WriteLine(Is_m(L1,L2,2));
            Console.WriteLine(Is_m(L1,L2,10));

            Console.ReadKey();
        }
    }
}
