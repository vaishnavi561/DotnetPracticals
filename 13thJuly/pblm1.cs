
// Problem Statement
// Create a console application for customer registration and login.
// User Inputs
// •	Enter Customer ID 
// •	Enter Name 
// •	Enter Email 
// •	Enter Password 
// Store the customer details.
// Display:
// Registration Successful
// Now ask the user to login.
// Enter Email:
// Enter Password:
// Allow only 3 attempts.
// If credentials are correct:
// Welcome <Customer Name>
// otherwise
// loked
// give code in c#


using System;

class pblm1
{
    static void Main(string[] args)
    {
        // Registration
        Console.WriteLine("===== Customer Registration =====");

        Console.Write("Enter Customer ID: ");
        int customerId = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter Password: ");
        string password = Console.ReadLine();

        Console.WriteLine("\nRegistration Successful!");

        // Login
        Console.WriteLine("\n===== Customer Login =====");

        int attempts = 3;
        bool loginSuccess = false;

        while (attempts > 0)
        {
            Console.Write("Enter Email: ");
            string loginEmail = Console.ReadLine();

            Console.Write("Enter Password: ");
            string loginPassword = Console.ReadLine();

            if (loginEmail == email && loginPassword == password)
            {
                Console.WriteLine("\nWelcome " + customerName);
                loginSuccess = true;
                break;
            }
            else
            {
                attempts--;

                if (attempts > 0)
                {
                    Console.WriteLine("Invalid Email or Password.");
                    Console.WriteLine("Attempts Left: " + attempts);
                }
            }
        }

        if (!loginSuccess)
        {
            Console.WriteLine("\nAccount Locked!");
        }

        Console.ReadLine();
    }
}