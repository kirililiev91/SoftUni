using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //creating some components instances
        Component intelI3 = new Component("intel core i3", 125.90m);
        Component intelI5 = new Component("intel core i5", 241.90m);
        Component scr15_6HdLed = new Component("15.6\" HD LED", 178.75m);
        Component ram4Gb = new Component("4 GB DDR3 Memory", 147.25m);
        Component hdd1Tb = new Component("1000 GB HDD", 147.99m);
        Component nvidiaGT520 = new Component("NVIDIA GeForce GT 520M", 198.99m);

        //creating computers
        Computer comp1 = new Computer("Computer 1", intelI3, scr15_6HdLed, ram4Gb);
        Computer comp2 = new Computer("Computer 2", intelI5, scr15_6HdLed, ram4Gb, hdd1Tb, nvidiaGT520);
        Computer comp3 = new Computer("Computer 3", intelI3, scr15_6HdLed, ram4Gb, hdd1Tb, nvidiaGT520);

        Console.WriteLine(comp1.ToString());
        Console.WriteLine(comp2.ToString());
        Console.WriteLine(comp3.ToString());
        //List<Computer> computers = new List<Computer>() { comp1, comp2, comp3 };
        //computers.OrderByDescending(computer => computer.Price).ToList().ForEach(computer => Console.WriteLine(computer.ToString()));
    }
}
