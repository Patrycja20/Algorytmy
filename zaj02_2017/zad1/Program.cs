using System;
using System.Collections.Generic;

//Przeanalizuj algorytm programu, który dla podanych liczb 
//– całkowitej nieujemnej n oraz rzeczywistej x będzie 
//obliczał ich iloczyn n * x korzystając z dodawania. 
//Znajdź niezmiennik tego algorytmu i udowodnij, ze jest to niezmiennik. 
//Wykaz, ze spełniony jest warunek stopu. 

class Program
{
    static double Mnozenie(int n, double x) 
    {
        int m = n;
        double y = 0;
        // niezmiennik
        // m>=0 i y==(n-m)*x

        // przed wykonaniem pętli m>=0 spełnione y==(n-m)*x spełnione bo 0==0
        while(m > 0)
        {
            y = y + x;
            m = m - 1;
            // ZALOZENIE INDUKCYJNE
            // niech na początku pewnego obrotu petli 
            // m==m' oraz prawdziwe jest
            // y==(n-m')*x
            // oczwiście m'>0 bo weszło w pętlę a więc także m'>=0
            // KROK INDUKCYJNY
            // wówczas na zakonczenie obrotu petli mamy
            // m''== m'-1 oraz
            // y==(n-m')*x +x == (n-m'+1)*x == (n-(m'-1))*x == n-m'')*x
            // a więc niezmiennik jest spełniony
            // m''>=0  ponieważ było m'>0 i 
            // y==(n-m'')*x
        }

        // po zakończeniu pętli mamy 
        // m==0 i 
        // y==(n-0)*x == n*x

        return y;
    }
    // ponieważ m jest na początku całkowite dodatnie
    // to ponieważ w każdym kroku zmniejsza się o 1 to
    // w pewnym momencie osiągnie wartość zero i pętla się zakończy

    static void Main(string[] args)
    {
        Console.WriteLine(Mnozenie(5,2.5));
        Console.ReadKey();
    }
}

