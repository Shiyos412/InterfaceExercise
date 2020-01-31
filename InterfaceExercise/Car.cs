using System;
namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
            wheels = 4;
            doors = 4;
            seats = 4;
            trunk = true;
            engine = "v6";
        }

        public int wheels { get ; set ; }
        public int doors { get; set; }
        public int seats { get ; set ; }
        public string logo { get; set ; }
        public string name { get; set ; }
        public bool trunk { get; set; }
        public string engine { get; set; }

        public string Drive()
        {
            return ($"This car drives with {wheels} wheels, {doors} doors, and {seats} seats. It has a {engine} engine, and has a trunk");
        }
    }
}
