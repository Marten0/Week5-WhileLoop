using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajala sisestada PIN-koodi
            //programm võrdleb sisestatud PIN-koodi arvuga 1234
            // kui sisestatud PIN-kood on 1234
            //programm kuvab konsoolis "Tere tulemast!"
            //kui sisestatud PIN on vale, programm kuvab konsoolis
            //"Vale PIN.Proovi uuesti."
            //*katsete arv on piiramatu.

            //boolean --> true/false
            bool loopActive = true;

            while(loopActive)
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());
                
                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale PIN! Proovi uuesti.");
                }
            }

            Console.WriteLine("Kena päeva!");
        }
    }
}
