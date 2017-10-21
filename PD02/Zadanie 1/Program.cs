using System;


namespace Zadanie_1
{
    class Program
    {
        //Przeanalizuj algorytm programu, który dla podanej liczby naturalnej n 
        //będzie obliczał funkcje podłoga z pierwiastka kwadratowego tej liczby. 
        //Znajdź niezmiennik  tego algorytmu i udowodnij, ze jest to niezmiennik. Wykaz, ze spełniony jest warunek stopu.
        static int Podłoga(int n)
        {
            int wynik;
            for (int i = 0; i < n; i++)//gdy licznik będzie większy niż przekazana liczba
            {
                wynik = i*i;
                if (wynik > n) return i - 1;//gdy kwadrat licznika będzie większy niż przekazana liczba
            } return 0;
        }
        //Niezmiennik: n
        static void Main(string[] args)
        {
            Console.WriteLine(Podłoga(15));

            Console.ReadKey();
        }
    }
}
