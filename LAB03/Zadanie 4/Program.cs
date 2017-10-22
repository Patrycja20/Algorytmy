using System;

namespace Zadanie_4
{
    class Program
    {
        static void Rest(double[] nominal_value, double amount)
        {
            Console.WriteLine("Wydanie reszty: {0}", amount);
            int p; int i = 0;
            while (amount != 0)
            {
                if (nominal_value[i] <= amount)
                {
                    p = (int)amount / (int)nominal_value[i];
                    amount -= p * nominal_value[i];
                    Console.WriteLine("Wydano {0} banknotów po {1} złotych, do wydania zostało {2}", p, nominal_value[i], amount);
                }
                i++;
            }
        }
        static void Main(string[] args)
        {
            Rest(new double[] { 50, 25, 20, 10, 5, 1 }, 40);
            Rest(new double[] { 22, 19, 10, 5, 3, 1 }, 825);

            Console.ReadKey();
        }
    }
}
