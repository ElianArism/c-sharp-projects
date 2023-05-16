using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    internal class Conversor
    {

        public decimal TemperatureConversor(string from, string to, decimal value)
        {

            if (from == "Farenheit")
            {
                return (value - 32) * 5 / 9; 
            }
            return (value * 9 / 5) + 32; 
        }

        public decimal DistanceConversor(string from, string to, decimal value)
        {
           
           switch(from)
            {
                case "Kilometer":
                    if(to == "Meter") value *= 1000; 
                    else if (to == "Centimeter") value *= 1000000;
                    break;
                case "Meter":
                    if (to == "Kilometer") value /= 1000;
                    else if (to == "Centimeter") value *= 100;
                    break;
                case "Centimeter":
                    if (to == "Kilometer") value /= 100000;
                    else if (to == "Meter") value /= 100;
                    break;
                default:
                    break;
            }

            return value;
        }

        public decimal LiquidConversor(string from, string to, decimal value)
        {
            switch (from)
            {
                case "Liter":
                    if (to == "Centiliter") value *= 100;
                    else if (to == "Mililiter") value *= 1000;
                    break;
                case "Centiliter":
                    if (to == "Liter") value /= 100;
                    else if (to == "Mililiter") value *= 10;
                    break;
                case "Mililiter":
                    if (to == "Centiliter") value /= 10;
                    else if (to == "Liter") value /= 1000;
                    break;
                default:
                    break;
            }

            return value;
        }

    }
}
