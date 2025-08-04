using System;

namespace Inheritance;

public class Bird : Animal
{
    public int WingSpan { get; set; }
    public int BeakSize { get; set; }
    public bool CanFly { get; set; }
    public string FootType { get; set; }

    public void BirdInfo()
    {
        Console.WriteLine($"It has the wingspan of {WingSpan} feet and beak size of {BeakSize} inches. It is {CanFly} that they can fly, and have {FootType} to help them survive.");
    }
}