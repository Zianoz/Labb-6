using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    // Eagle class inherits from Animal
    internal class Eagle : Animal
    {
        // Unique property specific to Eagle, with a default value of 0
        public int WingSpan { get; set; } = 0;

        // Constructor sets values for the inherited properties from Animal and initializes WingSpan
        public Eagle(string animalType, int age, string foodType, string sound, string name, int wingSpan)
            : base(animalType, age, foodType, sound, name)
        {
            WingSpan = wingSpan;
        }

        // Method specific to Eagle, representing its flying behavior
        public virtual void Flying()
        {
            Console.WriteLine($"{Name} the {AnimalType} is Flying");
        }
    }
}
