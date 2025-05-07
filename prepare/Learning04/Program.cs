using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
       DisplayWelcome();
       string UserName = PromptUserName();
       int userNumber = PromptUserNumber();
       int SquareNUmber = SquareNumber(userNumber);
       DisplayResult(UserName, SquareNUmber);


    }

static void DisplayWelcome()
{
    Console.WriteLine("Welcome to the program!");
}

static string PromptUserName()
{
    Console.Write("What is your name? ");
    string name = Console.ReadLine();
    return name;
}

static int PromptUserNumber()
{
    Console.Write("What is your favorite number? ");
    int number = int.Parse(Console.ReadLine());

    return number;
}

static int SquareNumber(int number)
{
    int square = number * number;
    return square;
   
}

static void DisplayResult(string name, int square)
{
    Console.Write($"{name}, The square root of your favorite number is {square}!");
}


}