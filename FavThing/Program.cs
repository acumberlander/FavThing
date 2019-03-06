using System;

namespace FavThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car("Toyota","Camry", CarType.Truck);
            Console.WriteLine("Hello World!");
            Console.WriteLine(firstCar);
            Console.ReadLine();
        }
    }
}
