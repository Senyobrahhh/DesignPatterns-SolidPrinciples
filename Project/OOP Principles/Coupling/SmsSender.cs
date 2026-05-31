namespace Project.OOP_Principles.Coupling;

public class SmsSender : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("Sending SMS: " + message);
    }
}