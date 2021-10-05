using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string Helloworld = "Hello World";
            string parttolookfor = "hello";

            bool isThere;

            isThere = Helloworld.ToLower().Contains(parttolookfor);

            if (isThere)
            {
                Console.WriteLine($"Leidsin {parttolookfor} üles!");
            }
            else
            {
                Console.WriteLine($"Ei leitud {parttolookfor}");
            }


        }
    }
}
