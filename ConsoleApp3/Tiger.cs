using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceDemo
{
    public class Tiger : Animal
    {
        public int lengthOfTail;
        public string race;

        public override void Presentation()
        {
            Console.WriteLine($"My name is {name}. I am a tiger with a {lengthOfTail}cm tail.");
            base.Presentation();

        }

        public Tiger(string name, float height, int age, int lengthOfTail, string race) : base(name, height, age)
        {
            this.lengthOfTail = lengthOfTail;
            this.race = race;
        }
    }
}
