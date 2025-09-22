﻿using System;

class Program
{
    static void Main()
    {
        try
        {
            // Zwei gemischte Brüche als Beispiel
            string input1 = "2 3/8";
            string input2 = "1 5/6";

            Fraction f1 = Fraction.ParseMixed(input1);
            Fraction f2 = Fraction.ParseMixed(input2);
            Fraction sum = f1 + f2;

            Console.WriteLine($"{input1} + {input2} = {sum.ToMixedString()}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Eingabefehler: " + ex.Message);
            Environment.Exit(1);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Ungültiger Bruch: " + ex.Message);
            Environment.Exit(1);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unbekannter Fehler: " + ex.Message);
            Environment.Exit(1);
        }
    }
}

class Fraction
{
    public int Numerator { get; }
    public int Denominator { get; }

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0) throw new ArgumentException("Nenner darf nicht 0 sein.");
        Numerator = numerator;
        Denominator = denominator;
    }

    // Gemischten Bruch parsen, z.B. "2 3/8" oder "-1 1/2"
    public static Fraction ParseMixed(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
            throw new FormatException("Eingabe darf nicht leer sein.");

        input = input.Trim();
        int whole = 0;
        string fractionPart = input;

        if (input.Contains(" "))
        {
            var parts = input.Split(' ');
            if (parts.Length != 2)
                throw new FormatException("Ungültiges Format für gemischten Bruch.");
            whole = int.Parse(parts[0]);
            fractionPart = parts[1];
        }

        var frac = fractionPart.Split('/');
        if (frac.Length != 2)
            throw new FormatException("Bruch muss im Format Zähler/Nenner sein.");

        int num = int.Parse(frac[0]);
        int den = int.Parse(frac[1]);
        if (den == 0)
            throw new ArgumentException("Nenner darf nicht 0 sein.");

        int numerator = Math.Abs(whole) * den + num;
        if (whole < 0)
            numerator = -numerator;

        return new Fraction(numerator, den).Simplify();
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int num = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
        int den = a.Denominator * b.Denominator;
        return new Fraction(num, den).Simplify();
    }

    public Fraction Simplify()
    {
        int g = GCD(Math.Abs(Numerator), Math.Abs(Denominator));
        return new Fraction(Numerator / g, Denominator / g);
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

    public override string ToString()
    {
        return $"{Numerator}/{Denominator}";
    }
}
//
class random()
{
    // This is a random class added to demonstrate multiple classes in one file.
    // It does not have any functionality related to the Fraction class.
}