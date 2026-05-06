using System;
using System.Diagnostics.Metrics;

class Program
{
    static void Main(string[] args)
    {
        var numbers = new List<int>();

        int userNumber = -1;

        do
        {
            Console.WriteLine("Enter a number(0 to quit): ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } 
        
        while (userNumber != 0);

        int sumNumber = 0;
        foreach (int number in numbers)
        {
            sumNumber += number;
        }

        Console.WriteLine($"the sum is: {sumNumber}");

        var average = ((float)sumNumber) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        var max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max) 
                max = number;
        }

        Console.WriteLine($"The max is: {max}");
    }
}