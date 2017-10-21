using System;

namespace Zadanie_1
{
    class Program
    {
        /*Masz opracować algorytm podnoszenia liczby do potęgi naturalnej a^n, wykorzystując mnożenie. 
         * a) Opracuj prosty (naiwny) algorytm iteracyjny i oceń jego złożoność. 
         * b) Opracuj algorytm rekurencyjny (dziel i zwyciężaj) i oceń jego złożoność. 
         * Zauważ, że np. a^11 = a*((a^5)^2), z kolei a^5 = a*((a^2)^2). c) 
         * Jeżeli masz do obliczenia wiele potęg liczby a to przydałaby się strategia oparta na programowaniu dynamicznym.
         * Opracuj na bazie algorytmu rekurencyjnego taki algorytm.*/
        //A
        static int Iterative_multiplication(int a, int n)
        {
            int result = 1;
            for (int i = 0; i < n; i++)
            {
                result *= a;
            }
            return result;
        }
        //Złożoność: n

        //B
        static int Recursive_multiplication(int a, int n)
        {
            if (n == 0) return 1;
            if (n % 2 == 0) return Recursive_multiplication(a, n / 2) * Recursive_multiplication(a, n / 2);
            else return a * Recursive_multiplication(a, n / 2) * Recursive_multiplication(a, n / 2);
        }
        //Złożoność: n

        //C
        static int Recursive_multiplication_dynamically(int a, int n)
        {
            if (n == 0) return 1;
            if (n % 2 == 0) return (int)Math.Pow(Recursive_multiplication_dynamically(a, n / 2), 2);
            else return a * (int)Math.Pow(Recursive_multiplication_dynamically(a, n / 2), 2);
        }
        //Złożoność: n/2

        static void Main(string[] args)
        {

            Console.WriteLine(Iterative_multiplication(2, 25));
            Console.WriteLine(Recursive_multiplication(2, 25));
            Console.WriteLine(Recursive_multiplication_dynamically(2, 25));


            Console.ReadKey();
        }
    }
}
