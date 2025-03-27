interface  Animal
{
    void animalSpeak(); //abstract method
   
}
interface Humanbeing
{
    void HumanSpeak(); //abstract method
}

class subclass : Animal,Humanbeing
{
   public void  animalSpeak()
    {
        Console.WriteLine("Memooow");
    }
    public void HumanSpeak()
    {
        Console.WriteLine("Hiii i Am Mihir");
    }

}



internal class Program
{
    private static void Main(string[] args)
    {
        subclass subclass = new subclass();
        subclass.animalSpeak();
        subclass.HumanSpeak();
     
    }
}
//interface can be inherited by another interface
//interface can be inherited by class
//interface have only abstract method but you need to implement it in class
//interface cannot have constructor
//interface cannot have field
//interface cannot have property
//interface cannot have method body
//interface can have property but only declaration
