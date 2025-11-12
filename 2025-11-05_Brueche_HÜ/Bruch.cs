class Bruch
{
    // jetzt kommen die sog. "Attribute" der Klasse oder "Felder"
    private int zaehler;
    private int nenner;

    //this bezieht sich auf das aktuelle Objekt
    //int. ist eine Klasse, int.Parse ist eine statische Methode weil wir kein int Objekt anlegen müssen

    public Bruch(string bruchtext) //Constructor, Klassenname sollte man groß schreiben
    {
        try
        {
            bruchtext = bruchtext.Trim();
            int ganz = 0, z = 0, n = 1;

            var teile = bruchtext.Split(' ');
            if (teile.Length == 2)
            {
                ganz = int.Parse(teile[0]);
                bruchtext = teile[1];
            }

            string[] bruchteile = bruchtext.Split('/');
            if (bruchteile.Length == 2)
            {
                z = int.Parse(bruchteile[0]);
                n = int.Parse(bruchteile[1]);
            }
            else if (bruchteile.Length == 1)
            {
                z = int.Parse(bruchteile[0]);
                n = 1;
            }
            else
            {
                throw new FormatException("Ungültiges Format für Bruch.");
            }

            if (n == 0)
                throw new ArgumentException("Nenner darf nicht 0 sein.");

            this.zaehler = ganz * n + z;
            this.nenner = n;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler: " + ex.Message);
            throw;
        }
    }

    public Bruch addiere(Bruch b)
    {
        int z = zaehler * b.nenner + b.zaehler * nenner;
        int n = nenner * b.nenner;
        return new Bruch($"{z}/{n}");
        //return null;
    }

    private int GGT(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public override string ToString()
    {
        int ggt = GGT(Math.Abs(zaehler), Math.Abs(nenner));
        int kZ = zaehler / ggt;
        int kN = nenner / ggt;

        int ganz = kZ / kN;
        int rest = Math.Abs(kZ % kN);

        if (rest == 0)
            return ganz.ToString();
        if (Math.Abs(kZ) < Math.Abs(kN))
            return $"{kZ}/{kN}";
        return $"{ganz} {rest}/{Math.Abs(kN)}";

        //return $"{this.zaehler}/{this.nenner}";

        // JS: return `ich bin ein bruch: ${this.zaehler}/${this.nenner}`;
    }
}