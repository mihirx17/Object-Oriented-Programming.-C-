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