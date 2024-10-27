using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPArv
{
    internal class Elephant : Animal
    {
        public int TrunkLenght { get; set; } = 0;
        public Elephant(string animalType, int age, string foodType, string sound, string name, int trunkLenght)
            : base(animalType, age, foodType, sound, name)
        {
            TrunkLenght = trunkLenght;
        }

        public virtual void Stomping()
        {
            Console.WriteLine($"{Name} the {AnimalType} is stomping");
        }

    }
}
