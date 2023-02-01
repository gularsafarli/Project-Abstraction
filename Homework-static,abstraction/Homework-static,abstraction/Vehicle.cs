using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_static_abstraction
{
    internal abstract class Vehicle
    {
        protected string _name;
        public Vehicle(string name)
        {
            _name = name;
        }
    }
}
