using System;

namespace FullNameReversed
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su eesnimi");
            string NIMI1 = Console.ReadLine();
            Console.WriteLine("sisestage palun oma perekonnanimi");
            string NIMI2 = Console.ReadLine();

            for (int i = NIMI1.Length - 1; i >= 0; i--) 
            {
                Console.WriteLine(NIMI1[i]);
            }
            for (int i = NIMI2.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(NIMI2[i]);
            }

        }
    }
}
