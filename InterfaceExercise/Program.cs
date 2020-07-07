using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;

            SUV caddy = new SUV();
            caddy.leatherSeats = true;

            Car honda = new Car();
            honda.windowTint = true;

            Truck ford = new Truck();
            ford.hasBackSeat = false;

            Console.WriteLine($"Yes that is {caddy.leatherSeats}, my Caddy does have leather seats!");
            Console.WriteLine($"Yes that is {honda.windowTint}, my Honda does have window tint!");
            Console.WriteLine($"No that is {ford.hasBackSeat}, my Ford does not have a backseat");
            
        }   
    }    //Creatively display and organize their values
        
    
}   
