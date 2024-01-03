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
            var cardinal = new Bird();
            cardinal.CanFly = true;
            cardinal.HasFeathers = true;
            cardinal.Color = "Red";
            cardinal.Migrates = false;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var snake = new Reptile()
            {
                LandOrWater = "Land",
                LaysEggs = true,
                HasScales = true,
                ColdBlooded = true

            };
            var animals = new Animal[] { cardinal, snake };
            
            foreach( var animal in animals ) 
            {
                Console.WriteLine($"Eats: {animal.Eats}" );
                Console.WriteLine($"Number of Legs {animal.Legs}");
            }
        }
    }
}
