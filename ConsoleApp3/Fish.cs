using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceDemo
{
    public class Fish : Animal
    {
        public string waterType;
        public int noBones;

        public override void Presentation()
        {
            Console.WriteLine($"I am a fish");
        }

        public Fish(string name, float height, int age, string waterType, int noBones) : base(name, height, age)
        {
            this.waterType = waterType;
            this.noBones = noBones;
        }
    }
}
