namespace ConsoleApp1;

public class RefrigeratedContainer : Container
{
    public Product CurrentProduct { get; set; }
    public double Temperature { get; set; }
    

    public override void Load(double mass, Product product)
    {
        if (product.Type != CurrentProduct.Type)
        {
            Console.WriteLine("Not same type of product");
        }
        else if (product.Temperature < Temperature)
        {
            Console.WriteLine("Product temperature cannot be lower the container's");
        }
        else
        {
            base.Load(mass, product);
            CurrentProduct = product;
        }
    }

    public RefrigeratedContainer(double massOfCargo, double height, double tareWeight, double depth, double maxPayload, string typeOfContainer, double temperature) 
        : base(massOfCargo, height, tareWeight, depth, maxPayload, typeOfContainer)
    {
        Temperature = temperature;
    }
}