using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        { 
            doors = 2;
            wheels = 4;
            seats = 4;
        }

        public string logo { get ; set ; }
        public string name { get ; set ; }
        public int wheels { get ; set ; }
        public int doors { get ; set ; }
        public int seats { get ; set ; }

        public string Drive()
        {
            return ($"This truck drives with {doors} doors, {wheels} wheels, and {seats} seats");
        }
    }
}
