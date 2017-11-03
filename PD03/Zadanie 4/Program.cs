using System;
using System.Collections.Generic;

namespace Zadanie_4
{
    class Program
    {
        static int Permutations(double[] nominal_value, double amount)
        {
            int result = 0;
            for (int i = 0; i < nominal_value.Length; i++)
            {
                result += Rest(Discard_one(nominal_value, i), amount);
            }
            return result;
        }

        static double[] Discard_one(double[] nominal_value, int n)
        {
            double[] new_array = new double[nominal_value.Length - 1];
            int k = 0;
            for (int i = 0; i < new_array.Length; i++)
            {
                if (k == n) k++;
                new_array[i] = nominal_value[k++];
            }
            return new_array;
        }

        static int Rest(double[] nominal_value, double amount, int i = 0)
        {
            int p;
            if (amount < 0) return 0;
            if (amount != 0)
            {
                if (nominal_value[i] <= amount)
                {
                    p = (int)amount / (int)nominal_value[i];
                    amount -= p * nominal_value[i];
                    return Rest(nominal_value, amount, i++);
                }
            }
            return 1;
        }

        static void Main(string[] args)
        {
            double[] nominal_value = { 1, 2,5 };
            Console.WriteLine("Ilość dostępnych permutacji reszty dla {0} to: {1}", 5, Permutations(nominal_value, 5));




            Console.ReadKey();
        }
    }
}
