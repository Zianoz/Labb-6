using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Lion : Animal
    {
        public int ManeSize { get; set; } = 0;
        public Lion(string animalType, int age, string foodType, string sound, string name, int maneSize)
           : base(animalType, age, foodType, sound, name)
        {
            ManeSize = maneSize;
        }

        public virtual void Hunting()
        {
            Console.WriteLine($"{Name} the {AnimalType} is hunting");
        }

    }
}
