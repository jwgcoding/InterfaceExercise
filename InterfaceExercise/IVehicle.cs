using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal interface IVehicle : ICompany
    {
        public int Wheels { get; set; }
        public int Doors { get; set; }
        public int Lights { get; set; }
        public int Mirrors { get; set; }
    }
}
