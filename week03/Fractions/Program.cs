using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction myFractionOne = new Fraction();
        Fraction myFractionTwo = new Fraction(3);
        Fraction myFractionThree = new Fraction(1, 2);
        Console.WriteLine($"Fraction One is {myFractionOne.GetFractionString()}");
        myFractionOne.SetTop(5);
        myFractionOne.SetBottom(7);
        Console.WriteLine($"Now Fraction One is {myFractionOne.GetFractionString()}");
        Console.WriteLine($"Fraction Two is {myFractionTwo.GetFractionString()}");
        Console.WriteLine($"Fraction Three is {myFractionThree.GetFractionString()}");
        Console.WriteLine($"The decimal value of the fraction three is {myFractionThree.GetDecimalValue()}");
        Console.WriteLine($"The bottom value of fraction one is {myFractionOne.GetBottom()}");
        Console.WriteLine($"The top value of fraction two is {myFractionTwo.GetTop()}");

    }
}