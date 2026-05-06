using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        var userName = PromptUserName();
        var userNumber = PromptUserNumber();
        var valueSquared = SquareNumber(userNumber);

        DisplayResulte(userName, valueSquared);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        var userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        var userNumberValue = Console.ReadLine();
        int userNumber = int.Parse(userNumberValue);

        return userNumber;
    }

    static int SquareNumber(int value)
    {
        var aquare = value * value;
        return aquare;
    }

    static void DisplayResulte(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}