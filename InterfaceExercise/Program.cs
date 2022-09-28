using System;
using InterfaceExercise;
using static InterfaceExercise.Program;
namespace InterfaceExercise
{
    class Program
    //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

    //Create 2 Interfaces called IVehicle & ICompany


    //Now, create objects of your 3 classes and give their members values;
    //Creatively display and organize their values
    {
        static void Main(string[] args)
        {
            var car1 = new Car
            {
                HasFourDoors = false,
                HasTrunk = true,
                Brand = "Coca-Cola",
                Slogan = "Always Coca-Cola",
                Doors = 2,
                Wheels = 4,
                Lights = 7,
                Mirrors = 3,
                
            };
            var truck1 = new Truck
            {
                Brand = "Pepsi",
                Slogan = "That's what I like",
                Doors = 4,
                Wheels = 4,
                Lights = 8,
                Mirrors = 3,
                HasTowHook = true,
                HasTruckBed = true,
            };
            var suv1 = new SUV
            {
                Brand = "Dr.Pepper",
                Slogan = "King Of Beverages",
                Doors = 4,
                Wheels = 4,
                Lights = 6,
                Mirrors = 2,
                HasCargoHold = true,
                HasRoofRack = true,
            };

            Console.WriteLine($"I put a logo on my car and its {car1.Brand} branded, the slogan of the brand is {car1.Slogan}.\nThe car has only 2 doors, {car1.HasFourDoors} so the car is a coupe so it has only {car1.Doors} doors.\n The rest of the car is basic, it has {car1.Wheels} wheels," +
                $" {car1.Lights} lights, {car1.Mirrors} mirrors, and it has a trunk, {car1.HasTrunk}.");
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"I put a logo on my truck and its {truck1.Brand} branded, the slogan of the brand is {truck1.Brand}.\nThe truck is a basic truck so it has {truck1.Doors} doors, {truck1.Wheels} wheels, {truck1.Lights} lights, {truck1.Mirrors} mirrors, and has a trunkbed, {truck1.HasTruckBed}.\n" +
                $"The back of my truck also has a tow hook, {truck1.HasTowHook}.");
            Console.WriteLine("**************************************************************");
            Console.WriteLine($"I put a logo on my suv and its {suv1.Brand} branded, the slogan of the brand is {suv1.Slogan}.\nThe suv is a little damaged but works just fine. It has {suv1.Doors} doors, {suv1.Wheels} wheels, {suv1.Lights} lights.\n"
              + $"The only damage is that it only has {suv1.Mirrors} total mirrors. My right side mirror is hinged off, but I will be fixing it soon.");



        }

        //Create 3 classes called Car , Truck , & SUV

        //In your IVehicle

        /* Create 4 members that Car, Truck, & SUV all have in common.
         * Example: All vehicles have a number of wheels... for now..
         */
        public interface IVehicle
        {
            public int Wheels { get; set; }
            public int Doors { get; set; }
            public int Lights { get; set; }
            public int Mirrors { get; set; }
        }

        //In ICompany

        /*Create 2 members that are specific to each every company
         * regardless of vehicle type.
         *
         *
         * Example: public string Logo { get; set; }
         */
        public interface ICompany
        {
            public string Slogan { get; set; }  
            public string Brand { get; set; }   
        }
                      
         
        
   
        }
    }

