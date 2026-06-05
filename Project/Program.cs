using Project;
using Project.OOP_Principles.Abstraction;
using Project.OOP_Principles.Coupling;
using Project.OOP_Principles.PolyMorphism;
using Project.SOLID.D;
using Project.SOLID.I;
using Project.SOLID.L;
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

//Composition VS Inheritance

//Composition - has-a relationship
//Inheritance - is-a relationship

// Single responsibility principle
//"A class should have only one reason to change, meaning that it should have only one responsibility or purpose."

// Open-closed principle
//"Software entities (classes, modules, functions, etc.) should be open for extension, but closed for modification."

// Liskov substitution principle
//"Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program."

var rect = new Rectangle{Width = 10, Height = 20};
Console.WriteLine($"Area of Rectangle: {rect.Area}");

var square = new Square { SideLength = 15 };
Console.WriteLine($"Area of Square: {square.Area}");

// Interface segregation principle
//"Clients should not be forced to depend on interfaces that they do not use."

var circle = new Circle();
circle.Radius = 10;
Console.WriteLine(circle.Area());

// Dependency inversion principle
//"High-level modules should not depend on low-level modules. Both should depend on abstractions."

var carr = new Project.SOLID.D.Car(new Engine());
carr.StartCar();






