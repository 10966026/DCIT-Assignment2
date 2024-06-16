using System;

namespace Interfaces
{
    // Define an interface IMovable
    interface IMovable
    {
        void Move();
    }

    // Class Car implementing IMovable
    class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    // Class Bicycle implementing IMovable
    class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Car and Bicycle
            Car myCar = new Car();
            Bicycle myBicycle = new Bicycle();

            // Call the Move method on each instance
            myCar.Move();       // Output: Car is moving
            myBicycle.Move();   // Output: Bicycle is moving

            // Keep the console window open
            Console.ReadLine();
        }
    }
}
