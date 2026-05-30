using Project;

//Encapsulation

BankAccount account = new BankAccount(100);
Console.WriteLine(account.GetBalance());
account.Withdraw(50);
Console.WriteLine(account.GetBalance());
account.Deposit(100);
Console.WriteLine(account.GetBalance());