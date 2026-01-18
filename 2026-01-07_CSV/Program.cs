using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;

public class Person
{
    public string? Fullname { get; set; }
    public string? Email { get; set; }
    public string? Telefon { get; set; }
    public string? Adresse { get; set; }
    public string? Unicode { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        var config = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";",
            PrepareHeaderForMatch = args => args.Header.ToLower(),
            MissingFieldFound = null
        };

        using (var reader = new StreamReader("persons.csv"))
        using (var csv = new CsvReader(reader, config))
        {
            var records = csv.GetRecords<Person>().ToList();

            foreach (var person in records)
            {
                Console.WriteLine($"Name: {person.Fullname}, Email: {person.Email}, Telefon: {person.Telefon}, Adresse: {person.Adresse}, Unicode: {person.Unicode}");
            }
        }
    }
}