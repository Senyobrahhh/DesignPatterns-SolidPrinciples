namespace Project.SOLID.S;

public class EmailSender
{
    public void SendEmail(string message, string email)
    {
        Console.WriteLine($"Sending email to {email}: {message}");
    }
}