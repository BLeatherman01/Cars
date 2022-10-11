using System.Security.Cryptography.X509Certificates;

namespace Cars_and_Used_Cars
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            Car c = new Car();
            
            List<Car> carsInventory = new List<Car>(); 
            carsInventory.Add(new Car("Ford", "Bronco", 2022, 40500));
            carsInventory.Add(new Car("Ford", "Mustang", 2022, 45500));
            carsInventory.Add(new Car("Chevrolet", "Camaro", 2022, 45500));
            carsInventory.Add(new UsedCar("Chevy", "Nova", 1969, 35000m, 18000));
            carsInventory.Add(new UsedCar("Toyota", "Corolla", 1995, 10000m, 6000));
            carsInventory.Add(new UsedCar("Ford", "Taurus", 2001, 12500m, 86000));

           //shows list of cars
           c.ListOfCars(carsInventory);
           //Shows user selection and removes cars from list
           c.Purchase(carsInventory);
           //Updated list after purchase
           c.ListOfCars(carsInventory);
           //Removes one car
           c.RemoveCar(carsInventory);
            //Shows list after previous car was removed
           c.ListOfCars(carsInventory);



           
        }
        
    }
}