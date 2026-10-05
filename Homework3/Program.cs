using Homework3;

BankAccount account = new BankAccount("Настя", 1000)
{ 
    AccountNumber = "123456"
};
account.Deposit(200);
Console.WriteLine(account.Balance);
account.Withdraw(300);
Console.WriteLine(account.Balance);
Console.WriteLine(account.GetInfo());