namespace Domain;

public class CarSpec
{
    public CarType Type { get; set; }
    
    public string Make { get; set; }
    
    public string Model { get; set; }
    
    public int Year { get; set; }
    
    public CarBodyType BodyType { get; set; }
    
    public bool Operational { get; set; }
    
    public int Count { get; set; }
}
