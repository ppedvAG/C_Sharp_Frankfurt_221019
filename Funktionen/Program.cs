﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funktionen
{
    class Program
    {
        //Jede Funktion/Methode besteht aus einem Kopf und einem Körper
        ///Der Kopf besteht aus den MODIFIERN (public static), dem RÜCKGABEWERT (int), dem NAMEN (Addiere) sowie den ÜBERGABEPARAMETERN
        ///Wird einem Parameter mittels =-Zeichen ein Defaultwert zugewiesen wird dieser Parameter OPTIONAL und muss bei Aufruf nicht zwangs-
        ///läufig mitgegeben werden. OPTIONALE Parameter müssen am Ende der Parameter stehen.
        public static int Addiere(int a, int b, int c = 0, int d = 0)
        {
            //Der RETURN-Befehl weist die Methode an einen Wert als Rückgabewert an den Aufrufe zurückzugeben
            return a + b + c + d;
        }

        //Funktion, welche den gleichen Bezeichner haben, nennt man ÜBERLADENE Funktionen. Diese müssen sich in Anzahl und/oder Art der 
        ///Übergabeparameter unterscheiden, damit der Aufruf eindeutig ist.
        public static double Addiere(double a, double b)
        {
            return a + b;
        }

        //Das PARAMS-Stichwort erlaubt die Übergabe einer beliebige Anzahl von gleichartigen Daten, welche innerhalb
        //der Methode als Array interpretiert werden
        public static int AddiereBeliebigeAnzahl(params int[] summanden)
        {
            int summe = 0;
            for (int i = 0; i < summanden.Length; i++)
            {
                summe += summanden[i];
            }
            return summe;
        }

        static void Main(string[] args)
        {
            //Aufruf der Addiere(int,int)-Funktion (optinale Parameter werden auf ihren Default-Wert gesetzt)
            int summe = Addiere(45, 12);

            //Aufruf der gleichen Funktion unter verwendung der optionalen Parameter
            summe = Addiere(12, 45, 78, 89);

            //Ausgabe
            Console.WriteLine(summe);

            //Aufruf der Addiere(double,double)-Funktion
            double summeDouble = Addiere(4.7, 8.7);

            //Aufruf der Params-Funktion mit Übergabe eines Arrays, einer bleiebigen Anzahl von Ints und nichts
            summe = AddiereBeliebigeAnzahl(new int[] { 2, 4, 5 });
            summe = AddiereBeliebigeAnzahl(7, 8, 9, 45, 12, 741);
            summe = AddiereBeliebigeAnzahl();

            Console.ReadKey();
        }

    }
}
