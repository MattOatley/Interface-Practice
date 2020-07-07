using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public int numberOfSeats { get; set; } = 6;
        public bool leatherSeats { get; set; } = true;
        public int numberOfWheels { get; set; } = 4;
        public string model { get; set; } = "Escalade";
        public bool isDriveable { get; set; } = true;
        public string make { get; set; } = "Caddilac";
        public string companyName { get; set; } = "Caddilac";

        public string logo { get; set; } = "Diamond";

        

        public void Drive()
        {

        }

        public SUV(int NumberOfSeats, bool LeatherSeats, int NumberOfWheels, string Model, bool IsDriveable, string Make, string CompanyName, string Logo)
        {

        }

    }
}
