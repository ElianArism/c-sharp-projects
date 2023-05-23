using System;

namespace VehicleDealership
{
    internal abstract class Vehicle: VehicleActions
    {
        public double Price { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }

        private int serieNumber; 
       

        public Vehicle(int serieNumber)
        {
            this.serieNumber = serieNumber; 
        }

        public virtual void Drive()
        {
            Console.WriteLine("DRIVING BEIBI");
        }

        public int GetSerieNumber()
        {
            return serieNumber; 
        }
    }
}
