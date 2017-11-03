using System;

namespace Zadanie_0
{
    class Program
    {
        static int fun1(int n)
        {
            if (n == 1)
                return 0;
            else
                return 1 + fun1(n / 2);
        } 
        //powyższy algorytm ma złożoność log_2 (n)
        
        //dzielimy liczbę całkowitą do momentu, gdy będzie ona równa 1
        //w wyniku tego, jeśli wprowadzona liczba > 1 otrzymamy ile razy musieliśmy podzielić daną liczbę na 2, by otrzymać 1


        static void Main(string[] args)
        {
            Console.WriteLine(fun1(6));

            Console.ReadKey();
        }
    }
}
