using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_static_abstraction
{
    internal class Bicycle : Vehicle,IDrive
    {
        public Bicycle(string name) : base(name) { }

        double _mileage; 
        public void Drive(double km)
        {
            _mileage += km;
        }
    }
}
