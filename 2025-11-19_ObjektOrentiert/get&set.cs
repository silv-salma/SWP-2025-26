class Person
{
    private string name; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person myObj = new Person();
        myObj.Name = "Liam";
        Console.WriteLine(myObj.Name);
    }
}


/*Die Eigenschaft „Name“ ist mit dem Feld „Name“ verknüpft. 
Es empfiehlt sich, für die Eigenschaft und das private Feld denselben Namen zu verwenden, jedoch mit einem Großbuchstaben am Anfang.
Die Methode „get“ gibt den Wert der Variablen „Name“ zurück.
Die Methode „set“ weist der Variablen „Name“ einen Wert zu. 
Das Schlüsselwort „value“ repräsentiert den Wert, der der Eigenschaft zugewiesen wird.*/