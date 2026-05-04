using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        PrintUserGrade();
    }

    static void PrintUserGrade()
    {
        Console.Write("What is your grade percentage? ");
        string UserInput = Console.ReadLine();
        int GradePercentage = int.Parse(UserInput);

        string LetterGrade = "";

        if (GradePercentage >= 94)
        {
            LetterGrade = "A";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }

        else if (GradePercentage >= 90)
        {
            LetterGrade = "A-";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }

        else if (GradePercentage >= 87)
        {
            LetterGrade = "B+";
            Console.WriteLine($"Your Grade is { LetterGrade }");
        }

        else if (GradePercentage >= 84)
        {
            LetterGrade = "B";
            Console.WriteLine($"Your Grade is { LetterGrade }");
        }

        else if (GradePercentage >= 80)
        {
            LetterGrade = "B-";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }

        else if (GradePercentage >= 76)
        {
            LetterGrade = "C+";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }

        else if (GradePercentage >= 70)
        {
            LetterGrade = "C";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }

        else if (GradePercentage >= 60)
        {
            LetterGrade = "D";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }

        else
        {
            LetterGrade = "F";
            Console.WriteLine($"Your Grade is {LetterGrade}");
        }
    }
}