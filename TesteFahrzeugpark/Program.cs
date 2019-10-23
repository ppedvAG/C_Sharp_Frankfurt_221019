using System;
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

            PKW pkw1 = new PKW("BMW", 250, 23000, 5);
            Flugzeug flugzeug1 = new Flugzeug("Boing", 750, 3000000, 9990);
            Schiff schiff1 = new Schiff("Titanic", 40, 3500000, Schiff.SchiffsTreibstoff.Dampf);

            BeladeFahrzeuge(pkw1, flugzeug1);
            BeladeFahrzeuge(flugzeug1, schiff1);
            BeladeFahrzeuge(schiff1, pkw1);

            Console.WriteLine("\n" + schiff1.BeschreibeMich());

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
