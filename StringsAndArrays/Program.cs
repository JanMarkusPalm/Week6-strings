using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kysib kasutajalt sisestada eesnimi
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Palun sisestage enda eesnimi");
            string NIMI =Console.ReadLine();
           
            {
                Console.WriteLine($"sinu nimi on {NIMI.Length} sümbolit pikk.");
            }
            

        }
    }
}
