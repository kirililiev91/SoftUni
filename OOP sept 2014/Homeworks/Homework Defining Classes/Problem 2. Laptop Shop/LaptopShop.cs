using System;

class LaptopShop
{
    static void Main()
    {
        Battery batteryAcer5750g = new Battery("6 cell li-ion", 2.5f);

        Laptop laptop1 = new Laptop("Aspire 5750G", 800.00m);       
        Laptop laptop2 = new Laptop("Aspire 5750G", "Acer", "intel core i3", 4, "nvidia gt520m", "1 TB", "15.6 hd led", batteryAcer5750g, 800.00m);

        Console.WriteLine(laptop1.ToString());
        Console.WriteLine(laptop2.ToString());
        
    }
}