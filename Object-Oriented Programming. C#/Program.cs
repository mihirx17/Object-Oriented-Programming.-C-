public class Userinfomation
{
    private int Amount;
    public void SetAmount(int amount)
    {
        Amount = amount;
    }
    public void GetAmount()
    {
        Console.WriteLine(Amount);
    }
    public Userinfomation()
    {
       Console.WriteLine("Welcome to the User Information");
    }
    
}
public class subUserinfomation : Userinfomation
{
    public subUserinfomation()
    {
        Console.WriteLine("Welcome to the Sub User Information");
    }
}
    internal class Program
{
    private static void Main(string[] args)
    {
        Userinfomation user = new Userinfomation();
        user.SetAmount(100);
        user.GetAmount();
        subUserinfomation subuser = new subUserinfomation();
     subuser.SetAmount(200);
        subuser.GetAmount();
    }
}

//Encapsulation in C# with Example - Object-Oriented Programming. C%23
// we need to use Private access modifier to hide the data from the outside world.
// we can use subclass to access the private data of the base class.
// We can acces through the public method of the base class.