
public class Student
{
    public int Id;
    public string Name;
    public string Stream;
    public void Display()
    {
        Console.WriteLine("Id: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Stream: " + Stream);
    }
    
}
    public class Emp
{
    public int Psnumber;
    public string Name;
    public string Department;
    public void GetValues( int Ps,string Name,string Dep)
    {
        this.Name=Name;
        this.Psnumber = Ps;
        this.Department = Dep;
    }
    public void setvalues()
    {
        Console.WriteLine("Psnumber: " + Psnumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Department: " + Department);
    }

}


    internal class Program

{
    private static void Main(string[] args)
    {
        Student student = new Student();
        student.Id = 1;
        student.Name = "John";
        student.Stream = "Computer Science";
        student.Display();
        Emp emp = new Emp();
        emp.GetValues(1, "John", "Computer Science");
        emp.setvalues();
    }
}