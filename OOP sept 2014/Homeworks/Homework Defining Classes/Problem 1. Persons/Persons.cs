using System;

class Program
{
    static void Main()
    {
        Person person1 = new Person("kiril", 23, "kiril@kiril.com");
        Person person2 = new Person("niki", 20);
        Console.WriteLine(person1);
        Console.WriteLine(person2);
    }
}
