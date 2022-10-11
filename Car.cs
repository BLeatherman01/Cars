using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cars_and_Used_Cars
{
     public class Car
     {
       public string Make { get; set; }
       public string Model { get; set; }
       public int Year { get; set; }
       public decimal Price { get; set; }

        
       

        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
            
        }

        public Car()
        {

        }
        
        
        public void ListOfCars(List<Car>carsInventory)
        {
           int index = 1;

           foreach (Car car in carsInventory)
           {
               Console.WriteLine(index + ": " + car);
               index++;
           }
            
        }

        public void Purchase(List<Car> carsInventory)
        {
            Console.WriteLine("Which car would you like to purchase? Please select 1-6");
            string input = Console.ReadLine();
            int pick = int.Parse(input);
            Console.WriteLine(carsInventory.ElementAt(pick-1));
            carsInventory.RemoveAt(pick - 1);
            
        }
        public void RemoveCar(List<Car> carsInventory)
        {
            Console.WriteLine("Which car would you like to remove?");
            string input = Console.ReadLine();
            int pick = int.Parse(input);
            Console.WriteLine(carsInventory.ElementAt(pick - 1));
            carsInventory.RemoveAt(pick-1);
        }
        public override string ToString()
        {
            string output = $"Make: {Make}, Model: {Model}, Year: {Year}, Price: {Price}";
            return output;
        }

    }
}
