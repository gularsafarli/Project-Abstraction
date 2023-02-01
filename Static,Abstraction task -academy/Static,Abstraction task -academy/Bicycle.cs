using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Abstraction_task__academy
{
    internal class Bicycle : Vehicle
    {
        public override void Drive(double km)
        {
            Mileage += km;
        }
    }
}
