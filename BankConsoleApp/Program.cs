using BankConsoleApp;

var account = new BankAccount("Kendra", 100001);
Console.WriteLine(
    $"Account {account.Number} created for " +
    $"{account.Owner} and balance is {account.Balance}");

account.MakeWithdrawal(220, DateTime.Now, "Ticket");
account.MakeWithdrawal(50, DateTime.Now, "Hammock");
account.MakeWithdrawal(100, DateTime.Now, "Registration");
account.MakeWithdrawal(30, DateTime.Now, "Lunch");

Console.WriteLine(account.GetAccountHistory());