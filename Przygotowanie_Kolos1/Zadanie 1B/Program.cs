using System;

namespace Zadanie_1B
{
    class Program
    {
        //Jaki jest niezmiennik pętli w poniższej metodzie?
        //Odp.Jest to parzysta, bądź nieparzysta liczba parzystych i nieparzystych elementów w tablicy
        //Jaka jest pesymistyczna złożoność obliczeniowa tego algorytmu?
        //Odp.n-1
        static int Metoda(int[] L)
        {
            var r = new Random();//jakaś wartość losowa
            int n = L.Length;//n ilość elementów
            while (n > 1)//warunek stopu
            {
                int i = r.Next(n);
                int x = L[i];//bierzemy losowy element z tablicy
                L[i] = L[n - 1];
                L[n - 1] = x;//zamieniamy go miejscem z ostatnim
                int j = r.Next(n - 1);//znowu losujemy, ale nie bierzemy już pod uwagę wcześniej wylosowanego
                int y = L[j];
                L[j] = L[n - 2];
                L[n - 2] = y;// zamieniamy go miejscem z przedostatnim
                if (x % 2 != y % 2)// sprawdzamy czy oba wylosowane elementy są parzyste
                {//jeśli tylko jeden z nich jest parzysty to odkładamy go, a nieparzysty zostawiamy
                    if (x % 2 == 1)
                        L[n - 2] = x;
                    else
                        L[n - 2] = y;
                    n--;
                }// jeśli oba są parzyste/nieparzyste to odkładamy je
                else n = n - 2;
            }
            return L[0];//zwracamy element, który został
        }
        static void Main(string[] args)
        {


            Console.ReadKey();
        }
    }
}
