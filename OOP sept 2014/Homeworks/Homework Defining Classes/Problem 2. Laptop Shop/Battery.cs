using System;

class Battery
{
    //fields
    private string batteryType;
    private float batteryLife;

    //props
    public string BatteryType
    {
        get
        {
            return this.batteryType;
        }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("The value of Battery cannot be empty!");
            }
            this.batteryType = value;
        }
    }
    public float BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        set
        {
            if (value < 0.00)
            {
                throw new ArgumentOutOfRangeException("The value of BatteryLife cannot be negative number!");
            }
            this.batteryLife = value;
        }
    }

    //constructors
    public Battery(string batteryType, float batteryLife)
    {
        this.BatteryType = batteryType;
        this.BatteryLife = batteryLife;    
    }
    
    //methods
    public override string ToString()
    {
        
        return "Battery: " + this.BatteryType + "\n" + "Battery Life: " + Convert.ToString(this.BatteryLife) + " hours\n";
    }
}