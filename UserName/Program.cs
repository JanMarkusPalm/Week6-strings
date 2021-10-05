using System;

namespace UserName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisestage palun oma eesnimi");
            string NIMI1 = Console.ReadLine();
            Console.WriteLine("sisestage palun oma perekonnanimi");
            string NIMI2 = Console.ReadLine();

            if (NIMI1.Length > NIMI2.Length)
            {
                Console.WriteLine("teie eesnimi on pikem kui teie perekonnanimi");
            }
            else if (NIMI2.Length > NIMI1.Length)
                {
                Console.WriteLine("teie perekonnanimi on pikem kui teie eesnimi");
            }
            else
            {
                Console.WriteLine("teil on sama pikkusega perekonnanimi ja eesnimi");
            }

        }
        
    }
}
