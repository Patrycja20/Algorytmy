using System;

namespace Zadanie_3
{
    class Program
    {
        static bool CzyIstnieją(int m, int[] L1, int[] L2)
        {
            for (int i = 0; i < L1.Length; i++)
            {
                for (int k = 0; k < L2.Length; k++)
                {
                    if ((L1[i] + L2[k] )== m) return true;   
                }
            } return false;
        }

        static void Main(string[] args)
        {
            int [] L1 = new int[]{1,3,5,7,9};
            int[] L2 = new int[] { 12,76,445,545,667};
            Console.WriteLine("Dla m = {0}: " +CzyIstnieją(454,L1,L2));
            Console.WriteLine("Dla m = {0}: " +CzyIstnieją(787,L1,L2));
            Console.ReadKey();
        }
    }
}
