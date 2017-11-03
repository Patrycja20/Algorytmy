using System;

//Zadanie 0.
// Co robi następująca metoda? Jaka jest złożoność?
class Program
{
    static int fun1(int n)
    {
        if (n == 1)
            return 0;
        else
            return 1 + fun1(n / 2);
    }
    // podłoga log n

    static void Main(string[] args)
    {
        Console.WriteLine(fun1(1));
        Console.WriteLine(fun1(2));
        Console.WriteLine(fun1(3));
        Console.WriteLine(fun1(4));
        Console.WriteLine(fun1(255));
        Console.WriteLine(fun1(256));
        Console.WriteLine(fun1(257));
        Console.WriteLine(fun1(512));

        Console.ReadKey();
    }
}

