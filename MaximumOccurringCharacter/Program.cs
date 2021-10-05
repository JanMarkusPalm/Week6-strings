using System;

namespace MaximumOccurringCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime ja perekonnanime
            //programm salvestab mõlemad eesnime ja perekonnanime muutujasse fullname
            //programm kuvab kõige sagedamni ilmuva tähe
            Console.WriteLine("Sisesta palun oma eesnimi ja perekonnanimi");
            string NIMI1 = Console.ReadLine();
            string NIMI2 = Console.ReadLine();
            string fullname = NIMI1 + NIMI2;
            Console.WriteLine($"su nimi on {fullname}");
        }
    }
}
