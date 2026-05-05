using System;

class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        int MagicNumber = random.Next(1, 101);

        int GuessNumber = -1;
        do
        {
            Console.Write("what is your guess ");
            GuessNumber = int.Parse(Console.ReadLine());

            if (GuessNumber < MagicNumber)
            {
                Console.WriteLine("higher");
            }

            else if (GuessNumber > MagicNumber)
            {
                Console.WriteLine("lower");
            }

            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        while (GuessNumber != MagicNumber);
    }
}