using System;

namespace weathercheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //program küsib mitu kraadi õues on;
            //kui õues on rohkem kui 35 kraadi, progrmm kuvab "boiling hot"
            //kui õues on 30 kuni 35 kraadi, programm kuvab "hot";
            //kui õues on 20 kni 30 kraadi, programm kuvab "nice";
            //kui õues on 10 kuni 20 kraadi, programm kuvab "chilly";
            //kui õues on 0 kuni 10 kraadi, programm kuvab "cold";
            //kui õues on alla 0 kraadi, programm kuvab "freezing cold".

            Console.WriteLine("mitu kradi õues on?");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 35)
            {
                Console.WriteLine("boiling hot");
            }
            else if (temp >= 30 && temp <35)
            {
                Console.WriteLine("hot");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("nice");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("chilly");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("cold");
            }
            else
            {
                Console.WriteLine("freezing");
            }

        }
    }
}
