using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahlenuebung
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int benutzerZahl;
                Random generator;
                int zufallsZahl;

                generator = new Random();
                zufallsZahl = generator.Next(1, 6);

                do
                {

                    Console.Write("Gib eine Zahl zwischen 1 und 5 ein: ");
                    benutzerZahl = int.Parse(Console.ReadLine());


                    if (zufallsZahl < benutzerZahl)
                    {
                        Console.WriteLine("Deine Zahl ist zu groß.");
                    }
                    else if (zufallsZahl > benutzerZahl)
                    {
                        Console.WriteLine("Deine Zahl ist zu klein.");
                    }
                    else
                    {
                        Console.WriteLine("Du hast richtig getippt.");
                    }

                } while (zufallsZahl != benutzerZahl);

                Console.WriteLine("Möchtest du noch einmal spielen? (Y/N)");
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
    }
}
