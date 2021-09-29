using System;

namespace week3exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //tingimused sisseastumiseks:
            //miinimum matemaatikas 85p:
            //miinimum keemias 90p:
            //miinimum bioloogias 95p:
            //programm küsib kasutajal sisestada eksami punktid ja otsustada kas kasutaja saab arstiks õppida

            Console.WriteLine("sisesta matemaatika eksami tulemus.");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta keemia eksami tulemus");
            int chemistry = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta bioloogia eksami tulemus");
            int biology = Convert.ToInt32(Console.ReadLine());

            if(math >= 85 && chemistry >= 90 && biology >= 95)
            {
                Console.WriteLine("tubli! saad arstiks õppida.");
            }
            else
            {
                Console.WriteLine("proovi järgmine aasta");
            }


        }
    }
}
