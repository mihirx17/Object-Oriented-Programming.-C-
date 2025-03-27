
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace UserModule
{
    public class Program
    {
        private class UserInformation
        {
            [Required]

            private int UserName { get; set; }

            private void Display()
            {
                Console.WriteLine($"User Name: {UserName}");
            }
            public void SetUserName(int userName)
            {
                UserName = userName;
                Console.WriteLine(userName);
            }
        }
        //private class Subclass : UserInformation
        //{
        //    public void Display()
        //    {
        //        Console.WriteLine($"User Name: {UserName}");
        //    }

        //}
        public class AnotheruserInfomation
        {
            [Required]
            public string? username { get; set; }
            public void Display()
            {
                Console.WriteLine($"User Name: {username}");
            }
        }
        public class subclass : AnotheruserInfomation
        {
            public void Display()
            {
                Console.WriteLine($"User Name: {username}");
            }
        }
        public class Employee
        {
            protected string? username { get; set; }
           
        }
        public class sub : Employee
        {
            public void subDisplay()
            {
                this.username = "Mihir";
                Console.WriteLine($"User Name: {username}");
            }
        }

        private static void Main(string[] args)
        {
            UserInformation userInformation = new UserInformation();
            userInformation.SetUserName(1);
            AnotheruserInfomation anotheruserInfomation = new AnotheruserInfomation();
            //userInformation.Display();
            anotheruserInfomation.username = "Mihir";
            anotheruserInfomation.Display();
            subclass subclass = new subclass();
            subclass.username = "Mihir";
            subclass.Display();
            sub sub = new sub();
                sub.subDisplay();
        }
    }
}


//public can be accessed from anywhere
//private can be accessed only within the class
//protected can be accessed within the class and its derived class
//internal can be accessed within the assembly
//protected cannot be accessed from the object of the class

