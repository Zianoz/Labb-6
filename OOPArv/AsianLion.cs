using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class AsianLion : Lion
    {
        public string HabitatType { get; set; } = "Forest";
        public AsianLion(string animalType, int age, string foodType, string sound, string name, int maneSize, string habitatType)
           : base(animalType, age, foodType, sound, name, maneSize)
        {
            HabitatType = habitatType;
        }

        public virtual void Habitat()
        {
            Console.WriteLine($"{Name} the {AnimalType} lives in the {HabitatType}");
        }

    }
}
