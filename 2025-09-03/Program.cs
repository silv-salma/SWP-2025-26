using System;

class Program
{
    static void Main(string[] args)
    {
        if (args.Length != 2)
        {
            Console.WriteLine("Usage: dotnet run \"2 3/8\" \"1 5/6\"");
            return;
        }

        Fraction f1 = Fraction.ParseMixed(args[0]);
        Fraction f2 = Fraction.ParseMixed(args[1]);
        Fraction sum = f1 + f2;

        Console.WriteLine($"{args[0]} + {args[1]} = {sum.ToMixedString()}");
    }
}

class Fraction
{
    public int Numerator { get; private set; }
    public int Denominator { get; private set; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0) throw new ArgumentException("Denominator cannot be zero.");
        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    public static Fraction ParseMixed(string input)
    {
        input = input.Trim();
        int whole = 0;
        string fractionPart = input;

        if (input.Contains(" "))
        {
            var parts = input.Split(' ');
            whole = int.Parse(parts[0]);
            fractionPart = parts[1];
        }

        var frac = fractionPart.Split('/');
        int num = int.Parse(frac[0]);
        int den = int.Parse(frac[1]);

        int numerator = whole >= 0 ? (whole * den + num) : (whole * den - num);
        return new Fraction(numerator, den);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int den = a.Denominator * b.Denominator;
        return new Fraction(num, den);
    }

    private void Simplify()
    {
        int g = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        Numerator /= g;
        Denominator /= g;
        if (Denominator < 0)
        {
            Numerator = -Numerator;
            Denominator = -Denominator;
        }
    }

    public string ToMixedString()
    {
        int whole = Numerator / Denominator;
        int remainder = Math.Abs(Numerator % Denominator);
        if (remainder == 0)
            return $"{whole}";
        if (whole == 0)
            return $"{remainder}/{Denominator}";
        return $"{whole} {remainder}/{Denominator}";
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int t = b;
            b = a % b;
            a = t;
        }
        return a;
    }
}

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

