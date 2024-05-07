using System;
using System.Collections.Generic;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public string Address { get; set; }
    public List<BankAccount> BankAccounts { get; set; } = new List<BankAccount>();
}

public class BankAccount
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public string Currency { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User { Id = 1, Name = "John", LastName = "Doe", Birthday = new DateTime(1990, 5, 15), Address = "123 Main St" };
        User user2 = new User { Id = 2, Name = "Jane", LastName = "Smith", Birthday = new DateTime(1985, 10, 20), Address = "456 Oak St" };

        BankAccount account1 = new BankAccount { Id = 101, Amount = 1000, Status = "Active", Currency = "USD" };
        BankAccount account2 = new BankAccount { Id = 102, Amount = 2000, Status = "Active", Currency = "EUR" };
        BankAccount account3 = new BankAccount { Id = 201, Amount = 1500, Status = "Active", Currency = "USD" };

        user1.BankAccounts.Add(account1);
        user1.BankAccounts.Add(account2);
        user2.BankAccounts.Add(account3);

        Console.WriteLine("Users:");
        DisplayUserInfo(user1);
        DisplayUserInfo(user2);
    }

    static void DisplayUserInfo(User user)
    {
        Console.WriteLine($"ID: {user.Id}, Name: {user.Name} {user.LastName}, Birthday: {user.Birthday.ToShortDateString()}, Address: {user.Address}");
        Console.WriteLine("Bank Accounts:");
        foreach (var account in user.BankAccounts)
        {
            Console.WriteLine($"  Account ID: {account.Id}, Amount: {account.Amount}, Status: {account.Status}, Currency: {account.Currency}");
        }
        Console.WriteLine();
    }
}
