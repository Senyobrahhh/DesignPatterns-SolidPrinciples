using Project;
using Project.OOP_Principles.Abstraction;
using Project.OOP_Principles.Inheritance;

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

var car = new Car();

car.Brand = "Chevrolet";
car.Model = "Tuxedo";
car.Year = 1962;
car.Seats = 2;
car.NumberOfDoors = 2;
car.NumberOfWheels = 4;
car.Start();
car.Stop();


