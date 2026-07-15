
//Create a C# Console Application for a Product Management and Shopping Cart System. Create a Product class with ProductId, ProductName, Price, Stock, and Quantity. Allow the user to add and display products, search a product by name, and add products to a shopping cart after checking stock availability. Display the cart, calculate the total amount, apply discounts based on the purchase amount, and display the final bill. Finally, allow the user to choose a payment method using a switch statement and display "Payment Successful" or "Invalid Option"


using System;
using System.Collections.Generic;

class Product
{
    public int ProductId;
    public string ProductName;
    public double Price;
    public int Stock;
    public int Quantity;
}

class pblm2
{
    static void Main(string[] args)
    {
        List<Product> productList = new List<Product>();
        List<Product> cart = new List<Product>();

        Console.Write("How many products do you want to add? ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Add Products
        for (int i = 1; i <= n; i++)
        {
            Product p = new Product();

            Console.WriteLine("\nEnter Product " + i + " Details");

            Console.Write("Enter Product ID: ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            p.ProductName = Console.ReadLine();

            Console.Write("Enter Price: ");
            p.Price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Stock: ");
            p.Stock = Convert.ToInt32(Console.ReadLine());

            productList.Add(p);
        }

        // Display Products
        Console.WriteLine("\n----- Product List -----");

        foreach (Product p in productList)
        {
            Console.WriteLine("Product ID   : " + p.ProductId);
            Console.WriteLine("Product Name : " + p.ProductName);
            Console.WriteLine("Price        : " + p.Price);
            Console.WriteLine("Stock        : " + p.Stock);
            Console.WriteLine();
        }

        // Search Product
        Console.Write("Enter Product Name to Search: ");
        string searchName = Console.ReadLine();

        bool found = false;

        foreach (Product p in productList)
        {
            if (p.ProductName.ToLower() == searchName.ToLower())
            {
                found = true;

                Console.WriteLine("\nProduct Found");
                Console.WriteLine("Product ID   : " + p.ProductId);
                Console.WriteLine("Product Name : " + p.ProductName);
                Console.WriteLine("Price        : " + p.Price);
                Console.WriteLine("Stock        : " + p.Stock);

                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("Product Not Found");
        }

        // Add to Cart
        double totalAmount = 0;
        int choice;

        do
        {
            Console.Write("\nEnter Product ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            bool productFound = false;

            foreach (Product p in productList)
            {
                if (p.ProductId == id)
                {
                    productFound = true;

                    if (p.Stock >= qty)
                    {
                        p.Stock = p.Stock - qty;

                        Product item = new Product();
                        item.ProductId = p.ProductId;
                        item.ProductName = p.ProductName;
                        item.Price = p.Price;
                        item.Quantity = qty;

                        cart.Add(item);

                        totalAmount = totalAmount + (p.Price * qty);

                        Console.WriteLine("Product Added to Cart");
                    }
                    else
                    {
                        Console.WriteLine("Stock Not Available");
                    }

                    break;
                }
            }

            if (!productFound)
            {
                Console.WriteLine("Product Not Found");
            }

            Console.WriteLine("\nDo you want to add another product?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            choice = Convert.ToInt32(Console.ReadLine());

        } while (choice == 1);

        // Display Cart
        Console.WriteLine("\n----- Cart -----");

        foreach (Product p in cart)
        {
            Console.WriteLine(p.ProductName + " x" + p.Quantity);
        }

        // Discount Calculation
        double discount = 0;

        if (totalAmount < 1000)
        {
            discount = 0;
        }
        else if (totalAmount >= 1000 && totalAmount <= 4999)
        {
            discount = totalAmount * 0.10;
        }
        else if (totalAmount >= 5000 && totalAmount <= 9999)
        {
            discount = totalAmount * 0.20;
        }
        else
        {
            discount = totalAmount * 0.30;
        }

        double finalAmount = totalAmount - discount;

        Console.WriteLine("\nTotal Amount : " + totalAmount);
        Console.WriteLine("Discount     : " + discount);
        Console.WriteLine("Final Amount : " + finalAmount);

        // Payment
        Console.WriteLine("\nChoose Payment Method");
        Console.WriteLine("1. UPI");
        Console.WriteLine("2. Credit Card");
        Console.WriteLine("3. Debit Card");
        Console.WriteLine("4. Cash on Delivery");

        Console.Write("Enter Choice: ");
        int payment = Convert.ToInt32(Console.ReadLine());

        switch (payment)
        {
            case 1:
                Console.WriteLine("Payment Successful");
                break;

            case 2:
                Console.WriteLine("Payment Successful");
                break;

            case 3:
                Console.WriteLine("Payment Successful");
                break;

            case 4:
                Console.WriteLine("Payment Successful");
                break;

            default:
                Console.WriteLine("Invalid Option");
                break;
        }

        Console.ReadLine();
    }
}