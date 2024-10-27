using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    // AfricanLion class inherits from Lion
    internal class AfricanLion : Lion
    {
        // Property to store the temperature tolerance level
        public int TemperatureTolerance { get; set; } = 0;

        // Constructor initializes properties inherited from Lion and unique to AfricanLion
        public AfricanLion(string animalType, int age, string foodType, string sound, string name, int maneSize, int temperatureTolerance)
           : base(animalType, age, foodType, sound, name, maneSize)
        {
            TemperatureTolerance = temperatureTolerance; // Initializes temperature tolerance
        }

        // Method to display the temperature tolerance of the African Lion
        public virtual void Temperature()
        {
            Console.WriteLine($"{Name} the {AnimalType} has a temperature tolerance of {TemperatureTolerance} Celsius");
        }
    }
}
