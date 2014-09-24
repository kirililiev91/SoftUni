using System;

class Computer
{
    //fields
    private string name;
    private decimal price;
    private Component processor;
    private Component screen;
    private Component ram;
    private Component hdd;
    private Component graphicsCard;

    //constructors
    public Computer(string name, Component processor, Component screen, Component ram, Component hdd, Component graphicsCard)
    {
        this.Name = name;
        this.Processor = processor;
        this.Screen = screen;
        this.Ram = ram;
        this.Hdd = hdd;
        this.GraphicsCard = graphicsCard;
    }
    public Computer(string name, Component processor, Component screen, Component ram)
    {
        this.Name = name;
        this.Processor = processor;
        this.Screen = screen;
        this.Ram = ram;
    }


    //props
    public string Name
    {
        get { return this.name; }
        set 
        {
            ValidationData(value, "Computer Name");
            this.name = value; 
        }
    }

    public decimal Price
    {
        get { return this.price; }
    }
    public Component Processor
    {
        get { return this.processor; }
        set { ValidationData(value, "Processor"); this.processor = value; }
    }
    public Component Screen
    {
        get { return this.screen; }
        set { ValidationData(value, "Screen"); this.screen = value; }
    }
    public Component Ram
    {
        get { return this.ram; }
        set { ValidationData(value, "RAM"); this.ram = value; }
    }
    public Component Hdd
    {
        get { return this.hdd; }
        set { ValidationData(value, "HDD"); this.hdd = value; }
    }
    public Component GraphicsCard
    {
        get { return this.graphicsCard; }
        set { ValidationData(value, "Graphics Card"); this.graphicsCard = value; }
    }

    //methods
    private void ValidationData(object data, string argument)
    {
        if(data is string)
        {
            if ((string)data == "")
            {
                throw new ArgumentException("The argument must not to be empty string.", argument);
            }
        }
    }
    public override string ToString()
    {
        string result = "\n" +  this.name + "\n";
        decimal totalPrice = 0.00m;
        if (this.Processor != null)
        {
            result += this.Processor.ToString();
            totalPrice += this.Processor.Price;
        }
        if (this.Screen != null)
        {
            result += this.Screen.ToString();
            totalPrice += this.Screen.Price;
        }
        if (this.Ram != null)
        {
            result += this.Ram.ToString();
            totalPrice += this.Ram.Price;
        }
        if (this.Hdd != null)
        {
            result += this.Hdd.ToString();
            totalPrice += this.Hdd.Price;
        }
        if (this.GraphicsCard != null)
        {
            result += this.GraphicsCard.ToString();
            totalPrice += this.GraphicsCard.Price;
        }
        this.price = totalPrice;
        result += new String('-', 67) + "\n";    
        result += String.Format("{0, -50} | {1, 10} lv.", "Total Price" ,Convert.ToString(this.Price));
        return result;
    }

}
