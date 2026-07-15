using System;
using System.Collections.Generic;

class Stationery
{
    public int ItemId;
    public string ItemName;
    public double Price;
    public int Stock;
}

class pblm1
{
    static void Main(string[] args)
    {
        // Login
        Console.Write("Enter Username: ");
        string user = Console.ReadLine();

        Console.Write("Enter Password: ");
        string pass = Console.ReadLine();

        if (user != "admin" || pass != "admin123")
        {
            Console.WriteLine("Invalid Login");
            return;
        }

        List<Stationery> itemList = new List<Stationery>();

        int choice;

        do
        {
            Console.WriteLine("\n-----------------------------");
            Console.WriteLine("Stationery Store Management");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1. Add Item");
            Console.WriteLine("2. Display Items");
            Console.WriteLine("3. Search Item");
            Console.WriteLine("4. Update Item");
            Console.WriteLine("5. Delete Item");
            Console.WriteLine("6. Purchase Item");
            Console.WriteLine("7. Low Stock");
            Console.WriteLine("8. Sort Items");
            Console.WriteLine("9. Exit");

            Console.Write("Enter Choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Stationery s = new Stationery();

                    Console.Write("Enter Item ID: ");
                    s.ItemId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Item Name: ");
                    s.ItemName = Console.ReadLine();

                    Console.Write("Enter Price: ");
                    s.Price = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter Stock: ");
                    s.Stock = Convert.ToInt32(Console.ReadLine());

                    itemList.Add(s);
                    Console.WriteLine("Item Added");
                    break;

                case 2:
                    foreach (Stationery i in itemList)
                    {
                        Console.WriteLine(i.ItemId + " " + i.ItemName + " " + i.Price + " " + i.Stock);
                    }
                    break;

                case 3:
                    Console.Write("Enter Item ID: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    foreach (Stationery i in itemList)
                    {
                        if (i.ItemId == id)
                        {
                            Console.WriteLine(i.ItemId + " " + i.ItemName + " " + i.Price + " " + i.Stock);
                        }
                    }
                    break;

                case 4:
                    Console.Write("Enter Item ID: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    foreach (Stationery i in itemList)
                    {
                        if (i.ItemId == id)
                        {
                            Console.Write("Enter New Price: ");
                            i.Price = Convert.ToDouble(Console.ReadLine());

                            Console.Write("Enter New Stock: ");
                            i.Stock = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Item Updated");
                        }
                    }
                    break;

                case 5:
                    Console.Write("Enter Item ID: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    foreach (Stationery i in itemList)
                    {
                        if (i.ItemId == id)
                        {
                            itemList.Remove(i);
                            Console.WriteLine("Item Deleted");
                            break;
                        }
                    }
                    break;

                case 6:
                    Console.Write("Enter Item ID: ");
                    id = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Quantity: ");
                    int qty = Convert.ToInt32(Console.ReadLine());

                    foreach (Stationery i in itemList)
                    {
                        if (i.ItemId == id)
                        {
                            if (i.Stock >= qty)
                            {
                                i.Stock -= qty;
                                Console.WriteLine("Purchase Successful");
                            }
                            else
                            {
                                Console.WriteLine("Stock Not Available");
                            }
                        }
                    }
                    break;

                case 7:
                    Console.WriteLine("Low Stock Items");

                    foreach (Stationery i in itemList)
                    {
                        if (i.Stock < 5)
                        {
                            Console.WriteLine(i.ItemName + " - " + i.Stock);
                        }
                    }
                    break;

                case 8:
                    itemList.Sort((a, b) => a.ItemName.CompareTo(b.ItemName));

                    Console.WriteLine("Items Sorted");

                    foreach (Stationery i in itemList)
                    {
                        Console.WriteLine(i.ItemId + " " + i.ItemName);
                    }
                    break;

                case 9:
                    Console.WriteLine("Thank You");
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        } while (choice != 9);
    }
}