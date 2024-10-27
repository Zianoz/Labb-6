using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    // Base class for all animals
    internal class Animal
    {
        // Properties that are common to all animals, with default values
        public string AnimalType { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public string FoodType { get; set; } = "Unknown";
        public string Sound { get; set; } = "Unknown";
        public string Name { get; set; } = "Unknown";

        // Constructor to initialize properties with specific values
        public Animal(string animalType, int age, string foodType, string sound, string name)
        {
            AnimalType = animalType;
            Age = age;
            FoodType = foodType;
            Sound = sound;
            Name = name;
        }

        // Method to simulate the animal making a sound
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} the {AnimalType} {Sound}");
        }

        // Method to simulate the animal eating food
        public virtual void EatFood()
        {
            Console.WriteLine($"{Name} the {AnimalType} eats {FoodType}");
        }

        // Method to simulate the animal sleeping
        public virtual void Sleeping()
        {
            Console.WriteLine($"{Name} the {AnimalType} sleeps");
        }
    }
}
