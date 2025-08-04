using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *
             
             * Creatively display the class member values 
             */
            var eagle = new Bird();
            eagle.AnimalName = "Eagle";
            eagle.WingSpan = 4;
            eagle.BeakSize = 5;
            eagle.CanFly = true;
            eagle.FootType = "talons";
            eagle.AnimalSound = "Kaahh!";
            eagle.Habitat = "nest on a tree";
            eagle.FoodType = "rodents";
            eagle.AnimalIntro();
            eagle.BirdInfo();

            Console.WriteLine("--------------");

/*Create an object of your Reptile class
 *  give values to your members using the object of your Reptile class
 *
 * Creatively display the class member values
 */
            var gator = new Reptile();
            gator.AnimalName = "Alligator";
            gator.Habitat = "swamp";
            gator.FoodType = "fish and small animals";
            gator.AnimalSound = "growl!";
            gator.ScaleColor = "green";
            gator.CanSwim = true;
            gator.TailLength = 4;
            gator.IsDragon = true;
            gator.AnimalIntro();
            gator.ReptileInfo();
        }
    }
}
