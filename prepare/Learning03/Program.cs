using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        // Fraction fraction0 = new Fraction();
        // Console.WriteLine($"fraction0 og top: {fraction0.GetTop()} and bottom: {fraction0.GetBottom()}");
        // Console.WriteLine("fraction0 set top to 5 and bottom to 7");
        // fraction0.SetTop(5);
        // fraction0.SetBottom(7);
        // Console.WriteLine($"fraction0 top: {fraction0.GetTop()} and bottom {fraction0.GetBottom()}");

        // Fraction fraction1 = new Fraction(6);
        // Console.WriteLine($"fraction1 og top: {fraction1.GetTop()} and bottom: {fraction1.GetBottom()}");
        // Console.WriteLine("fraction1 set top to 12 and bottom to 2");
        // fraction1.SetTop(12);
        // fraction1.SetBottom(2);
        // Console.WriteLine($"fraction1 top: {fraction1.GetTop()} and bottom {fraction1.GetBottom()}");

        // Fraction fraction2 = new Fraction(6, 7);
        // Console.WriteLine($"fraction2 og top: {fraction2.GetTop()} and bottom: {fraction2.GetBottom()}");
        // Console.WriteLine("fraction2 set top to 32 and bottom to 4");
        // fraction2.SetTop(32);
        // fraction2.SetBottom(4);
        // Console.WriteLine($"fraction2 top: {fraction2.GetTop()} and bottom {fraction2.GetBottom()}");


        Fraction fr1 = new Fraction();
        Console.WriteLine(fr1.GetFractionString());
        Console.WriteLine(fr1.GetDecimalValue());

        Fraction fr2 = new Fraction(5);
        Console.WriteLine(fr2.GetFractionString());
        Console.WriteLine(fr2.GetDecimalValue());

        Fraction fr3 = new Fraction(3, 4);
        Console.WriteLine(fr3.GetFractionString());
        Console.WriteLine(fr3.GetDecimalValue());

        Fraction fr4 = new Fraction(1, 3);
        Console.WriteLine(fr4.GetFractionString());
        Console.WriteLine(fr4.GetDecimalValue());
    }
}