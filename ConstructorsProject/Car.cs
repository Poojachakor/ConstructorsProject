using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsProject
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Default constructor
        public Car()
        {
            Make = "Unknown";
            Model = "Unknown";
            Year = 0;
        }

        // Parameterized constructor
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        // Copy constructor
        public Car(Car otherCar)
        {
            Make = otherCar.Make;
            Model = otherCar.Model;
            Year = otherCar.Year;
        }

        // Static constructor
        static Car()
        {
            Console.WriteLine("Static constructor called.");
        }

        // Instance method
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}");
        }
    }
}

    