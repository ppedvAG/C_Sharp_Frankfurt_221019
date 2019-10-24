using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class MyException : Exception
    {
        public MyException():base("Dies ist mein Fehler") { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string eingabe = Console.ReadLine();
                int a = int.Parse(eingabe);

                throw new MyException();
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Du hättest eine Zahl eingeben müssen!\n" + ex.Message);
                throw;

            }
            catch (OverflowException)
            {
                Console.WriteLine("Deine Zahl ist zu groß/klein.");
                return;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ein unbekannter Fehler ist aufgetreten.\n" + ex.Message);
            }
            finally
            {
                Console.WriteLine("Wird immer ausgeführt");
            }

            Console.WriteLine("ENDE");


            Console.ReadKey();
        }
    }
}
