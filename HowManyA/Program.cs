using System;

namespace HowManyA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis on su eesnimi");
            string NIMI1 = Console.ReadLine();
            Console.WriteLine("sisestage palun oma perekonnanimi");
            string NIMI2 = Console.ReadLine();

            //int counter = 0;

            string NIMkokku = NIMI1 + NIMI2;

            /*foreach (char character in NIMkokku)
            {
                if (character == 'a')
                {
                    counter++;
                }
            }
            Console.WriteLine($"{NIMkokku}s on {counter} A tähte.");
            */

            //-------------------------------------------------------------------------------
            //---------------------WHILE-----------------------------------------------------
            /* int counter = 0;
             int i = NIMkokku.Length-1;


             while (i>=0)

             {
                 Console.WriteLine(NIMkokku[i]);
                 if (NIMkokku[i] == 'a')
                 {

                     counter++;
                 }
                 i--;
             }
             Console.WriteLine($"sinu nimes on {counter} a- tähte");
            */
            int counter = 0;
            for (int i = 0; i <NIMkokku.Length; i++)
            {
                if(NIMkokku[i]=='a')
                {
                    counter++;
                }
              
            }
            Console.WriteLine($"Sinu nimes on {counter} a tähte.");
        }
    }
}
