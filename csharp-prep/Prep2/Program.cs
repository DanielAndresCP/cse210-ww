using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("Enter your grade percentage: ");
        string user_grade_percent = Console.ReadLine();
        int grade_percent = int.Parse(user_grade_percent);

        string grade_letter = "";

        if (grade_percent >= 90)
        {
            grade_letter = "A";
        }
        else if (grade_percent >= 80)
        {
            grade_letter = "B";
        }
        else if (grade_percent >= 70)
        {
            grade_letter = "C";
        }
        else if (grade_percent >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }
        Console.WriteLine($"Your grade letter is {grade_letter}");



        if (grade_percent >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Better luck next time!");
        }
    }
}