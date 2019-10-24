using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fahrzeugpark;

namespace TesteFahrzeugpark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ändern des durch COnsole verwendeten Zeichensatzes auf Unicode (damit das €-Zeichen angezeigt werden kann)
            Console.OutputEncoding = Encoding.UTF8;

            #region Modul4: OOP

            ////Instanziierung der Fahrzeuge
            //Fahrzeug fz1 = new Fahrzeug("BMW", 200);
            //Fahrzeug fz2 = new Fahrzeug("BMW", 200);

            ////Ausgabe von fz1
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");

            ////Veränderung des Namens von fz1
            //fz1.Name = "VW";

            ////Ausgabe der Fahrzeugeigenschaften (fz1 wurde verändert, fz2 nicht)
            //Console.WriteLine(fz1.Name + ": " + fz1.MaxGeschwindigkeit + "km/h");
            //Console.WriteLine(fz2.Name + ": " + fz2.MaxGeschwindigkeit + "km/h");
            ////A8sgabe der BeschreibeMich-Methode von fz1
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Neuzuweisung der fz2-Variable auf Objekt in fz1 (beide Variablen zeigen auf dasselbe Objekt)
            //fz2 = fz1;

            ////manueller Aufruf der GarbageCollection
            //GC.Collect(); 

            #endregion

            #region Lab04 Fahrzeug_Klasse

            ////Deklaration einer Fahrzeug-Variablen und Initialisierung mittels einer Fahrzeug-Instanz
            //Fahrzeug fz1 = new Fahrzeug("Mercedes", 190, 23000);
            ////Ausführen der BeschreibeMich()-Methode des Fahrzeugs und Ausgabe in der Konsole
            //Console.WriteLine(fz1.BeschreibeMich());

            ////Diverse Methodenausführungen
            //fz1.StarteMotor();
            //fz1.Beschleunige(120);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.Beschleunige(300);
            //Console.WriteLine(fz1.BeschreibeMich());

            //fz1.StoppeMotor();
            //Console.WriteLine(fz1.BeschreibeMich());

            #endregion

            #region Lab05 PKW-, Schiff- und Flugzeug-Klasse

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Console.WriteLine(pkw1.BeschreibeMich());

            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);
            //Console.WriteLine(schiff1.BeschreibeMich());

            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Console.WriteLine(flugzeug1.BeschreibeMich());

            //Console.WriteLine(Fahrzeug.ZeigeAnzahlFahrzeuge());

            #endregion

            #region Modul06 Polymorphismus

            //PKW pkw1 = new PKW("BMW", 260, 30000, 3);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 990, 30000000, 8990);

            //pkw1.Crash();

            //Fahrzeug fz1;
            //IBewegbar bewegbaresObjekt;

            //fz1 = flugzeug1;

            //fz1.Beschleunige(2);
            //fz1 = pkw1;

            //bewegbaresObjekt = pkw1;

            //bewegbaresObjekt.AnzahlRaeder = 5;

            //if(bewegbaresObjekt is Flugzeug)
            //    flugzeug1 = (Flugzeug)bewegbaresObjekt;

            #endregion

            #region Lab06 IBeladbar

            //PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            //Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            //Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            //BeladeFahrzeuge(pkw1, flugzeug1);
            //BeladeFahrzeuge(flugzeug1, schiff1);
            //BeladeFahrzeuge(schiff1, pkw1);

            //Console.WriteLine("\n" + schiff1.BeschreibeMich());

            #endregion

            #region Modul07 Generische Listen

            ////Deklaration und Initialisierung einer Liste von Strings
            //List<string> Staedteliste = new List<string>();

            ////Ausgabe der Länge der LIste
            //Console.WriteLine(Staedteliste.Count);

            ////Hinzufügen von Listeneinträgen
            //Staedteliste.Add("Frankfurt");
            //Staedteliste.Add("Berlin");
            //Staedteliste.Add("Köln");
            //Staedteliste.Add("München");
            //Staedteliste.Add("Hamburg");

            //Console.WriteLine(Staedteliste.Count);

            ////Ausgabe der 4. Listenposition
            //Console.WriteLine(Staedteliste[3]);

            ////Manipulation der 4. Listenposition
            //Staedteliste[3] = "Dresden";

            ////Schleife über die Liste
            //foreach (var item in Staedteliste)
            //{
            //    Console.WriteLine(item);
            //}

            ////Löschen des Eintrags 'Köln' (Nachfolgende Einträge rücken nach oben)
            //Staedteliste.Remove("Köln");


            ////Deklaration und Initialisierung eines Dictionarys (Key: Int, Value: String)
            //Dictionary<int, string> Dict = new Dictionary<int, string>();

            ////Hinzufügen von Dictionary-Einträgen
            //Dict.Add(1, "Hallo");
            //Dict.Add(5, "Moin");
            //Dict.Add(15, "Servus");

            ////Ausgabe des Eintrags mit Key '5'
            //Console.WriteLine(Dict[5]);

            ////Schleife über Dictionary
            //foreach (KeyValuePair<int, string> item in Dict)
            //{
            //    Console.WriteLine($"{item.Key}: {item.Value}");
            //}

            ////Deklaration und Initialisierung eines Hastables
            //Hashtable ht = new Hashtable();

            ////Hinzufügen von Einträgen
            //ht.Add("Hallo", "Tschüss");
            //ht.Add(45, "Moin"); 
            #endregion

            #region Lab07_ZufälligeFahrzeuglisten

            //Deklaration der benötigten Variablen und und Initialisierung mit Instanzen der benötigten Objekte
            Random generator = new Random();
            Queue<Fahrzeug> fzQueue = new Queue<Fahrzeug>();
            Stack<Fahrzeug> fzStack = new Stack<Fahrzeug>();
            Dictionary<Fahrzeug, Fahrzeug> fzDict = new Dictionary<Fahrzeug, Fahrzeug>();
            //Deklaration und Initialisierung einer Variablen zur Bestimmung der Anzahl der Durchläufe 
            int AnzahlFZs = 10;

            //Schleife zur zufälligen Befüllung von Queue und Stack
            for (int i = 0; i < AnzahlFZs; i++)
            {
                //Würfeln einer zufälligen Zahl im Switch
                switch (generator.Next(1, 4))
                {
                    //Erzeugung von Objekten je nach zufälliger Zahl
                    case 1:
                        fzQueue.Enqueue(new Flugzeug($"Boing_Q{i}", 800, 3600000, 9999));
                        fzStack.Push(new Flugzeug($"Boing_S{i}", 800, 3600000, 9999));
                        break;
                    case 2:
                        fzQueue.Enqueue(new Schiff($"Titanic_Q{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
                        fzStack.Push(new Schiff($"Titanic_S{i}", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf));
                        break;
                    case 3:
                        fzQueue.Enqueue(PKW.ErzeugeZufälligenPKW($"_Q{i}"));
                        fzStack.Push(PKW.ErzeugeZufälligenPKW($"_S{i}"));
                        break;
                }
            }

            //Schleife zur Prüfung auf das Interface und Befüllung des Dictionaries
            for (int i = 0; i < AnzahlFZs; i++)
            {
                //Prüfung, ob das Interface vorhanden ist (mittels Peek(), da die Objekte noch benötigt werden)...
                if (fzQueue.Peek() is IBeladbar)
                {
                    //...wenn ja, dann Cast in das Interface und Ausführung der Belade()-Methode (mittels Peek())...
                    ((IBeladbar)fzQueue.Peek()).Belade(fzStack.Peek());
                    //...sowie Hinzufügen zum Dictionary (mittels Pop()/Dequeue(), um beim nächsten Durchlauf andere Objekte an den Spitzen zu haben)
                    fzDict.Add(fzQueue.Dequeue(), fzStack.Pop());
                }
                else
                {
                    //... wenn nein, dann Löschung der obersten Objekte (mittels Pop()/Dequeue())
                    fzQueue.Dequeue();
                    fzStack.Pop();
                }
            }

            //Programmpause
            Console.ReadKey();
            Console.WriteLine("\n----------LADELISTE----------");

            //Schleife zur Ausgabe des Dictionaries
            foreach (var item in fzDict)
            {
                Console.WriteLine($"'{item.Key.Name}' hat '{item.Value.Name}' geladen.");
            }

            #endregion

            Console.ReadKey();
        }

        //Methode Lab06
        public static void BeladeFahrzeuge(Fahrzeug fz1, Fahrzeug fz2)
        {
            if (fz1 is IBeladbar)
            {
                ((IBeladbar)fz1).Belade(fz2);
            }
            else if (fz2 is IBeladbar)
            {
                (fz2 as IBeladbar).Belade(fz1);
            }
            else
                Console.WriteLine("Keines der Fahrzeuge kann ein Fahrzeug transportieren.");
        }
    }
}
