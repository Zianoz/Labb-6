using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Animal
    {

        public string AnimalType { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public string FoodType { get; set; } = "Unknown";
        public string Sound { get; set; } = "Unknown";
        public string Name { get; set; } = "Unknown";

        public Animal(string animalType, int age, string foodType, string sound, string name)
        {
            AnimalType = animalType;
            Age = age;
            FoodType = foodType;
            Sound = sound;
            Name = name;

        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} the {AnimalType} {Sound}");
        }

        public virtual void EatFood()
        {
            Console.WriteLine($"{Name} the {AnimalType} eats {FoodType}");
        }

        public virtual void Sleeping()
        {
            Console.WriteLine($"{Name} the {AnimalType} sleeps");
        }


    }
}
