using System.Reflection;

namespace _04.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Catalog catalog = new Catalog();

            while (input != "end")
            {
                string[] vehicle = input.Split("/");

                string type = vehicle[0];
                string brand = vehicle[1];
                string model = vehicle[2];
                string hpW = vehicle[3];

                if (type == "Car")
                {
                    Car car = new Car(brand, model, hpW);

                    catalog.Cars.Add(car);

                }

                else if (type == "Truck")
                {
                    Truck truck = new Truck(brand, model, hpW);

                    catalog.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                
                foreach (var item in catalog.Cars.OrderBy(c => c.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }
            
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (var item in catalog.Trucks.OrderBy(t => t.Brand))
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }
        }
    }

    public class Truck
    {
        public Truck(string brand, string model, string weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }
    }

    public class Car
    {
        public Car(string brand, string model, string horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }

    public class Catalog
    {
        public List<Truck> Trucks { get; set; } = new List<Truck>();
        public List<Car> Cars { get; set; } = new List<Car>();
    }
}
