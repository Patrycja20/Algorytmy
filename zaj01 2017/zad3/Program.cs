using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Zbadaj algorytm Steinhausa. 
//Uzasadnij, że algorytm ten zawsze zakończy się.

    class Program
    {
        static int Steinhouse(int n)
        {
            while (n != 1 && n != 4)
            {
                int s = 0;
                while (n > 0)
                {
                    int c = n % 10;
                    s += c * c;
                    n /= 10;
                } // s = suma kwadratów cyfr liczby n
                n = s;
            }
            return n;
        }

        static void Main(string[] args)
        {
            // wstepne sprawdzanie
            Console.WriteLine(Steinhouse(98764532));
            Console.WriteLine(Steinhouse(999));
            Console.WriteLine(Steinhouse(64532));
            Console.WriteLine(Steinhouse(1999));
            Console.WriteLine(Steinhouse(1111));
            Console.WriteLine(Steinhouse(1717));

            // Rozważmy najpierw liczby więcej niż trzycyfrowe.

            // Jeśli liczba n ma m cyfr, to suma kwadratów tych cyfr jest co najwyżej 9^2 m, czyli 81m.
            // Przykładowo jeśli liczba jest m=10^k cyfrowa to cyfr ma 10^k * 9^2 czyli nie więcej niż
            // k+2 cyfr (9^2 < 10^2)  a w nastepnym kroku liczba jest co najwyżej 9^2 *(k+2) cyfrowa
            // Stąd 
            // jeśli liczba jest czterocyfrowa to suma jej kwadratów jest co najwyżej 324
            // jeśli liczba jest pięciocyfrowa to suma jej kwadratów jest co najwyżej 405
            // jeśli liczba jest sześciocyfrowa to suma jej kwadratów jest co najwyżej 486
            // ...
            // jeśli liczba jest jedenastocyfrowa to suma jej kwadratów jest co najwyżej 891
            // jeśli liczba jest dwunastocyfrowa to suma jej kwadratów jest co najwyżej 972
            //
            // widać, że dla dużych liczb w kilku krokach schodzimy do liczb trzycyfrowych
            //
            // Dla liczb trzycyfrowych rozumujemy podobnie, suma kwadratów jest co najwyżej 243

            // brutalne sprawdzenie że dla liczb <= 243 zbiega do 1 lub 4
            for (int i = 1; i <= 243; i++)
                Console.Write(Steinhouse(i) + "  ");

            Console.ReadKey();
        }
    }

