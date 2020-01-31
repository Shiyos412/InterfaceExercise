using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
            doors = 4;
            seats = 6;
            wheels = 4;
        }

        public string logo { get; set; }
        public string name { get; set; }
        public int wheels { get; set; }
        public int doors { get; set; }
        public int seats { get; set; }

        public string Drive()
        {
            return ($"This SUV drives with {doors} doors, {wheels} wheels, and {seats} seats");
        }
    }
}
