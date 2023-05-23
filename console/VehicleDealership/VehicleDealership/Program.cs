using System; 


namespace VehicleDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Car c1 = new(new Random().Next()) { Brand = "Honda", Description = "", Model = "2020", Name = "Car 1 Honda", numberOfSeats = 2, Price = 2500.3,};
            Car c2 = new(new Random().Next()) { Brand = "Ferrari", Description = "", Model = "2022", Name = "Car 2 Ferrari", numberOfSeats = 2, Price = 5500.3, };
            Car c3 = new(new Random().Next()) { Brand = "Ford", Description = "", Model = "2023", Name = "Car 3 Ford", numberOfSeats = 4, Price = 3500.3, };

            Motorcycle m1 = new(new Random().Next()) { Brand = "Honda", Description = "", Model = "2020", Name = "CBR", ccEngine = 600, Price = 6600.3, };
            Motorcycle m2 = new(new Random().Next()) { Brand = "Honda", Description = "", Model = "2022", Name = "CB 190r", ccEngine = 190, Price = 4500.3, };
            Motorcycle m3 = new(new Random().Next()) { Brand = "Kawasaki", Description = "", Model = "2023", Name = "Kawasaki Ninja", ccEngine = 300, Price = 5500.3, };


            VehicleDealership Clinis = new()
            {
                AvailableCars = new List<Car>(),
                AvailableMotorcycles = new List<Motorcycle>()
            };

            Clinis.AvailableMotorcycles.Add(m1);
            Clinis.AvailableMotorcycles.Add(m2);
            Clinis.AvailableMotorcycles.Add(m3);

            Clinis.AvailableCars.Add(c1);
            Clinis.AvailableCars.Add(c2);
            Clinis.AvailableCars.Add(c3);


            while(true)
            {
                Console.WriteLine("Clinis Automototes y Motocicletas");
                
                Console.WriteLine("Que le gustaria hacer?");

                Console.WriteLine("1 - Ver Motocicletas en stock");
                Console.WriteLine("2 - Ver Automoviles en stock");
                Console.WriteLine("3 - Ver Camiones / Camionetas en stock");
                Console.WriteLine("0 - Salir");


                int option = int.TryParse(Console.ReadLine(), out option) ? option: 111;


                switch ((TypeOfVehicles)option)
                {
                    case TypeOfVehicles.Car:  
                        foreach(Car car in Clinis.AvailableCars)
                        {
                            Console.WriteLine(car);
                        }
                        break;
                    case TypeOfVehicles.Motorcycle:
                        foreach (Motorcycle motorcycle in Clinis.AvailableMotorcycles)
                        {
                            Console.WriteLine(motorcycle);
                        }
                        break;
                    default: 
                        {
                            break; 
                        }
                }


                if(option == 0)
                {
                    break;
                }

                // TODO: Implement CRUD Cars / Motorcycles 
                // TODO: Implement JSONSerialization for both types of Vehicle
                // TODO: Create functionability that allow fire vehicle(child).Drive() method 

            }
        }
    }
}