using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        
        f1.SetTop(3);
        f1.SetBottom(4);

        Console.WriteLine($"{f1.GetTop()}/{f1.GetBottom()}");
        Console.WriteLine(f1.GetDecimalValue());

        Fraction f3 = new Fraction(1, 3);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
    }
}