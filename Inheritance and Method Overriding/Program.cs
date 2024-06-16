using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanceand_MethodOverriding
{
    // Base class
    class Animal
    {
        // Virtual method to be overridden in derived classes
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    // Derived class Dog
    class Dog : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    // Derived class Cat
    class Cat : Animal
    {
        // Override the MakeSound method
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Animal, Dog, and Cat
            Animal genericAnimal = new Animal();
            Dog dog = new Dog();
            Cat cat = new Cat();

            // Call the MakeSound method on each instance
            genericAnimal.MakeSound();  // Output: Some generic sound
            dog.MakeSound();            // Output: Bark
            cat.MakeSound();            // Output: Meow

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
