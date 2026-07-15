using System;

class StationeryItem
{
    public int ItemId;
    public string ItemName;
    public string Category;
    public double Price;
    public int Quantity;
    public string Brand;

    // Method to display item details
    public void DisplayDetails()
    {
        Console.WriteLine("Item ID   : " + ItemId);
        Console.WriteLine("Item Name : " + ItemName);
        Console.WriteLine("Category  : " + Category);
        Console.WriteLine("Price     : " + Price);
        Console.WriteLine("Quantity  : " + Quantity);
        Console.WriteLine("Brand     : " + Brand);
    }

    // Method to update quantity
    public void UpdateQuantity(int qty)
    {
        Quantity = qty;
        Console.WriteLine("Quantity Updated Successfully.");
    }
}

class Module3
{
    static void Main(string[] args)
    {
        StationeryItem item = new StationeryItem();

        Console.Write("Enter Item ID: ");
        item.ItemId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Item Name: ");
        item.ItemName = Console.ReadLine();

        Console.Write("Enter Category: ");
        item.Category = Console.ReadLine();

        Console.Write("Enter Price: ");
        item.Price = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Quantity: ");
        item.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Brand: ");
        item.Brand = Console.ReadLine();

        Console.WriteLine("\nStationery Details");
        item.DisplayDetails();

        Console.Write("\nEnter New Quantity: ");
        int newQty = Convert.ToInt32(Console.ReadLine());

        item.UpdateQuantity(newQty);

        Console.WriteLine("\nUpdated Details");
        item.DisplayDetails();

        Console.ReadLine();
    }
}