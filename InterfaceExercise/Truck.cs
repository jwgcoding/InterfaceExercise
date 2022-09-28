using System;
using System.Collections.Generic;
using System.Text;
using InterfaceExercise;
using static InterfaceExercise.Program;
//In each of your car, truck, and suv classes

/*Create 2 members that are specific to each class
 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
 *
 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
 * 
 */
namespace InterfaceExercise 
{
    public class Truck: IVehicle, ICompany
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Lights { get; set; }
        public int Mirrors { get; set; }
       
        public string Slogan { get; set; }
        public string Brand { get; set; }
        public bool HasTruckBed { get; set; }
        public bool HasTowHook { get; set; }    
    }
}
