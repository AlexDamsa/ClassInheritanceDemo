using System;

namespace ClassInheritanceDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Dudi", 100, 2);
            Tiger tg = new Tiger("Tanuki", 250, 13, 50, "Siberian");
            Fish fish = new Fish("Jelly", 2, 1, "sweet water", 0);

            fish.Presentation();

            Console.WriteLine(int.MaxValue);

            PrintRaceOfTiger(tg);
        }

        public static void PrintRaceOfTiger(Animal anim)
        {
            if (anim is Tiger)
            {
                Tiger tiger = anim as Tiger;

                Console.WriteLine($"Race: {tiger.race}");
            }
            else
                Console.WriteLine("Muri muri");

            // .....
        }


        public static void TypeOfAnimal(Animal anim)
        {
            if(anim is Tiger)
                Console.WriteLine("I am a tiger");
            else if(anim is Fish)
                Console.WriteLine("Maybe I am a fish");
            else
                Console.WriteLine("I don't know what I am");
        }


    }

    enum PaymentMethod
    {
        Vis = 1234, PayPal, Revolut
    }
}
