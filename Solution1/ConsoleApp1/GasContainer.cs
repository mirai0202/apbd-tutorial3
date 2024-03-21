namespace ConsoleApp1;

public class GasContainer : Container, IHazardNotifier
{
    public GasContainer(double massOfCargo, double height, double tareWeight, double depth, double maxPayload) 
        : base(massOfCargo, height, tareWeight, depth, maxPayload, "G")
    {
    }

    public override void Empty()
    {
        MassOfCargo *= 0.05;
    }

    public void sendNotification()
    {
        Console.WriteLine("HazardousSituation in " + SerialNumber);
    }
}