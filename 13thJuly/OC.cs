//O- open/closed principle
//Software-should be open for extensions but close for modifications

using System.ComponentModel.DataAnnotations;

class Oc
{
//     public void Pay(string method)
//     {
//         if (method == "creditcard")
//         {
//             Console.WriteLine("paid using upi");

//         }
//         else if (method == "cash")
//         {
//             Console.WriteLine("paid using cash in bank");
//         }
//     }
public void Process(Payment p)

    {
         p.Pay();
    }

    static void Main()
    {
        Oc c=new Oc();
        c.Process(new CreditCard());
        
    }





 }