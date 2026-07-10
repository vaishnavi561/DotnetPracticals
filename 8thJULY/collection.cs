//collections -group of objects that can grow or shrink dynamically
using System.Collections.Generic;
class collections{
static void Main()
{
    List<String> names=new List<string>();
    names.Add("Vaishnavi");
    names.Add("shambhu");
    names.Add("surekha");
    names.Add("shruti");
    names.Add("shri");
    foreach( String  Names in names)
    {
        Console.WriteLine( Names);
    }
}
}