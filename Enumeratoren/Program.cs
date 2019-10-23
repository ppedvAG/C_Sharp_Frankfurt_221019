using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    //vgl. Enums.cs
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung einer Variablen vom Enumerator-Typ
            Wochentag heute = Wochentag.Dienstag;
            Console.WriteLine($"Heute ist {heute}.");

            //For-Schleife über die möglichen Zustande des Enumerators
            Console.WriteLine("Welcher Wochentag ist heute?");
            for (int i = 1; i <= Enum.GetValues(typeof(Wochentag)).Length; i++)
            {
                Console.WriteLine($"{i}: {(Wochentag)i}");
            }
            //Speichern einer Benutzereingabe (Int) als Enumerator
            //Cast: Int -> Wochentag
            heute = (Wochentag)int.Parse(Console.ReadLine());
            Console.WriteLine($"Heute ist also ein {heute}.");

            //SWITCHs sind eine verkürzte Schreibweise für IF-ELSE-Blöcke. Mögliche Zustände der übergebenen Variablen werden 
            //in den CASES definiert
            switch (heute)
            {
                case Wochentag.Montag:
                    //Jeder speziell definierte CASE muss mit einer BREAK-Anweisung beendet werden
                    Console.WriteLine("Schönen Wochenstart");
                    break;
                //Wenn in einem CASE keine Anweisungen geschrieben stehen kann auf den BREAK-Befehl verzichtet werden. In diesem Fall
                //springt das Programm in diesem CASE zum Nachfolgenden
                case Wochentag.Dienstag:
                case Wochentag.Mittwoch:
                case Wochentag.Donnerstag:
                    Console.WriteLine("Schönen Arbeitstag");
                    break;
                case Wochentag.Freitag:
                    Console.WriteLine("Fast geschafft");
                    break;
                //Wenn die übergebene Variable keinen der vordefinierten Zustände erreicht, wird der DEFAULT-Fall ausgeführt
                default:
                    Console.WriteLine("Schönes Wochenende");
                    break;
            }

            //Mittels des WHEN-Stichworts kann auf Eigenschaften des betrachteten Objekts näher eingegangen werden
            int a = 11;
            switch (a)
            {
                case var b when b > 10:
                    Console.WriteLine("Hallo");
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}
