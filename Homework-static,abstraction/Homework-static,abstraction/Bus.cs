using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Homework_static_abstraction
{
    internal class Bus : Vehicle, ICapacity, IDrive
    {
        
        public  Bus(string name) : base(name)
        {

        }
       double _fuelcapacity;
        double _currentfuel;

        public double Fuelcapacity
        {
            get
            {
                return _fuelcapacity;
            }
            set
            {
                if (_currentfuel<=value)
                {
                    _fuelcapacity = value;
                }
                
            }
        }
        public double Currentfuel {
            get {
                return _currentfuel;
            }
            set {
                _currentfuel = value;
            }
        }

        double _mileage;

        public Bus(string name) : base(name)
        {
        }

        public void Drive(double km)
        {
            _mileage += km;
        }
    }
}
