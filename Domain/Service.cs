using System.Collections;

namespace Domain;

public class Service
{
    public ServiceType ServiceType { get; set; }
    
    public IDictionary<int, bool> PickUpFloor { get; set; }
    
    public IDictionary<int, bool> DeliveryFloor { get; set; }
}