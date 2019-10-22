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
            int a = 56;
            int b = 26;

            if (a < b)
            {
                Console.WriteLine("A ist kleiner B");
            }
            else if (a > b)
            {
                Console.WriteLine("A ist größer als B");
            }
            else
            {
                Console.WriteLine("A ist gleich B");
            }

            //Kurznotation:
            string ergebnis = (a == b) ? "A ist gleich B" : "A ist ungleich B";

            while (a > b)
            {
                Console.WriteLine($"{a} ist größer als {b}");
                a -= 10;

                if (a == 36) break;
            }

            a = 120;

            do
            {
                Console.WriteLine($"{a} ist kleiner als 100");
                a *= 2;

                continue;

                Console.WriteLine("Wird niemals ausgeführt");

            } while (a < 100);


            for (int i = 0; i < 100; i += 2)
            {
                Console.WriteLine($"Dies ist der {i}. Durchgang.");
            }

            int[] zahlenarray = { 1, 789, 12, 45, 36, 78, 1245, 2, 0, 12 };

            Console.WriteLine(zahlenarray[3]);
            zahlenarray[8] = 123;

            for (int i = 0; i < zahlenarray.Length; i++)
            {
                Console.WriteLine(zahlenarray[i]);
            }

            foreach (int item in zahlenarray)
            {
                Console.WriteLine(item);
            }

            int[,] zweiDimArray = new int[10, 10];

            for (int i = 0; i < zweiDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < zweiDimArray.GetLength(1); j++)
                {
                    zweiDimArray[i, j] = i * j;
                }
            }
            
            Console.WriteLine(zweiDimArray[4,8]);


            string beispiel = "Hallo";

            Console.WriteLine(beispiel[2]);


            Console.ReadKey();

        }
    }
}
