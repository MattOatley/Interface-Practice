using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public string bedSize { get; set; }

        public bool hasBackSeat { get; set; }
        public int numberOfWheels { get; set; }
        public string model { get; set; }
        public bool isDriveable { get; set; }
        public string make { get; set; }
        public string companyName { get; set; }

        public string logo { get; set; }

        

    }
}
