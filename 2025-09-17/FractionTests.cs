using Xunit;

public class FractionTests
{
    [Fact]
    public void Addition_Einfacher_Fraktionen()
    {
        var f1 = new Fraction(1, 2);
        var f2 = new Fraction(1, 3);
        var sum = f1 + f2;
        Assert.Equal("5/6", sum.ToMixedString());
    }
}

public class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
            throw new ArgumentException("Nenner darf nicht 0 sein.");
        Numerator = numerator;
        Denominator = denominator;
    }

    public static Fraction ParseMixed(string input)
    {
        int whole = 0;
        string fractionPart = input;

        if (input.Contains(" "))
        {
            var parts = input.Split(' ', 2);
            if (parts.Length != 2)
                throw new FormatException("Ungültiges Format für gemischten Bruch.");

            whole = int.Parse(parts[0]);
            fractionPart = parts[1];
        }
        else if (input.StartsWith("-"))
        {
            var parts = input.Split(' ', 2);
            if (parts.Length != 2)
                throw new FormatException("Ungültiges Format für gemischten Bruch.");

            whole = int.Parse(parts[0]);
            fractionPart = parts[1];
        }

        var fracParts = fractionPart.Split('/');
        if (fracParts.Length != 2)
            throw new FormatException("Ungültiges Format für Bruchsteil.");

        int numerator = int.Parse(fracParts[0]);
        int denominator = int.Parse(fracParts[1]);

        if (denominator == 0)
            throw new ArgumentException("Nenner darf nicht 0 sein.");

        if (whole < 0)
            numerator = whole * denominator - numerator;
        else
            numerator = whole * denominator + numerator;

        return new Fraction(numerator, denominator);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int commonDenominator = a.Denominator * b.Denominator;
        int newNumerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        return new Fraction(newNumerator, commonDenominator).Simplify();
    }

    public Fraction Simplify()
    {
        int gcd = GCD(Math.Abs(Numerator), Denominator);
        return new Fraction(Numerator / gcd, Denominator / gcd);
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public string ToMixedString()
    {
        int whole = Numerator / Denominator;
        int remainder = Math.Abs(Numerator % Denominator);

        if (remainder == 0)
            return whole.ToString();
        else if (whole == 0)
            return $"{Numerator}/{Denominator}";
        else
            return $"{whole} {remainder}/{Denominator}";
    }
}