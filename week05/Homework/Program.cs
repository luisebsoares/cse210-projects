using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("John Smith", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Jane Doe", "Fractions", "Section 1.1", "Problems 1-10");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Emily Johnson", "History", "The American Revolution");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInfo());
    }
}