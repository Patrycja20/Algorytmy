using System;

namespace Zadanie_5
{
    class Program
    {

        class thing
        {
            public int volume;
            public string name;
            public thing(string name, int volume)
            {
                this.name = name;
                this.volume = volume;
            }
            public string Demonstrate()
            { return name + " " + volume + " cm^3"; }
        }
        static void Max_capacity(thing[] volumes_of_things, int volume_of_the_bag)
        {
            Console.WriteLine("Mamy torbę: {0} cm^3. Wkładamy do niej:", volume_of_the_bag);
            for (int i = 0; i < volumes_of_things.Length; i++)
            {
                if (volume_of_the_bag >= volumes_of_things[i].volume)
                {
                    volume_of_the_bag -= volumes_of_things[i].volume;
                    Console.WriteLine(volumes_of_things[i].Demonstrate());
                }
            } Console.WriteLine("Pozostało miejsca w torbie: {0}", volume_of_the_bag);
        }
        static void Main(string[] args)
        {
            thing t1 = new thing("Laptop", 600);
            thing t2 = new thing("Książka1", 400);
            thing t3 = new thing("Książka2", 300);
            thing t4 = new thing("Sok", 250);
            thing t5 = new thing("Telefon", 80);
            thing t6 = new thing("Batonik", 40);
            thing t7 = new thing("Dokumenty", 15);
            thing t8 = new thing("Długopis1", 10);
            thing t9 = new thing("Długopis2", 10);
            thing t10 = new thing("Długopis3", 10);
            thing t11 = new thing("Długopis4", 10);
            thing t12 = new thing("Spinka", 7);

            thing[] things = { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12 };
            Max_capacity(things, 1200);


            Console.ReadKey();
        }
    }
}
