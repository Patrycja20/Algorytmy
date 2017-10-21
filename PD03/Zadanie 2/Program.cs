using System;

namespace Zadanie_2
{
    class Program
    {

        //Opracuj metodę rekurencyjną wyszukiwania trynarnego (dzielenie przedziału na 3). Wyprowadz równanie rekurencyjne na złożoność.

        static int Search(int[] tab, int x, int przedział)
        {
            Check_the_ends(tab, x);
        }
        static int? Check_the_ends(int[] tab, int x)
        {
            if (tab[0] == x) return 0;
            if (tab[tab.Length - 1] == x) return tab.Length - 1;
            return Search(tab, x);
        }

        static void Main(string[] args)
        {




            Console.ReadKey();
        }
    }
}
