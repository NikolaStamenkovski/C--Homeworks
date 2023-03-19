using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{

    public class Dog

    {      

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public string Name { get; set; }
        public string Race { get; set; }

        public string Color { get; set; }

        public void Eat()
        {
            Console.WriteLine($"The dog {Name} race {Race} {Color } is now Eating");
        }
        public void Play()
        {
            Console.WriteLine($"The dog {Name} race {Race}  {Color} is now Playing");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} race {Race} {Color} is now chasing its tail");
        }
    }
}
