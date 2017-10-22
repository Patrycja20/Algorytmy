using System;

namespace Zadanie_3
{
    class Program
    {
        static string Rest(double[] nominal_value, double amount, int i = 0)
        {
            int p;
            if (amount != 0)
            {
                if (nominal_value[i] <= amount)
                {
                    p = (int)amount / (int)nominal_value[i];
                    amount -= p * nominal_value[i];
                    return "wydano " + p + " banknotów po " + nominal_value[i] + " złotych, " + Rest(nominal_value, amount, i++);
                }
            } return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Rest(new double[] { 50, 25, 20, 10, 5, 1 }, 40));
            Console.WriteLine(Rest(new double[] { 22, 19, 10, 5, 3, 1 }, 825));
            Console.WriteLine(Rest(new double[] { 240, 60, 30, 24, 12, 6, 3, 1, 0.5 }, 40));
            Console.WriteLine(Rest(new double[] { 240, 60, 30, 24, 12, 6, 3, 1, 0.5 }, 825));

            Console.ReadKey();
        }
    }
}
