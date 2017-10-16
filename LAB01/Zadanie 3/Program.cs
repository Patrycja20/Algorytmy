using System;

namespace Zadanie_3
{
    class Program
    {
        static void Steinhaus(int n)
        {
            if (n > 0)
            {
                while (n != 1 && n != 4) // ten algorytm zakończy się zawsze, bo ma dwa warunki z których choć jeden nie zostanie po jakimś czasieS spełniony
                {
                    int s = 0;
                    while (n > 0)
                    {
                        int c = n % 10; // możliwa reszta z dzielenia to od 0 do 9  
                        s += c * c;
                        n /= 10; // ponieważ n jest liczbą naturalną to nigdy jako s nie otrzymamy 0
                    } // s = suma kwadratów cyfr liczby n 
                    n = s;
                }
            }
        }
        static void Main(string[] args)
        {
            Steinhaus(123987);
            Console.WriteLine("STOP");
            Steinhaus(0);
            Console.WriteLine("STOP");

            Console.ReadKey();
        }
    }
}
