using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            bool avslut = false;
            bool GodkäntTal = false;

            while (avslut == false)
            {
                Console.Write("Välj ett tal mellan 1 och 10: "); int tal = int.Parse(Console.ReadLine());

                Random slump = new Random();
                int Lyckotal = slump.Next(1, 11);

                if (tal <= 10 && tal > 0)
                {
                    Console.WriteLine($"\nHjulet landade på |{Lyckotal}|");

                    if (Lyckotal == tal)
                    {
                        Console.WriteLine("\nGrattis! Du vann!");
                        avslut = true;
                    }
                    else
                    {
                        Console.WriteLine("\nTyvärr vann du inte.\n");
                    }
                }
                else
                {
                    Console.WriteLine("\nDitt val var ej godkänt, försök igen.\n");
                    continue;
                }
            }
        }
    }
}
