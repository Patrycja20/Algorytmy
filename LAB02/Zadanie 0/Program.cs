using System;
using System.Collections.Generic;


namespace Zadanie_0
{
    class Program
    {
        static void Bialo_Czarne(List<int> zbior)
        {
            Random random = new Random();
            while (zbior.Count > 1)
            {
                //pierwszy element
                int index1 = random.Next(zbior.Count);
                int pierwszy = zbior[index1];
                zbior.RemoveAt(index1);

                //drugi element
                int index2 = random.Next(zbior.Count);
                int drugi = zbior[index2];
                zbior.RemoveAt(index2);

                Console.Write("Wylosowano: {0} i {1}\n", pierwszy, drugi);
                if (pierwszy != drugi)   zbior.Add(1);
            }
            if (zbior.Count == 1) Console.WriteLine("Został: {0}\n",zbior[0]);
            else Console.WriteLine("Pusto");
        }
        static void Main(string[] args)
        {
            List<int> zbior1 = new List<int> { 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 1 };
            Bialo_Czarne(zbior1);
            List<int> zbior2 = new List<int> { 1, 0, 1, 1, 0, 1, 0, 0, 1, 0, 1, 0, 0, 0 };
            Bialo_Czarne(zbior2);

            Console.ReadKey();
        }


    }
}
