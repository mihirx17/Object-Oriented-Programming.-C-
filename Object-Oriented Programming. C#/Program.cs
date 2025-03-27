
abstract class Animal
{
    protected abstract void Speak(); /// Abstract method
    protected void Eat() => Console.WriteLine("Eating..."); /// Non-abstract method    
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
        subclass obj = new subclass();
        obj.Sound();

    }
}