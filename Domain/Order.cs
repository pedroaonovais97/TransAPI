namespace Domain;

public class Order
{
    public Guid Id { get; set; }

    public OrderCategory OrderCategory { get; set; }

    public string From { get; set; }

    public string To { get; set; }

    public DateOnly PickupDate { get; set; }

    public DateOnly DeliveryDate { get; set; }

    public IEnumerable<object> ItemDetails { get; set; }

    public GeneralDetails GeneralDetails { get; set; }
}