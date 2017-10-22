using System;
using System.Collections.Generic;

namespace Zadanie_3
{
    class Program
    {
        class Zajęcia
        {
            public string nazwa;
            public double start;
            public double koniec;
            public Zajęcia(string nazwa, double start, double koniec)
            {
                this.nazwa = nazwa;
                this.start = start;
                this.koniec = koniec;
            }
            public string zwroc()
            {
                return start + " - " + koniec + " " + nazwa;
            }
            public static Zajęcia[] Sortuj(Zajęcia[] zajęcia)
            {
                for (int i = 0; i < zajęcia.Length - 1; i++)
                {
                    for (int k = i + 1; k < zajęcia.Length; k++)
                    {
                        if (zajęcia[i].start > zajęcia[k].start || (zajęcia[i].start == zajęcia[k].start && zajęcia[i].koniec > zajęcia[k].koniec)) { Zajęcia p = zajęcia[i]; zajęcia[i] = zajęcia[k]; zajęcia[k] = p; }
                    }
                }
                return zajęcia;
            }
        }

        static List<Zajęcia> Wybór_podzbiór_zajęć(Zajęcia[] zajęcia)
        {
            List<Zajęcia> zgodne = new List<Zajęcia>();
            zajęcia = Zajęcia.Sortuj(zajęcia);
            zgodne.Add(zajęcia[0]);
            for (int i = 1; i < zajęcia.Length; i++)
            {
                if (zajęcia[i].start >= zgodne[zgodne.Count - 1].koniec) zgodne.Add(zajęcia[i]);
            }
            return zgodne;
        }

        static void Main(string[] args)
        {
            Zajęcia z1 = new Zajęcia("Basen",7.40,9.10);
            Zajęcia z2 = new Zajęcia("Angielski", 8.30, 9);
            Zajęcia z3 = new Zajęcia("Siłownia", 19.15, 20);
            Zajęcia z4 = new Zajęcia("Szachy", 18.20, 19.20);
            Zajęcia z5 = new Zajęcia("Poker", 14.30, 16);
            Zajęcia z6 = new Zajęcia("Japoński", 17, 18.35);
            Zajęcia z7 = new Zajęcia("Badminton", 7, 9);

            Zajęcia[] zajęcia = { z1, z2, z3, z4, z5, z6, z7 };
            List<Zajęcia> zgodne = Wybór_podzbiór_zajęć(zajęcia);
            foreach (var item in zgodne)
            {
                Console.WriteLine(item.zwroc());
            }

            Console.ReadKey();
        }
    }
}
