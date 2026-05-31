using Project;
using Project.OOP_Principles.Abstraction;
using Project.OOP_Principles.Coupling;
using Project.OOP_Principles.PolyMorphism;
using Car = Project.OOP_Principles.Inheritance.Car;

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

// Polymorphism

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Plane{Brand = "Boeing", Model = "737", Year = 2010});
vehicles.Add(new Motorcycle{Brand = "Ducati", Model = "Monster", Year = 2010});

foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}

//Coupling

var order = new Order(new EmailSender());
order.PlaceOrder();
