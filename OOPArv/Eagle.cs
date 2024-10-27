using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPArv
{
    internal class Eagle : Animal
    {
        public int WingSpan { get; set; } = 0;
        public Eagle(string animalType, int age, string foodType, string sound, string name, int wingSpan)
            : base(animalType, age, foodType, sound, name)
        {
            WingSpan = wingSpan;
        }
        public virtual void Flying()
        {
            Console.WriteLine($"{Name} the {AnimalType} is Flying");
        }

    }
}
