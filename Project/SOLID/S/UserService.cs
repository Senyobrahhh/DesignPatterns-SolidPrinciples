namespace Project.SOLID.S;

public class UserService
{
    public void Register(User user)
    {
        EmailSender emailSender = new EmailSender();
        emailSender.SendEmail(user.Email, "Welcome to our website!");
    }
}