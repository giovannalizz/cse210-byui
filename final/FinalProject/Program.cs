using System;
using FinalProject; // Must be at the top, outside any class or namespace

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Giovanna", 500);
            Menu menu = new Menu();
            bool exit = false;

            while (!exit)
            {
                menu.DisplayOptions();
                int choice = menu.GetUserChoice();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Balance: ${account.GetBalance()}");
                        break;
                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        decimal deposit = decimal.Parse(Console.ReadLine());
                        account.Deposit(deposit);
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        decimal withdraw = decimal.Parse(Console.ReadLine());
                        if (!account.Withdraw(withdraw))
                            Console.WriteLine("Insufficient funds.");
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
