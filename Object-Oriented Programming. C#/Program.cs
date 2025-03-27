using System;
using System.Diagnostics;

public class Students
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Students()
    {
        Console.WriteLine("Constructor called"); // Default constructor
    }

    ~Students()
    {
        Console.WriteLine("Destructor called for Students");
    }
}

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

    public Employee(int id, string name)
    {
        this.Name = name;
        this.Id = id;
        Console.WriteLine("Constructor called"); // Parameterized constructor
    }

    public void display()
    {
        Console.WriteLine("Id: " + Id + " Name: " + Name);
    }

    ~Employee()
    {
        Console.WriteLine("Destructor called for Employee");
    }
}

public class Animal
{
    public string name;

    public Animal(string n)
    {
        this.name = n;
    }

    public Animal(Animal animal)
    {
        this.name = animal.name; // Copy constructor
    }

    public void display()
    {
        Console.WriteLine("Name: " + name);
    }

    ~Animal()
    {
        Console.WriteLine("Destructor called for Animal");
    }
}
public class Calucation
{
    public Calucation(int a, int b)
    {
        Console.WriteLine("Addition of two numbers: " + (a + b));
    }
    public Calucation(int a, int b, int c)
    {
        Console.WriteLine("Addition of three numbers: " + (a + b + c)); //Constructor overloading
    }
    public Calucation(int a, int b, int c, int d)
    {
        Console.WriteLine("Addition of four numbers: " + (a + b + c + d));
    }
    public Calucation(int a, float b)
    {
        Console.WriteLine("Addition of two numbers: " + (a * b));
    }
}
   

    internal class Program
{
    private static void Main(string[] args)
    {
        Students s = new Students();
        s.Id = 1;
        s.Name = "John";
        Console.WriteLine("Id: " + s.Id + " Name: " + s.Name);

        Employee e = new Employee(2, "Smith");
        e.display();

        Animal a = new Animal("Dog");
        Animal b = new Animal(a);
        b.display();
        Calucation calucation = new Calucation(10, 20);
        Calucation calucation1 = new Calucation(10, 20, 30);
        Calucation calucation2 = new Calucation(10, 20, 30, 40);
        Calucation calucation3 = new Calucation(10, 20.5f);
        

        // Force garbage collection to observe destructor calls
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}
//Constructor called special method that is called when an instance of a class is created
//Destructor called for Students special method that is called when an instance of a class is destroyed
//Type of constructor: Default constructor ,Parameterized constructor, Copy constructor
//You cannot inherit a constructor from a base class
//Cannot have return type
///Contructor overloading: Multiple constructors with different parameters
/// heree we have 4 constructors with different parameters
/// 
