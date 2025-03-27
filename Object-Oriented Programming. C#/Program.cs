
abstract class Animal
{
    protected abstract void Speak(); /// Abstract method
    public void Eat() => Console.WriteLine("Eating..."); /// Non-abstract method    
}
class subclass : Animal
{
    protected override void Speak() => Console.WriteLine("Meow"); /// Implementation of abstract method
    public void Sound()
    {
        Speak();
    }
}

abstract class user
{
    public  user()
    {
        Console.WriteLine("User Constructor");
    }
    public abstract void info(); /// Abstract method
    public void work() => Console.WriteLine("Devlopment..."); /// Non-abstract method

}
class subclass2 : user
{
    public override void info() => Console.WriteLine("User Info"); /// Implementation of abstract method
}

internal class Program
{
    private static void Main(string[] args)
    {
       Animal animal = new subclass();
        animal.Eat();
        subclass sub = new subclass();
        sub.Sound();
        user u = new subclass2();
        u.info();
        u.work();


    }
}
//abstract class can have abstract and non-abstract methods
//we can't create an object of an abstract class
//abstract method must be implemented in the derived class
//abstract method can't have a body
//Non-abstract method can have a body
// non-abstract method can be called using the object of the derived class
//ABtract class can have a constructor
//