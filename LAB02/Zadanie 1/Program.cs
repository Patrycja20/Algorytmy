using System;


namespace Zadanie_1
{
    class Program
    {
        static float Pomnóż(uint n, float x)
        {
            float wynik = 0;
            //NIEZMIENNIK
            // n > 0 i wynik =  (n' - 1) * x
            while (n > 0)
            {
                wynik += x;
                n--;
            //Wiemy, że na początku krokiem w pętli: n = n' - 1 oraz wynik += x
            //Po kolejnym przejściu pętli prawdziwe będzie, że: n = (n'-1)' - 1 oraz (wynik + x) += x
            //a więc cay czas niezmienniki będą spełnione
            } return wynik;
            //po skończeniu pętli n = 0, a więc przez to, że n na początku jest > 0 i jest całkowite oraz
            //z każdym przejściem pętli zmiejsza się o 1 to pętla zakończy sie 

        }
        static void Main(string[] args)
        {
            Console.WriteLine(Pomnóż(4, 0.2f));



            Console.ReadKey();
        }
    }
}
