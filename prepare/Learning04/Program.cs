using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment assignment1 = new WritingAssignment("Daniel", "Coolness", "The Cause of the Coolness of Daniel");


        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine(assignment1.GetWritingInformation());
    }
}