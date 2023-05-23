using System;

namespace VehicleDealership
{
    internal class Motorcycle: Vehicle
    {
        public decimal ccEngine { get; set; }


        public Motorcycle(int serieNumber) : base(serieNumber) {}
        
        public Motorcycle(int serieNumber, decimal ccEngine): base(serieNumber) 
        {
            this.ccEngine = ccEngine;
        }

        public sealed override void Drive()
        {
            base.Drive();

            Console.WriteLine("THIS IS A MOTORCYCLE BEEEEIBEEEE");
        }

        public override string ToString()
        {
            return $"Motorcycle: ${this.Name}\nPrice: ${this.Price} - Brand: {this.Brand} - CCEngine: {this.ccEngine}cc."; 
        }
    }
}
