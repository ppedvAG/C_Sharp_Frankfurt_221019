//Mittels der USING-Anweisungen kann ein vereinfachter Zugriff auf Programm-Externe Klassen ermöglicht werden. Es muss nun nicht mehr der
///vollständige Pfad angegeben werden, sondern es reicht der Klassenbezeichner
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//NAMESPACE: Die Umgebung unseres aktuellen Programms: Alles innerhalb des Namespaces gehört zu dem Programm
namespace HelloWorld
{
    //Die PROGRAM-Klasse beinhaltet den Einstiegspunkt des Programms und muss in jedem C#-Programm vorhanden sein
    class Program
    {
        //Die MAIN()-Methode ist der Einstiegspunkt jedes C#-Programms: Hier beginnt das Programm IMMER
        static void Main(string[] args)
        {   
            //Ausgabe eines String-Literals
            Console.WriteLine("Hello World");

            //Deklaration einer Integer-Variable 
            int alter;
            //Initialisierung der Integer-Variablen
            alter = 31;
            //Gleichzeitige Deklaration und Initialisierung einer String-Variablen
            string stadt = "Berlin";
            //Ausgabe der Variablen
            Console.WriteLine(alter);
            Console.WriteLine(stadt);

            ///Einfügen dynamischer Inhalte in Strings
            //'traditionell' über Stringverknüpfung (+-Operator)
            Console.WriteLine("Ich bin " + alter + " Jahre alt und komme aus " + stadt + ".");
            //Index (Variablen werden durch Inde-Platzhalter vertreten und später definiert)
            Console.WriteLine("Ich bin {0} Jahre alt und komme aus {1}.", alter, stadt);
            //$-Operator (Variablen werde direkt in {}-Klammern geschrieben 
            Console.WriteLine($"Ich bin {alter} Jahre alt und komme aus {stadt}.");

            //Ausgabe einer Berchnung in Strings
            int a = 15;
            int b = 23;
            Console.WriteLine($"Das Ergebnis ist {a + b}.");

            //String-Formatierung mittels Escape-Sequenzen
            Console.WriteLine($"Die ist ein \tTabulator und dies eine \nneue Zeile.");
            //Bsp für Pfadausgabe mittels Escape-Sequenzen
            Console.WriteLine($"Pfadausgabe: C:\\Programme\\Datei.docx");

            //String-Formatierung mittels VerbaTim-String (Einleitung mittels @ / Escape-Sequenzen sind nicht möglich, 
            ///dynamische Inhalte mittels $ schon)
            Console.WriteLine($@"Dies ist ein   Tabulator und dies eine
neue Zeile.");
            //Bsp für Pfadausgabe in Verbatim-String
            Console.WriteLine($@"Pfadausgabe: C:\Programme\Datei.docx");

            //Eingabe eines Strings durch den Benutzer und Abspeichern in einer String-Variablen
            string eingabe = Console.ReadLine();
            //Ausgabe
            Console.WriteLine($"Du hast '{eingabe}' eigegeben.");


            //Eingabe eines Strings, Umwandlung in einen Integer (Parse()-Funktion) und Abspeichern in einer Integer-Variablen
            Console.WriteLine("\nBitte gib eine Zahl ein:");
            eingabe = Console.ReadLine();
            int umgewandelteEingabe = int.Parse(eingabe);
            //Ausgabe
            Console.WriteLine($"Das Doppelte deiner Eingabe ist {2 * umgewandelteEingabe}.");

            //Bsp für Teilung durch 0 von Gleitkommazahlen
            double erg = 5.7 / 0;
            Console.WriteLine(erg);

            //Programmpause (nur für Debug-Mode benötigt)
            Console.ReadKey();
        }
    }
}
