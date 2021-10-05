using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm kuvab sõne pikkust Lenght
            //foreach loop
            //foreach (element in string)

            string helloworld = "nice";

            int counter = 0;

            foreach (char character in helloworld)
            {
                counter = counter + 1;
                //counter++;
            }
            Console.WriteLine($"{helloworld} on {counter} sümbolit pikk.");

        }
    }
}
