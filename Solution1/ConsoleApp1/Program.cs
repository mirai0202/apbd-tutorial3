using ConsoleApp1;

var gasContainer = new GasContainer(10, 200, 200, 10, 1000);
var liquidContainer = new LiquidContainer(10, 200, 200, 10, 1000);
gasContainer.Load(1, new Product("Gas", ProductType.Gas, 10));

var containerShip = new ContainerShip(20, 100, 10000);
containerShip.LoadContainer(gasContainer);

var containers = new List<Container>
{
    liquidContainer,
    gasContainer
};

containerShip.LoadContainers(containers);
containerShip.RemoveContainer(gasContainer.SerialNumber);

liquidContainer.Empty();

var containerShip2 = new ContainerShip(20, 100, 10000);
containerShip2.LoadContainer(liquidContainer);
Console.WriteLine(liquidContainer);
Console.WriteLine(containerShip);