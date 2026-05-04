using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string School = "BYU Pathway";
        Console.WriteLine($"Welcome to {School}!");

        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");

        Console.Write("What is your age? ");
        string ageInput = Console.ReadLine();
        int age = int.Parse(ageInput);

        Console.WriteLine($"Your name is {name.ToUpper()} and you are {age} years old.");
    }
}