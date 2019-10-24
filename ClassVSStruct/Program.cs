using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVSStruct
{
    //vgl. Modul 4 -> Fahrzeug
    class KlassenPerson
    {
        public string name;
        public int alter;

        public KlassenPerson(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }

    //STRUCTS sind Klassenähnliche Konstrukte, welche nicht, wie Klassen, als Referenztypen behandelt werden, sondern ein Wertetyp sind. D.h
    //bei Übergabe eines Structs an eine Methode oder Variable wird eine Kopie dieses Objekts erstellt
    struct StructPerson
    {
        public string name;
        public int alter;

        public StructPerson(string name, int alter)
        {
            this.name = name;
            this.alter = alter;
        }
    }

    class Program
    {
        public static void Altern(KlassenPerson kPerson)
        {
            kPerson.alter++;
        }

        public static void Altern (StructPerson sPerson)
        {
            sPerson.alter++;
        }

        //Mittels des REF-Stichworts können Wertetypen als Referenz an Methoden übergeben werden. D.h. die übergebene Speicherstelle selbst 
        ///wird manipuliert und nicht, wie normalerweise bei Wertetypen, eine Kopie des Werts.
        public static void Altern(ref StructPerson sPerson)
        {
            sPerson.alter++;
        }

        static void Main(string[] args)
        {
            //Erstellung von Objekten
            KlassenPerson kPerson = new KlassenPerson("Heiko", 35);
            StructPerson sPerson = new StructPerson("Anna", 35);

            //Ausgabe
            Console.WriteLine(kPerson.alter);
            Console.WriteLine(sPerson.alter);

            //Funktionsaufruf
            Altern(kPerson);
            Altern(sPerson);

            //Erneute Ausgabe: Nur das Klassenobjekt (Referenztyp) hat sich verändert
            Console.WriteLine(kPerson.alter);
            Console.WriteLine(sPerson.alter);

            //Übergabe des Wertetyps als Refernz mittels Ref-Stichwort
            Altern(ref sPerson);
            Console.WriteLine(sPerson.alter);

            Console.ReadKey();

        }
    }
}
