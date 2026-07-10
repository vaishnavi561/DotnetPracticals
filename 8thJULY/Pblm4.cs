using System;
using System.Collections.Generic;

class Pblm4
{
    static void Main()
    {
        List<string> book = new List<string>();

        book.Add("Wings of Fire");
        book.Add("My Experiments with Truth");
        book.Add("Playing It My Way");
        book.Add("The Race of My Life");
        book.Add("An Autobiography");

        Console.WriteLine("Available Books:");

        foreach (string b in book)
        {
            Console.WriteLine(b);
        }

        book.Add("The Story of My Life");
        Console.WriteLine("\nNew Book Added.");

        book.Remove("Playing It My Way");
        Console.WriteLine("One Book Removed.");

        Console.WriteLine("\nUpdated Book List:");

        foreach (string b in book)
        {
            Console.WriteLine(b);
        }

        Console.WriteLine("\nTotal Books = " + book.Count);
    }
}