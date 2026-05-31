namespace Project.OOP_Principles.Coupling;

public class Order
{
    private readonly INotificationService notificationService;

    public Order(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }
    
    public void PlaceOrder()
    {
        notificationService.SendNotification("Order processed");
    }
}