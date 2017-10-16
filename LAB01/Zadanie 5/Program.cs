using System;
using System.Diagnostics;

namespace Zadanie_5
{
    class Program
    {
        //---------A
        static int NWD_z_odejmowaniem(int a, int b)
        {
            while (a != b)
            {
                if (a > b) a = Math.Max(a, b) - Math.Min(a, b);
                else b = Math.Max(a, b) - Math.Min(a, b);
            } return a;
        }

        static int NWD_z_dzieleniem(int a, int b)
        {
            int r;
            while (a % b != 0)
            {
                r = a % b;
                a = b;
                b = r;
            } return b;
        }

        static void Main(string[] args)
        {
            Stopwatch time = new Stopwatch();

            Console.WriteLine("Algorytm z odejmowaniem");
            time.Start();
            Console.WriteLine(NWD_z_odejmowaniem(36, 45));
            time.Stop();
            Console.WriteLine("Czas: " + time.ElapsedTicks);
            
            time.Reset();

            Console.WriteLine("Algorytm z dzieleniem");
            time.Start();
            Console.WriteLine(NWD_z_dzieleniem(36, 45));
            time.Stop();
            Console.WriteLine("Czas: " + time.ElapsedTicks);
            
            Console.ReadKey();
        }
    }
}
