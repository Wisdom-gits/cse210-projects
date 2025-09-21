using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine("Fractions created using different constructors:");
        Console.WriteLine($"{f1.GetFractionString()} = {f1.GetDecimalValue()}");
        Console.WriteLine($"{f2.GetFractionString()} = {f2.GetDecimalValue()}");
        Console.WriteLine($"{f3.GetFractionString()} = {f3.GetDecimalValue()}");

        Console.WriteLine("\nChanging f3 to 1/3 using setters...");
        f3.SetTop(1);
        f3.SetBottom(3);

        Console.WriteLine("New fraction: " + f3.GetFractionString());
        Console.WriteLine("Decimal value: " + f3.GetDecimalValue());

        Console.WriteLine("\nTrying to set denominator to 0...");
        f3.SetBottom(0);
        Console.WriteLine("Fraction after invalid set: " + f3.GetFractionString());
    }
}
