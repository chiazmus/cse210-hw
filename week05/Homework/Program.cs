using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment assignment1 = new Assignment("John Doe", "Matrix Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment assignment2 = new MathAssignment("Jane Doe", "Dot product", "Section 8.4", "Problems 5a-7d");
        Console.WriteLine(assignment2.GetSummary());
        Console.WriteLine(assignment2.GetHomeworkList());
        WritingAssignment assignment3 = new WritingAssignment("Mark Brown", "The Great Gatsby", "A Deep Dive Into Gatsbys Mind");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());

    }
}