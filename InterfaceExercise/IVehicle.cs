using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int numberOfWheels { get; set; }
        public string model { get; set; }
        public bool isDriveable { get; set; }
        public string make { get; set; }
    }
}
