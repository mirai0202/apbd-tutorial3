namespace ConsoleApp1;

public class Product(string name, ProductType productType, double temperature)
{
    public string Name { get; set; } = name;
    public ProductType Type { get; set; } = productType;
    public double Temperature { get; set; } = temperature;
}