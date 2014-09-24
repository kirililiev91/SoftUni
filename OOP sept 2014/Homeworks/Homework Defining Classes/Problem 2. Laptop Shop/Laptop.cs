using System;

class Laptop
{
    //fields
    private string model;
    private string manufacturer;
    private string processor;
    private int ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery;
    private decimal price;
    //props
    public string Model
    { 
        get
        {
            return this.model;
        }
        set 
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of Model cannot be empty!");
            }
            this.model = value;
        }
    }
    public string Manufacturer 
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of Manufacturer cannot be empty!");
            }
            this.manufacturer = value;
        }
    }
    public string Processor 
    {
        get
        {
            return this.processor;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of Processor cannot be empty!");
            }
            this.processor = value;
        }
    }
    public int Ram 
    {
        get
        {
            return this.ram;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("The value of RAM cannot be negative number!");
            }
            this.ram = value;
        }
    }
    public string GraphicsCard 
    {
        get
        {
            return this.graphicsCard;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of Graphics Card cannot be empty!");
            }
            this.graphicsCard = value;
        }
    }
    public string Hdd 
    {
        get
        {
            return this.hdd;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of HDD cannot be empty!");
            }
            this.hdd = value;
        }
    }
    public string Screen 
    {
        get
        {
            return this.screen;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of Screen cannot be empty!");
            }
            this.screen = value;
        }
    }
    public Battery Battery 
    {
        get
        {
            return this.battery;
        }
        set
        {
            this.battery = value;
        }
    }
    public decimal Price 
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value < 0.00m)
            {
                throw new ArgumentOutOfRangeException("The value of Price cannot be negative number!");
            }
            this.price = value;
        }
    }
    //constructors
    public Laptop(string model, string manufacturer, string processor, int ram, string graphicsCard, string hdd, string screen,
        Battery battery, decimal price)
    {
        this.Model = model;
        this.Manufacturer = manufacturer;
        this.Processor = processor;
        this.Ram = ram;
        this.GraphicsCard = graphicsCard;
        this.Hdd = hdd;
        this.Screen = screen;
        this.Battery = battery;
        this.Price = price;
    }
    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }
    //methods
    public override string ToString()
    {
        string result = "Model: " + this.Model + "\n";
        if (this.Manufacturer != null)
        {
            result += "Manufacturer: " + this.Manufacturer + "\n";
        }
        if (this.Processor != null)
        {
            result += "Processor: " + this.Processor + "\n";
        }
        if (this.Ram != 0)
        {
            result += "RAM: " + Convert.ToString(this.Ram) + " GB\n";
        }
        if (this.GraphicsCard != null)
        {
            result += "GraphicsCard: " + this.GraphicsCard + "\n";
        }
        if (this.Hdd != null)
        {
            result += "HDD: " + this.Hdd + "\n";
        }
        if (this.Screen != null)
        {
            result += "Screen: " + this.Screen + "\n";
        }
        if (this.Battery != null)
        {
            result += this.Battery.ToString();
        }
        result += "Price: " + Convert.ToString(this.Price) + " lv.\n";
 
        return result;
    }


}