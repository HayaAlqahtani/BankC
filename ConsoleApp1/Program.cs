// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter Account number:");
        int accountNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter balance amount:");
        double balance = double.Parse(Console.ReadLine());

        BankAccount account = new BankAccount(name, accountNumber, balance);

        int choice;
        do
        {
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. View Balance:");
            Console.WriteLine("4. View Transaction History");
            Console.WriteLine("5. Exit");
            Console.WriteLine("\nEnter your choice:");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter deposit amount: ");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    break;
                case 2:
                    Console.WriteLine("Enter withdrawal amount: ");
                    double withdrawalAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawalAmount);
                    break;
                case 3:
                    account.ViewBalance();
                    break;
                case 4:
                    account.ViewTransactionHistory();
                    break;
                case 5:
                    Console.WriteLine("Thank you");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        } while (choice != 5);
    }
}