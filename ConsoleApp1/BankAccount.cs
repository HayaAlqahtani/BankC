using System;

class BankAccount
{
    private string username;
    private int accountNumber;
    private double balance;
    private const int maxTransaction = 50;
    private double[] transactions = new double[maxTransaction];
    private int transactionCount = 0;

    public BankAccount(string name, int accountNumber, double initialBalance)
    {
        this.username = name;
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        transactions[transactionCount++] = amount;
        Console.WriteLine($"Deposit successful \nNew Balance: {balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            transactions[transactionCount++] = -amount;
            Console.WriteLine($"Withdrawal successful \nNew Balance: {balance}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }

    public void ViewBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
    }

    public void ViewTransactionHistory()
    {
        Console.WriteLine("\nTransaction History:");
        for (int i = 0; i < transactionCount; i++)
        {
            Console.WriteLine(transactions[i] > 0 ? $"Deposit: +${transactions[i]}" : $"Withdrawal: -${-transactions[i]}");
        }
    }
}