
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
namespace UserModule
{
    public class Program
    {
        private class UserInformation
        {
            public UserInformation()
            {
                Console.WriteLine("UserInformation Constructor");
            }
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
// inheritance transfer the properties and methods of the base class to the derived class.
// Inheritance is a mechanism in which one class acquires the property of another class.
//they are two types of inheritance in C#.
//1. Single Inheritance
//2. Multiple Inheritance
// In C#, a class can inherit from only one class. It is called single inheritance.
// In C#, a class can inherit from multiple interfaces. It is called multiple inheritance.
//hybrid inheritance is a combination of single and multiple inheritance.
//In C#, a class can inherit from multiple interfaces, but a class cannot inherit from multiple classes.
