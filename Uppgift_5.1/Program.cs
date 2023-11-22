using System;

namespace Uppgift_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namnArray = new string[5];

            Console.WriteLine("Skriv in 5 namn på var sin rad");

            for (int i = 0; i < namnArray.Length; i++)
            {
                namnArray[i] = Console.ReadLine();
            }

            Console.WriteLine("\nNamnen du skrev in var:");
            foreach (string namn in namnArray)
            {
                Console.WriteLine(namn);
            }

            Console.WriteLine("\nTryck på valfri knapp för att avsluta");
            Console.ReadKey();
        }
    }
}