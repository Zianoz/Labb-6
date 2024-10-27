using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    // Lion class inherits from Animal
    internal class Lion : Animal
    {
        // Unique property specific to Lion, with a default value of 0
        public int ManeSize { get; set; } = 0;

        // Constructor sets values for the inherited properties from Animal and initializes ManeSize
        public Lion(string animalType, int age, string foodType, string sound, string name, int maneSize)
           : base(animalType, age, foodType, sound, name)
        {
            ManeSize = maneSize;
        }

        // Method specific to Lion, representing its hunting behavior
        public virtual void Hunting()
        {
            Console.WriteLine($"{Name} the {AnimalType} is hunting");
        }
    }
}
