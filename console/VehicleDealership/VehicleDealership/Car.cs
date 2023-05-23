using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDealership
{
    internal class Car: Vehicle
    {

        public int numberOfSeats { get; set; } 
        public Car(int serieNumber): base(serieNumber) { }

        public override void Drive()
        {
            base.Drive();

            Console.WriteLine("THIS IS A CAR AND WE'RE GOING TO MIAMEEEEE");
        }

        public override string ToString()
        {
            return $"Motorcycle: ${this.Name}\nPrice: ${this.Price} - Brand: {this.Brand} - N. of seats: {this.numberOfSeats}cc.";
        }
    }
}
