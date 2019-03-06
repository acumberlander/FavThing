using System;
using System.Collections.Generic;
using System.Text;

namespace FavThing
{
    class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Rating { get; private set; }
        public CarType Type { get; set; }

        //Fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        //Constructor
        public Car(string make, string model, CarType type)
        {
            Make = make;
            Model = model;
            Type = type;
        }


        //Method
        public void SetRating(int userRating)
        {
            // needs to be bwtween 1-10
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"You are dumb. Ratings are {MinRatingValue}-{MaxRatingValue}, you moron.");
            }
        }
        public override string ToString()
        {
            return $"This is a {Make} {Model}. It's rated {Rating}/10.";
        }
    }
    //the car type
    enum CarType
    {
        Sedan,
        Coupe,
        SUV,
        Truck,
        Minivan
    }
}
