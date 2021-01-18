using System;

namespace SOLID_Labb
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = {new Dog("Black"),
                            new Hedgehog("Pink"),
                            new Bird("Yellow")};

            Console.WriteLine("###############");
            Console.WriteLine();

            foreach (var animal in animals)
            {
                animal.Eat();
                animal.Sleep();
                animal.Speak();

                if (animal is Dog dog)
                {

                    animal._owner = "Niklas";
                    animal.Owner();
                }

                animal._color = "Grey";
                Console.WriteLine(animal.GetType().Name + " is " + animal._color);
                Console.WriteLine();

                Console.WriteLine("###############");
                Console.WriteLine();
            }
        }
    }
}
