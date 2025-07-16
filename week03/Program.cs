using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();          // 1/1
        Fraction f2 = new Fraction(5);         // 5/1
        Fraction f3 = new Fraction(3, 4);      // 3/4
        Fraction f4 = new Fraction(1, 3);      // 1/3

        DisplayFraction(f1);
        DisplayFraction(f2);
        DisplayFraction(f3);
        DisplayFraction(f4);
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine($"Fraction: {fraction.GetFractionString()}");
        Console.WriteLine($"Decimal: {fraction.GetDecimalValue()}\n");
    }
}
