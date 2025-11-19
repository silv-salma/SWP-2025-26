public class Car
{
    public Car() : this("Unknown", "Unknown")
    {
        Console.WriteLine("Default constructor");
    }

    public Car(string type, string brand)
    {
        Console.WriteLine($"Car constructor: {type}, {brand}");
    }
}
