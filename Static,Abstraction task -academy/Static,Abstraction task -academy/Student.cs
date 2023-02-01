using System;
using System.Collections.Generic;
using System.Text;

namespace Static_Abstraction_task__academy
{
    internal class Student
    {
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }
        static Student()
        {
            //_totalCount = 0;
            _totalCount = 100;
        }

        static private int _totalCount;
        public int No;
        public string Fullname;
        public int Point;
    }
}
