using System;

namespace Zadanie_4
{
    class Program
    {
        static int Division(int[] array, int first, int last)
        {
            int i, j, key, tmp, index;
            index = (first+last)/2;//jako klucz weźmiemy element środkowy
            key = array[index];

            tmp = array[index];//wstawiamy go na koniec
            array[index] = array[last];
            array[last] = tmp;
            i = first;//zamiany zaczynamy od początku
            for (j = first; j < last; j++)
            {
                if (array[j] <= key)
                { tmp = array[i]; array[i] = array[j]; array[j] = tmp; i++; }
            }
            tmp = array[i];//na zakończenie wstawiamy nasz klucz na właściwe miejsce
            array[i] = array[last];
            array[last] = tmp;
            return i;//zwracamy miejsce podziału
        }
        static int Hoare(int[] array, int first, int last, int k)
        {
            if (first == last) return array[first-1];
            //jeśli doszliśmy po podziałach do tego samego elementu to mamy nasz szukany k-ty element co do wielkości
            int i = Division(array, first, last);
            if (i == k) return array[i-1];//sprawdzamy, czy nasze miejsce podziału jest naszym k-tym miejscem
            if (i < k) return Hoare(array, i + 1, last, k);//jeśli nasze miejsce podziału jest mniejsze od k-tego miejsca to przechodzimy do drugiej połówki 
            else return Hoare(array, first, i - 1, k);//tu jest odwrotnie
        }
        static void View(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.Write(array[i] + " ");
            } Console.WriteLine(array[array.Length - 1]);
        }
        static void Main(string[] args)
        {
            int[] random = new int[] { -19, 1, 1, 8, 7, -5, 3, 5, 4, 6 };
            int[] increasing = new int[] { 1, 2, 3, 4, 6, 7, 8, 17, 25, 29 };
            int[] decreasing = new int[] { 19, 10, 5, 4, 3, 1, 0, -1, -2, -5 };

            View(random);
            Console.WriteLine("5-ty element co do wielkości tej tablicy to {0}\n",Hoare(random,0,random.Length-1,5));
            View(increasing);
            Console.WriteLine("8-y element co do wielkości tej tablicy to {0}\n",Hoare(increasing,0,increasing.Length-1,8));
            View(decreasing);
            Console.WriteLine("Ostatni element co do wielkości tej tablicy to {0}",Hoare(decreasing,0,decreasing.Length-1,decreasing.Length-1));

            Console.ReadKey();
        }
    }
}
