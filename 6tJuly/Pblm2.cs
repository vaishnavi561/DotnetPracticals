using System;

class Pblm2
{
    static void Main()
    {
        int total = 20;
        int quality = 0;
        int priority = 0;
        int normal = 0;

        for (int i = 1001; i <= 1020; i++)
        {
            if (i % 4 == 0)
            {
                quality++;
                Console.WriteLine("Package " + i + " - Quality Check Required");
            }
            else if (i % 5 == 0)
            {
                priority++;
                Console.WriteLine("Package " + i + " - Priority Shipment");
            }
            else
            {
                normal++;
                Console.WriteLine("Package " + i + " - Normal Processing");
            }
        }

        Console.WriteLine();
        Console.WriteLine("Total Packages Processed = " + total);
        Console.WriteLine("Quality Check Packages = " + quality);
        Console.WriteLine("Priority Shipments = " + priority);
        Console.WriteLine("Normal Packages = " + normal);
    }
}