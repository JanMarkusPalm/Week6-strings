using System;

namespace SubstituteCharacter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Mis on su eesnimi");
            string NIMI1 = Console.ReadLine();
            Console.WriteLine("sisestage palun oma perekonnanimi");
            string NIMI2 = Console.ReadLine();
            string NIMkokku = NIMI1 + NIMI2.ToLower();
            NIMkokku = NIMkokku.Replace('a', '*');
            Console.WriteLine(NIMkokku);

        }
    }
}
