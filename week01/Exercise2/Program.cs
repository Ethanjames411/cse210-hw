using System;

class Program
{
    static void Main(string[] args)
    {
        PrintUserGrade();
    }

    static void PrintUserGrade()
    {
        Console.Write("What is your grade percentage? ");
        int gradePercentage = int.Parse(Console.ReadLine());

        string letterGrade;

        if (gradePercentage >= 94)
            letterGrade = "A";
        else if (gradePercentage >= 90)
            letterGrade = "A-";
        else if (gradePercentage >= 87)
            letterGrade = "B+";
        else if (gradePercentage >= 84)
            letterGrade = "B";
        else if (gradePercentage >= 80)
            letterGrade = "B-";
        else if (gradePercentage >= 76)
            letterGrade = "C+";
        else if (gradePercentage >= 70)
            letterGrade = "C";
        else if (gradePercentage >= 60)
            letterGrade = "D";
        else
            letterGrade = "F";

        Console.WriteLine($"Your Grade is {letterGrade}");

        if (gradePercentage >= 60)
        {
            Console.WriteLine("You passed the course.");
        }
        else
        {
            Console.WriteLine("You did not pass the course.");
        }
    }
}