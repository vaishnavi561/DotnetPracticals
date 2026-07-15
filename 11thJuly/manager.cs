using System;

public class manager: Employee
{
    public string dept;
    public double Bonus;

    public manager(int i,string e,double s, string d, double b):base(i,e,s)
    {
        dept=d;

    }
    public void DisplayManager()
    {
        DisplayManager();
        Console.WriteLine("Dept:"+ dept);
        Console.WriteLine("bonus:"+ Bonus);
        Console.WriteLine("----------------");

    }
}