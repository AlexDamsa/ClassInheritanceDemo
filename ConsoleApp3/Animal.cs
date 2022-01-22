using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInheritanceDemo
{
    public class Animal
    {
        public string name;
        public float height;
        public int age;

        public virtual void Presentation()
        {
            Console.WriteLine($"My name is {name}. I am {age}.");

        }

        public Animal(string name, float height, int age)
        {
            this.name = name;
            this.height = height;
            this.age = age;
        }
    }
}
