using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Static_Abstraction_task__academy
{
    internal class User
    {
        public string UserName;
        private string _password;
        public  string Password
        {
            set {
                if (CheckPassword(value))
                {
                    _password = value;
                }
            }
            get
            {
                return _password;
            }

        }

  static  public bool CheckPassword(string word)
  { 
            if (string.IsNullOrEmpty(word) ||  word.Length<8 || word.Length>20) return false;
            if (!char.IsLetter(word[0])) return false;
            if (!char.IsUpper(word[0])) return false;
         
            for (int i = 1; i < word.Length; i++)
            {
                if (char.IsDigit(word[i]))
                {
                    return true;
                }
            }
            return false;
  }

    }
}
