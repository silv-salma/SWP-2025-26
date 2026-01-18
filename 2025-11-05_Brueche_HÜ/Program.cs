class Program
{
    static void Main(string[] args)
    {
        if (args.Length < 2)
        {
            Console.WriteLine("Bitte mindestens zwei Brüche angeben (z.B. \"1/2\" \"3/4\").");
            return;
        }
        Bruch b1 = new Bruch(args[0]);
        Bruch b2 = new Bruch(args[1]);
        Bruch b3 = b1.addiere(b2);
        Console.WriteLine("Ergebnis: " + b3.ToString());
    }
}