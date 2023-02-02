using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);


        Console.WriteLine($"Test: {f1}, Test 2: {f2}, Test 4: {f3}");
    }
}