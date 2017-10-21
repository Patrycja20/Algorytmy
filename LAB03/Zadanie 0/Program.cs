using System;

namespace Zadanie_0
{
    class Program
    {
        long liczbawywołańrekurencji;

        public Program()
        {
            liczbawywołańrekurencji = 0;
        }
        long Fibonacci(long n)
        {
            long wynik;

            wynik = 1;
            liczbawywołańrekurencji++;

            if (n == 0)
                wynik = 0;
            else if (n == 1) wynik = 1;
            else if (n > 1) wynik = Fibonacci(n - 1) + Fibonacci(n - 2);
            
            return wynik;
        }

        public void Uruchom(long n)
        {
            long wynik;

            wynik = Fibonacci(n);

            Console.WriteLine("Liczba F: " + wynik + " Liczba wykonań rekurencji: " + this.liczbawywołańrekurencji);
        }

        static void Main(string[] args)
        {
            Program program;

            program = new Program();
            program.Uruchom(20);

            Console.ReadKey();
        }
    }
}
