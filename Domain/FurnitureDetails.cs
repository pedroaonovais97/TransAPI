namespace Domain;

public class FurnitureDetails
{
    public IEnumerable<FurnitureSpec> FurnitureSpecs { get; set; }
    
    public Service Service { get; set; }
}
