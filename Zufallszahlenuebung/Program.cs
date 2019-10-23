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
            //Schleife zum Wdh des Programms
            do
            {
                //Deklarationen
                int benutzerZahl;
                Random generator;
                int zufallsZahl;

                //Initialisierung eines Random-Objekts mittels Konstruktor-Aufruf (vgl. Modul 04)
                generator = new Random();
                //Aufruf der Würfel-Funktion des Random-Objekts (beachte: 1. Grenze inklusiv / 2. Grenze exklusiv)
                zufallsZahl = generator.Next(1, 6);

                //Schleife für erneuten Versuch
                do
                {
                    //Abfrage des Tipps des Benutzers
                    Console.Write("Gib eine Zahl zwischen 1 und 5 ein: ");
                    benutzerZahl = int.Parse(Console.ReadLine());

                    //Vergleich Tipp <> Zufallszahl mittels If
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

                    //Bedingung für neuen Versuch (= falsche Zahl getippt)
                } while (zufallsZahl != benutzerZahl);

                //Bedingung für Wiederholung (Benutzer muss Taste 'Y' drücken)
                Console.WriteLine("Möchtest du noch einmal spielen? (Y/N)");
            } while (Console.ReadKey().Key == ConsoleKey.Y);
        }
    }
}
