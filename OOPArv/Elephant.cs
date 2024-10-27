using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPArv
{
    // Elephant class inherits from Animal
    internal class Elephant : Animal
    {
        // Unique property specific to Elephant, with a default value of 0
        public int TrunkLenght { get; set; } = 0;

        // Constructor sets values for the inherited properties from Animal and initializes TrunkLenght
        public Elephant(string animalType, int age, string foodType, string sound, string name, int trunkLenght)
            : base(animalType, age, foodType, sound, name)
        {
            TrunkLenght = trunkLenght;
        }

        // Method specific to Elephant, representing its stomping behavior
        public virtual void Stomping()
        {
            Console.WriteLine($"{Name} the {AnimalType} is stomping");
        }
    }
}
