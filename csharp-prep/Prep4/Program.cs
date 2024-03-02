using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("  Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        int newNum = -1;

        while (newNum != 0)
        {
            Console.Write("Enter number: ");
            string userNewNum = Console.ReadLine();
            newNum = int.Parse(userNewNum);
            if (newNum != 0)
            {
                numbers.Add(newNum);
            }
        }

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        // Eso del (float) es para cast la variable a un float, para que la division devuelva decimales
        Console.WriteLine($"The average is: {((float)numbers.Sum()) / numbers.Count}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");
    }
}