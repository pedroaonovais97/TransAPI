namespace Domain;

public class RemovalsDetails
{
    public int NumberBoxes { get; set; }
    
    public IEnumerable<FurnitureSpec> RemovalsSpecs { get; set; }
    
    public Service Service { get; set; }
}