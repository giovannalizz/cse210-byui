using System;
using System.Security.Cryptography;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        //random number
        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());

        if (magicNumber < guess)
        {
            Console.WriteLine("Too high");

        }
        else if (magicNumber > guess)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }
        }

        // generating the avarage

        List<int> numbers = new List<int>();

        int userNumber = -1;


        while (userNumber != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished. ");

            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        // avarage

        float avarage = ((float)sum) / numbers.Count;

    }
}