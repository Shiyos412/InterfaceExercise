using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int wheels { get; set; }
        public int doors { get; set; }
        public int seats { get; set; }

        public string Drive();
    }
}
