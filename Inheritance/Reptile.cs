using System;

namespace Inheritance;

public class Reptile : Animal
{
    public int TailLength { get; set; }
    public string ScaleColor { get; set; }
    public bool CanSwim { get; set; }
    public bool IsDragon { get; set; }

    public void ReptileInfo()
    {
        Console.WriteLine($"It can have the tail length of {TailLength} feet and is usually the color {ScaleColor}. It is {CanSwim} that they can swim and {IsDragon} that they are a dragon.");
    }
}