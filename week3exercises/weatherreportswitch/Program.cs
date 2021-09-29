using System;

namespace weatherreportswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("mitu kradi õues on?");
            int temp = Convert.ToInt32(Console.ReadLine());

            switch(temp)
            {
                case var _ when temp < 0:
                    Console.WriteLine("freezing cold");
                    break;
                case var _ when (temp > 0 && temp < 10):
                    Console.WriteLine("cold");
                    break;
                case var _ when (temp >= 10 && temp < 20):
                    Console.WriteLine("chilly");
                    break;
                case var _ when (temp >= 20 && temp < 30):
                    Console.WriteLine("nice");
                    break;
                case var _ when (temp >= 30 && temp < 35):
                        Console.WriteLine("hot");
                    break;
             default:
                    Console.WriteLine("boiling hot");
                    break;

            }

        }
    }
}
