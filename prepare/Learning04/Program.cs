using System;

class Program
{
    static void Main(string[] args)
    {
        Assigment assigment = new Assigment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assigment.GetSummary());
        
        MathAssigment math = new MathAssigment("Roberto Rodriguez", "Fractions", "Section 7.3", "Problems 8-19");
        math.GetHomeworkList();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        writingAssignment.GetWritingInformation();
    }
}