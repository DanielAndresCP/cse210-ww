using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int sqrNum = SquareNumber(userNumber);

        DisplayResult(userName, sqrNum);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string answer = Console.ReadLine();

        return int.Parse(answer);
    }


    static int SquareNumber(int num)
    {
        return num * num;
    }

    static void DisplayResult(string userName, int sqrNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {sqrNum}");
    }
}