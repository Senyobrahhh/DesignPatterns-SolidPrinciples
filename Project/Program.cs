using Project;
using Project.OOP_Principles.Abstraction;

//Encapsulation

BankAccount account = new BankAccount(100);
Console.WriteLine(account.GetBalance());
account.Withdraw(50);
Console.WriteLine(account.GetBalance());
account.Deposit(100);
Console.WriteLine(account.GetBalance());

//Abstraction

EmailService emailService = new EmailService();
emailService.SendEmail();

//Inheritance

