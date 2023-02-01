using System;
using System.ComponentModel;

namespace Static_Abstraction_task__academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task-User

            //Console.WriteLine("Username daxil edin:");
            //string username = Console.ReadLine();

            //string password;
            //do
            //{
            //    Console.WriteLine("Passwordu daxil edin:");
            //    password = Console.ReadLine();
            //} while (!User.CheckPassword(password));


            //User us1 = new User
            //{
            //    Password = password,
            //    UserName = username
            //};
            #endregion

            #region Task-Student
            Student st1 = new Student();
            Student st2 = new Student();
            Student st3 = new Student();
            Student st4 = new Student();
            Console.WriteLine(st3.No);
            Console.WriteLine(st2.No);
            
            #endregion



        }
    }
}
