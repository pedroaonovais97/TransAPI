namespace Domain;

public class GeneralDetails
{
    public string Description { get; set; }
    
    public IEnumerable<string> ImagesIds { get; set; }
    
    public Deliver Deliver { get; set; }
}