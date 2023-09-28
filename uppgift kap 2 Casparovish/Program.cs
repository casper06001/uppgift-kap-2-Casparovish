using System;
namespace uppgift_kapitel_2_casparovish
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilken är din favorit bok?");
            string x = Console.ReadLine();
            string favoritbok = x;
            Console.WriteLine(favoritbok + " är en fantastisk bok!");
            Console.ReadKey();
        }
    }
}