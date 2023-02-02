using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);

        Console.WriteLine($"Test: {f1.GetFractionString()}, Test 2: {f2.GetFractionString()}, Test 4: {f3.GetFractionString()}");

        
    }
}