// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using System.Linq.Expressions;
using System;
class Program
{

    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Bitte mindestens zwei Brüche angeben (z.B. \"1/2\" \"3/4\").");
            return;
        }

        try
        {
            Bruch b1 = new Bruch(args[0]);
            Bruch b2 = new Bruch(args[1]);
            Bruch b3 = b1.addiere(b2);
            Console.WriteLine("Ergebnis: " + b3.ToString());
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler bei der Verarbeitung: " + ex.Message);
            Console.WriteLine("Bitte geben Sie die Brüche im Format 'Zähler/Nenner' ein, z.B. 2/5 oder 3/4.");
        }
    }
}