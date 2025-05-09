using System;

class Program
{
// DisplayWelcome - Displays the message, "Welcome to the Program!"
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the Program!");
    }

// PromptUserName - Asks for and returns the user's name (as a string)
    static string PromptUserName(){
        Console.Write("Enter User Name: ");
        return Console.ReadLine();
    }

// PromptUserNumber - Asks for and returns the user's favorite number (as an integer)

    static int PromptUserNumber(){
        Console.Write("Enter User Favorite Number: ");
        return int.Parse(Console.ReadLine());
    }

// SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)

    static int SquareNumber(int num){
        return num * num;
    }

// DisplayResult - Accepts the user's name and the squared number and displays them.

    static void DisplayResult(string userName, int squareNumber){
        Console.WriteLine($"{userName}'s favorite number squared is {squareNumber}");
    }


    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        string name = PromptUserName();
        int favNum = PromptUserNumber();
        int result = SquareNumber(favNum);
        DisplayResult(name, result);
    }
}