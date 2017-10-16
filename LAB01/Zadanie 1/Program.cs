using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Zadanie_1
{
    class Program
    {
        static bool Czy_niemalejący(int[] tab)
        {
            for (int i = 0; i < tab.Length - 1; i++)
            {
                if (!(tab[i] <= tab[i + 1])) return false;
            }
            return true;
        }
        static bool Czy_niemalejący(List<int> lista)
        {
            for (int i = 0; i < lista.Count - 1; i++)
            {
                if (!(lista[i] <= lista[i + 1])) return false;
            }
            return true;
        }
        static List<int> Odczytaj(string plik)
        {
            StreamReader sr = new StreamReader(plik);
            List<int> lista = new List<int>();
            string linia;
            while ((linia = sr.ReadLine()) != null)
            {
                lista.Add(Convert.ToInt32(linia));
            }
            sr.Close();
            return lista;
        }
        static void Main(string[] args)
        {
            int[] tab = { 1, 12, 3, 4, 4, 5, 1 };
            List<int> lista = new List<int> { 1, 12, 3, 4, 4, 5, 1 };

            Stopwatch timetab = new Stopwatch();
            Stopwatch timelista = new Stopwatch();

            timetab.Start();
            Console.WriteLine("Wynik dla tablicy " + Czy_niemalejący(tab));
            timetab.Stop();
            timelista.Start();
            Console.WriteLine("Wynik dla listy " + Czy_niemalejący(lista));
            timelista.Stop();

            Console.WriteLine("Czas dla tablicy: " + timetab.ElapsedTicks);
            Console.WriteLine("Czas dla listy: " + timelista.ElapsedTicks);

            timelista.Reset();
            Console.WriteLine("Plik A1");
            lista = Odczytaj("A1.txt");
            timelista.Start();
            Console.WriteLine("Wynik " + Czy_niemalejący(lista));
            timelista.Stop();
            Console.WriteLine("Czas: " + timelista.ElapsedTicks);

            timelista.Reset();
            Console.WriteLine("Plik A2");
            lista = Odczytaj("A2.txt");
            timelista.Start();
            Console.WriteLine("Wynik " + Czy_niemalejący(lista));
            timelista.Stop();
            Console.WriteLine("Czas: " + timelista.ElapsedTicks);

            timelista.Reset();
            Console.WriteLine("Plik A3");
            lista = Odczytaj("A3.txt");
            timelista.Start();
            Console.WriteLine("Wynik " + Czy_niemalejący(lista));
            timelista.Stop();
            Console.WriteLine("Czas: " + timelista.ElapsedTicks);

            timelista.Reset();
            Console.WriteLine("Plik A4");
            lista = Odczytaj("A4.txt");
            timelista.Start();
            Console.WriteLine("Wynik " + Czy_niemalejący(lista));
            timelista.Stop();
            Console.WriteLine("Czas: " + timelista.ElapsedTicks);

            Console.ReadKey();
        }
    }
}
