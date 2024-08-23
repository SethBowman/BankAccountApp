namespace BankEncapsulation;

public class UserInteraction
{
    public void ATM(BankAccount account)
    {
        Console.WriteLine("Welcome to the banking app!");
        Console.WriteLine("----------------------------");

        while (true)
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Check balance");
            Console.WriteLine("3. Exit");

            var parsedSuccess = int.TryParse(Console.ReadLine(), out var option);

            if (!parsedSuccess)
            {
                Console.WriteLine("Invalid input. Please select a valid option.");
                Thread.Sleep(3000);
                Console.Clear();
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the amount you would like to deposit:");

                    var depositAmountSuccess = double.TryParse(Console.ReadLine(), out var amount);

                    if (!depositAmountSuccess)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid amount.");
                        Thread.Sleep(3000);
                        Console.Clear();
                        continue;
                    }

                    account.Deposit(amount);
                    Console.WriteLine("Deposit success!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 2:
                    Console.WriteLine($"Current balance: {account.GetBalance()}");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("Thank you for using the banking app!");
                    Thread.Sleep(3000);
                    Console.Clear();
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option.");
                    Thread.Sleep(3000);
                    Console.Clear();
                    break;
            }
        }
    }
}