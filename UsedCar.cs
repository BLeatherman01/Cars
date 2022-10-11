using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
     public class UsedCar : Car
     {
       public double Mileage { get; set; }

        //We want to make a constructor that passes values up to the parent and
        //adds in our additional one
        //We can use the base keyword here
      public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) 
            : base(Make, Model, Year, Price)
      {
            this.Mileage = Mileage;
      }

        public string UsedCarInfo(string make, string model, int year, decimal price, double mileage)
        {
            return (make, model, year, price, mileage).ToString();
        }

        public override string ToString()
        {
            return base.ToString() + " Mileage: "+ Mileage;
        }
    }
}
