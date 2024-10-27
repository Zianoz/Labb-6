using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class AfricanLion : Lion
    {
        public int TemperatureTolerance { get; set; } = 0;
        public AfricanLion(string animalType, int age, string foodType, string sound, string name, int maneSize, int temperatureTolerance)
           : base(animalType, age, foodType, sound, name, maneSize)
        {
            TemperatureTolerance = temperatureTolerance;
        }

        public virtual void Temperature()
        {
            Console.WriteLine($"{Name} the {AnimalType} has a temperature tolerance of {TemperatureTolerance} celsius");
        }
    }
}
