using System;
using InheritanceClasses;

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

            var Penguin = new Animals.Bird();

            Penguin.Legs = 2;           //These are not completely accurate
            Penguin.AvgWeight = 3.35;
            Penguin.Eyes = 2;
            Penguin.HasTeeth = false;

            Penguin.WingsLength = 33.8;
            Penguin.BeakLength = 8.5;
            Penguin.HasFeathers = false;
            Penguin.CanFly = false;

            Penguin.PrintInfo();
            Penguin.PrintBirdInfo();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var Lizard = new Animals.Reptile();

            Lizard.Legs = 4;            
            Lizard.AvgWeight = 30.6;    //Not accurate
            Lizard.Eyes = 2;
            Lizard.HasTeeth = true;

            Lizard.HasScales = true;
            Lizard.Sheds = true;
            Lizard.CanCamouflage = true;
            Lizard.NumTeeth = 26;

            Lizard.PrintInfo();
            Lizard.PrintReptileInfo();
        }
    }
}
