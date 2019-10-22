using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrollstrukturen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deklaration und Initialisierung von Beispiel-Variablen
            int a = 56;
            int b = 26;

            //IF-ELSEIF-ELSE-Block
            ///Das Programm wird den ersten Block ausführen, bei welchem er auf eine wahre Bedingung trifft und dann am Ende des Blocks mit
            ///dem Code weiter machen
            if (a < b)
            {
                Console.WriteLine("A ist kleiner B");
            }
            else if (a > b)
            {
                //Es kann beliebig viele ELSE-IF-Blöcke geben
                Console.WriteLine("A ist größer als B");
            }
            else
            {
                //Wenn keine der Bedingungen wahr ist, wird der (optionale) ELSE-Block ausgeführt
                Console.WriteLine("A ist gleich B");
            }

            //Kurznotation:
            //(Bedingung) ? TrueAusgabe : FalseAusgabe
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            //WHILE-Schleife
            ///Die WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Ist die Bedingung von vornherein unwahr, dann wird die Schleife
            ///übersprungen
            while (a > b)
            {
                Console.WriteLine($"{a} ist größer als {b}");
                a -= 10;

                //Mit der BREAK-Anweisung wird die Schleife verlassen und der Code wird fortgesetzt.
                if (a == 36) break;
            }

            a = 120;

            //DO-WHILE-Schleife
            ///Auch die DO-WHILE-Schleife wird wiederholt, solange die Bedingung wahr ist. Allerdings wird die Bedingung erst am Schleifen_
            ///ende geprüft, weshalb die Schleife mindestens einmal durchläuft.
            do
            {
                Console.WriteLine($"{a} ist kleiner als 100");
                a *= 2;

                //Der CONTINUE-Befehl beendet den aktuellen Schleifendurchlauf und lässt erneut die Bedingung prüfen. Ist die Bedingung wahr
                ///beginnt ein neuer Durchlauf
                continue;

                Console.WriteLine("Wird niemals ausgeführt");

            } while (a < 100);

            //FOR-Schleife
            ///Der FOR-Schleife wird ein Laufindex (i) sowie eine Bedingung und eine Anweisung übergeben. Am Ende jedes Durchlaufes wird die
            ///Anweisung ausgeführt. Wenn die Bedingung nicht (mehr) wahr ist, wird kein (weiterer) Schleifendurchlauf begonnen.
            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine($"Dies ist der {i}. Durchgang.");
            }

            //ARRAYS
            ///Arrays sind Collections, welche mehrere Variablen eines Datentyps speichern können. Die Größe des Arrays muss bei der
            ///Initialisierung entweder durch eine Zahl oder durch eine bestimmte Anzahl von spezifischen Elementen definiert werden.
            int[] zahlenarray = { 1, 789, 12, 45, 36, 78, 1245, 2, 0, 12 };

            //Der Zurgiff auf einzelne Array-Positionen erfolgt durch einen Nullbasierten Index
            Console.WriteLine(zahlenarray[3]);
            zahlenarray[8] = 123;

            //Iteration über ein Array mittels For-Schleife
            for (int i = 0; i < zahlenarray.Length; i++)
            {
                Console.WriteLine(zahlenarray[i]);
            }

            //FOREACH-Schleifen können über Collections laufen und sprechen dabei jedes Element genau einmal an
            foreach (int item in zahlenarray)
            {
                Console.WriteLine(item);
            }

            //Mehrdimensionales Array
            int[,] zweiDimArray = new int[10, 10];

            for (int i = 0; i < zweiDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < zweiDimArray.GetLength(1); j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }
            
            Console.WriteLine(zweiDimArray[4,8]);

            //String als Char-Array
            string beispiel = "Hallo";
            Console.WriteLine(beispiel[2]);


            Console.ReadKey();

        }
    }
}
