using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        //Na laboratorium rozważyliśmy algorytm wyłaniania przywódcy w ciągu. 
        //Teraz należy to uogólnić. Niech przywódcą rzędu p będzie element występujący w ciagu więcej 
        //niz n/(p+1) razy (czyli co najmniej funkcja Sufit(n/(p+1)) razy) czyli 1/(p+1) procent. 
        //Wymyśl algorytm znajdowania przywódców rzędu 2 (każdy z nich powinien występować więcej niż 33,333...% razy)
        //o pesymistycznej złożoności obliczeniowej O(n). Wyslij plik z implementacją swojego algorytmu w C#. 
        //Wskazówka: Na ważniaku znajdziesz program 
        //na znajdowanie silnego przywódcy oraz graficzną ilustrację znajdywania przywódców rzędu 4.

        static string WyznaczPrzywódce_n_Rzędu(int[] A, int n)
        {
            int p = 0, ile = 0, ile1 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int k = i; k < A.Length; k++)
                {
                    if (A[i] == A[k]) ile1++;
                }
                if (ile1 > ile) { ile = ile1; p = A[i]; }
                ile1 = 0;
            }
            if (ile > A.Length / (n+1)) return "przywódcą rzędu "+n+" jest: " + p;
            return "brak przywódcy";
        }

        static string WyznaczPrzywódce(int[] A)
        {
            int p = 0, ile = 0, ile1 = 0;
            for (int i = 0; i < A.Length; i++)
            {
                for (int k = i; k < A.Length; k++)
                {
                    if (A[i] == A[k]) ile1++;
                }
                if (ile1 > ile) { ile = ile1; p = A[i]; }
                ile1 = 0;
            }
            if(ile>A.Length/(3+1)) return "przywódcą rzędu 3 jest: "+p;
            return "brak przywódcy";
        }

        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 2, 4, 5, 6, 1, 1, 1, 1, 6, 6, 1, 1, 1, 6 };
            int[] tab1 = { 0, 0, 0, 0, 0, 12, 213,23,1,2,4,423,12,32,5435,323,323,52,12,554,45,34,22,344,64,3,34 };
            Console.WriteLine(WyznaczPrzywódce(tab));
            Console.WriteLine(WyznaczPrzywódce(tab1));

            Console.WriteLine(WyznaczPrzywódce_n_Rzędu(tab,2));
            Console.WriteLine(WyznaczPrzywódce_n_Rzędu(tab1,9));

            Console.ReadKey();
        }
    }
}
