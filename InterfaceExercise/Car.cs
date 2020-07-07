using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public string trunkSize { get; set; }
        public bool windowTint { get; set; }

        public string companyName { get; set; }

        public string logo { get; set; }

        public int numberOfWheels { get; set; }
        public string model { get; set; }
        public bool isDriveable { get; set; }
        public string make { get; set; }

        
    }
}
