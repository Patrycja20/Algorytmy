using System;

namespace Zadanie_2
{
    class Program
    {
        static int WyznaczPrzywódce(int[] A)
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
            return p;
        }

        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 2, 4, 5, 6, 1, 1, 1, 1, 6, 6, 1, 1, 1, 6 };
            int[] tab1 = { 0,0,0,0,0,12,4123,1234,4123,4123,4123,4123,4123};
            Console.WriteLine("Przywódca tego ciągu: {0}", WyznaczPrzywódce(tab));
            Console.WriteLine("Przywódca tego ciągu: {0}", WyznaczPrzywódce(tab1));

            Console.ReadKey();
        }
    }
}
