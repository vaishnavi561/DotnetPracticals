// SOLID ---> single responsibility 
// a class should have onlyone reason to change ,it should
//perform only one responsibilty

class Program
{
     public void CalculateTotal()
    {
         Console.WriteLine("calculate total");
    }

    public void PrintInvoice()
    {
         Console.WriteLine("PrintInvoice");
    }

     public void SaveToDB()
    {
         Console.WriteLine("saving  invoice");
    }

}