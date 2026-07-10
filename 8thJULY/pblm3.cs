using System;

class  pblm3

{
    static void Main()
    {
        int[] a = { 25000, 32000, 28000, 35000, 30000, 27000 };

        int sum = 0;
        int max = a[0];
        int min = a[0];

        Console.WriteLine("Monthly Sales");

        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine("Employee " + (i + 1) + " = " + a[i]);

            sum = sum + a[i];

            if (a[i] > max)
            {
                max = a[i];
            }

            if (a[i] < min)
            {
                min = a[i];
            }
        }

        double avg = (double)sum / 6;

        Console.WriteLine();
        Console.WriteLine("Total Sales = " + sum);
        Console.WriteLine("Average Sales = " + avg);
        Console.WriteLine("Highest Sales = " + max);
        Console.WriteLine("Lowest Sales = " + min);
    }
}