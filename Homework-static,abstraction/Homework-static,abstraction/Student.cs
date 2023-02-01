using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_static_abstraction
{
    internal class Student
    {
        private static  int _totalcount;

       public Student()
       {
            _totalcount++;
            No = _totalcount;
       }
       public int No;
       public string Name;
       public string GroupNo;


      static  public bool CheckGroupNo(string word) {

            if (string.IsNullOrEmpty(word) || word.Length != 4) return false;
            if (!char.IsUpper(word[0])) return false;
            for (int i = 1; i < word.Length; i++)
            {
                if (!char.IsDigit(word[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
