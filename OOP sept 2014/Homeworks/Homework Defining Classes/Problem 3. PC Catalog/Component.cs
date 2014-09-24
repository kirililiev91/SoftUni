using System;

class Component
{
    //fields
    private string name;
    private string details;
    private decimal price;

    //props
    public string Name
    {
        get { return this.name; }
        set { ValidationData(value, "Component Name"); this.name = value; }
    }
    public string Details
    {
        get { return this.details; }
        set { ValidationData(value, "Component Details"); this.details = value; }
    }
    public decimal Price
    {
        get { return this.price; }
        set { ValidationData(value, "Component Price"); this.price = value; }
    }

    //constructors
    public Component(string name, decimal price, string details)
    {
        this.Name = name;
        this.Price = price;
        this.Details = details;
    }
    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }

    //methods
    private void ValidationData(object data, string argument)
    {
        if (data is string)
        {
            if ((string)data == "")
            {
                throw new ArgumentException("The argument must not to be empty string.", argument);
            }
        }
        else if (data is decimal)
        {
            if ((decimal)data <= 0)
            {
                throw new ArgumentException("The argument must not to be negative or zero.", argument);
            }
        }
    }
    public override string ToString()
    {
            string componentStr = "" + this.Name;
            return String.Format("{0, -50} | {1, 10} lv.\n", componentStr, Convert.ToString(this.Price));
    }
}
