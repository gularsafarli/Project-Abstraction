using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Homework_static_abstraction
{
    internal class Car :Vehicle ,ICapacity,IDrive
    {
        public Car(string name) : base(name) { }

        double _fuelcapacity;
        double _currentfuel;
        public double Fuelcapacity {
            get  {
                return _fuelcapacity;
            }
            set {
                _fuelcapacity = value;
            }
        }
        public double Currentfuel { get
            {
                return _currentfuel;
            }
            set
            {
                if (_fuelcapacity >= value)
                {
                    _currentfuel = value;
                }
            }
                
        }
        double _mileage;
        double _for1km;
        public void Drive(double km)
        {
            _mileage += km;
            _currentfuel -= km * _for1km;
        }
    }
}
