namespace ConsoleApp1;

public class LiquidContainer : Container, IHazardNotifier
{
    public double HazardCargo { get; set; }
    public double OrdinaryCargo { get; set; }
    public LiquidContainer(double massOfCargo, double height, double tareWeight, double depth, double maxPayload) 
        : base(massOfCargo, height, tareWeight, depth, maxPayload, "L")
    {
    }

    public override void Load(double mass, Product product)
    {
        if ((product.Type == ProductType.LiquidHazard && HazardCargo + mass > (MassOfCargo / 2)) ||
            MassOfCargo + mass > (MassOfCargo * 0.9))
        {
            sendNotification();
        }

        if (product.Type == ProductType.LiquidHazard)
        {
            HazardCargo += mass;
        }
        else
        {
            OrdinaryCargo += mass;
        }
        
        base.Load(mass, product);
    }
    
    
    
    public void sendNotification()
    {
        Console.WriteLine("Attempt of dangerous operation");
    }
}