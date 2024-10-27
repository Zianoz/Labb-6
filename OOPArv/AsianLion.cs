using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    // AsianLion class inherits from Lion
    internal class AsianLion : Lion
    {
        // Property to specify the habitat type, with a default value of "Forest"
        public string HabitatType { get; set; } = "Forest";

        // Constructor to initialize properties inherited from Lion and unique to AsianLion
        public AsianLion(string animalType, int age, string foodType, string sound, string name, int maneSize, string habitatType)
           : base(animalType, age, foodType, sound, name, maneSize)
        {
            HabitatType = habitatType; // Initializes the habitat type
        }

        // Method to describe the habitat of the Asian Lion
        public virtual void Habitat()
        {
            Console.WriteLine($"{Name} the {AnimalType} lives in the {HabitatType}");
        }
    }
}
