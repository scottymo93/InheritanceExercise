using System;
using System.Reflection.Metadata;
using System.Security.AccessControl;

namespace Inheritance;

public class Animal
{
    public string AnimalName { get; set; }
    public string Habitat { get; set; }
    public string FoodType { get; set; }
    public string AnimalSound { get; set; }

    public void AnimalIntro()
    {
        Console.WriteLine($"The animal we will be talking about today is the {AnimalName}. The {AnimalName} lives in the {Habitat} and eats {FoodType}. You will know one is close by if you hear a {AnimalSound}.");
    }
}