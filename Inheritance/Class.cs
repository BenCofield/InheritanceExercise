using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceClasses
{
    class Animals
    {
        public class Animal
        {
            public int Legs { get; set; }
            public double AvgWeight { get; set; } //in kilograms
            public int Eyes { get; set; }
            public bool HasTeeth { get; set; }

            public void PrintInfo()
            {
                Console.WriteLine($"Number of legs: {Legs}\n " +
                                  $"Average weight: {AvgWeight}\n" +
                                  $"Number of eyes: {Eyes}\n" +
                                  $"Has teeth? {HasTeeth}");
            }
        }

        public class Bird : Animal
        {
            public double WingsLength { get; set; }
            public double BeakLength { get; set; } //Centimeters
            public bool HasFeathers { get; set; }
            public bool CanFly { get; set; }

            public void PrintBirdInfo()
            {
                Console.WriteLine($"Length of wings: {WingsLength}\n" +
                                  $"Length of beak: {BeakLength}\n" +
                                  $"Has feathers? {HasFeathers}\n" +
                                  $"Can fly? {CanFly}");
            }
        }

        public class Reptile : Animal
        {
            public bool HasScales { get; set; }
            public bool Sheds { get; set; }
            public bool CanCamouflage { get; set; }
            public int NumTeeth { get; set; }

            public void PrintReptileInfo()
            {
                Console.WriteLine($"Has scales? {HasScales}\n" +
                                  $"Sheds? {Sheds}\n" +
                                  $"Camouflages? {CanCamouflage}\n" +
                                  $"Number of teeth: {NumTeeth}");

            }
        }
    }
}
