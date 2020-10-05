using System;

namespace prov
{
    class Program
    {
        static void Main(string[] args)
        {

            string svar;

            Console.WriteLine("Välkommen till sänka skepp!");
            Console.WriteLine("Skriv in en koordinat mellan 1 och 10");

            svar = Console.ReadLine();

            if (svar == "1" || svar == "2" || svar == "3" || svar == "4" || svar == "10")
            {
                Console.WriteLine("Miss");
            }
            else if (svar == "5" || svar == "6" || svar == "8" || svar == "9")
            {
                Console.WriteLine("Near miss");
            }
            else if (svar == "7")
            {
                Console.WriteLine("Hit!");
            }

            Console.ReadLine();
        }
    }
}
