namespace ConsoleApp1;

public abstract class Container
{
    private static int _counter = 0;
    public double MassOfCargo { get; set; }
    public double Height { get; set; }
    public double TareWeight { get; set; }
    public double Depth { get; set; }
    public string SerialNumber { get; }
    public double MaxPayload { get; set; }

    protected Container(double massOfCargo, double height, double tareWeight, double depth, double maxPayload, string typeOfContainer)
    {
        MassOfCargo = massOfCargo;
        Height = height;
        TareWeight = tareWeight;
        Depth = depth;
        MaxPayload = maxPayload;
        SerialNumber = "KON-" + typeOfContainer + ++_counter;
    }

    public virtual void Empty()
    {
        MassOfCargo = 0;
    }

    public virtual void Load(double mass, Product product)
    {
        if (MassOfCargo + mass > MaxPayload)
        {
            throw new OverfillException();
        }

        MassOfCargo += mass;
    }

    public override string ToString()
    {
        return "Serial number: " + SerialNumber + "\n" +
               "Mass: " + MassOfCargo + "\n" +
               "Height: " + Height + "\n" +
               "Tare weight: : " + TareWeight + "\n" +
               "Depth: " + Depth + "\n" +
               "Max payload: " + MaxPayload + "\n";
    }
}