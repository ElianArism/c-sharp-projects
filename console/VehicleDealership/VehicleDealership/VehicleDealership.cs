using System;

namespace VehicleDealership
{
    internal class VehicleDealership
    {
        public List<Car> AvailableCars { get; set; }
        public List<Motorcycle> AvailableMotorcycles { get; set; }

        public void removeVehicle(TypeOfVehicles type, int idx)
        {
            if(type == TypeOfVehicles.Car)
            {
                AvailableCars.RemoveAt(idx);
            }   else if (type == TypeOfVehicles.Motorcycle)
            {
                AvailableMotorcycles.RemoveAt(idx);
            }
        }

        public void addVehicle(TypeOfVehicles type, Vehicle v)
        {
            if (type == TypeOfVehicles.Car)
            {
                AvailableCars.Add((Car)v);
            }
            else if (type == TypeOfVehicles.Motorcycle)
            {
                AvailableMotorcycles.Add((Motorcycle)v);
            }
        }

        public void updateVehicle(TypeOfVehicles type, int idx, Vehicle v)
        {
            if (type == TypeOfVehicles.Car)
            {
                AvailableCars[idx] = (Car)v;
            }
            else if (type == TypeOfVehicles.Motorcycle)
            {
                AvailableMotorcycles[idx] = (Motorcycle)v;
            }

        }
    }
}
