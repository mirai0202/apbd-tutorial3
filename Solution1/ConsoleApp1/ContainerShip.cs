namespace ConsoleApp1;

public class ContainerShip
{
    public List<Container> Containers { get; set; } = new List<Container>();
    public double MaxSpeed { get; set; }
    public int MaxContainers { get; set; }
    public double MaxWeight { get; set; }

    public ContainerShip(double maxSpeed, int maxContainers, double maxWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainers = maxContainers;
        MaxWeight = maxWeight;
    }

    public void LoadContainer(Container container)
    {
        if (Containers.Count + 1 <= MaxContainers)
        {
            Console.WriteLine("Container added");
            Containers.Add(container);
        }
        else
        {
            Console.WriteLine("too much containers");
        }
    }
    
    public void LoadContainers(List<Container> containers)
    {
        foreach (var container in containers)
        {
            if (Containers.Count + 1 <= MaxContainers)
            {
                Console.WriteLine("Container added");
                Containers.Add(container);
            }
            else
            {
                Console.WriteLine("too much containers");
                return;
            }
        }
    }

    public void RemoveContainer(string containerSerialNumber)
    {
        foreach (var container in Containers.Where(container => container.SerialNumber == containerSerialNumber))
        {
            Containers.Remove(container);
            Console.WriteLine("Successfully deleted container");
            return;
        }

        Console.WriteLine("There is no such container to remove");
    }

    public double CalculateCurrentCargo()
    {
        var sum = 0.0;
        
        foreach (var container in Containers)
        {
            sum += container.MassOfCargo;
        }

        return sum;
    }
    
    public override string ToString()
    {
        return "Max speed: " + MaxSpeed + "\n" +
               "Max weight: " + MaxWeight + "\n" +
               "Max containers " + MaxContainers + "\n" +
               "Current mass of cargo: " + CalculateCurrentCargo();
    }
}