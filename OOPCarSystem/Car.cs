using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCarSystem
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }


        public Car(string brand, string model, int year, int mileage)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Mileage = mileage;
        }

        public void Drive(int kilometers)
        {
            Mileage += kilometers;
            Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km. Total mileage: {Mileage} km.");
        }
    }
}
