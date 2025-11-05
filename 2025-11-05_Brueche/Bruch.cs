class Bruch
{
    // jetzt kommen die sog. "Attribute" der Klasse oder "Felder"
    private int zaehler;
    private int nenner;

    public Bruch(string bruchtext) //Constructor, Klassenname sollte man groß schreiben
    { 
        string[] teile = bruchtext.Split('/');
        this.zaehler = int.Parse(teile[0]); //this bezieht sich auf das aktuelle Objekt
        this.nenner = int.Parse(teile[1]); //int. ist eine Klasse, int.Parse ist eine statische Methode weil wir kein int Objekt anlegen müssen
    }

    public Bruch addiere(Bruch b)
    {
        return null;
    }
    public string toString()
    {
        return $"{this.zaehler}/{this.nenner}"; 
        // JS: return `ich bin ein bruch: ${this.zaehler}/${this.nenner}`;
    }
}