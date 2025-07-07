public class Menu
{
    public void DisplayOptions()
    {
        Console.WriteLine("1. View Balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. Exit");
    }

    public int GetUserChoice()
    {
        Console.Write("Choose an option: ");
        string input = Console.ReadLine();
        int choice;
        if (int.TryParse(input, out choice))
        {
            return choice;
        }
        return -1; // Invalid input
    }
}
