using System;

class Pblm1
{
    static void Main()
    {
        int sum = 0;
        int maintainCount = 0;
        int normalCount = 0;
        int efficientCount = 0;

        for (int i = 1; i <= 30; i++)
        {
            int watt = 80 + (i * 5);
            sum += watt;

            Console.Write("Street Light " + i + " : " + watt + " W --> ");

            if (watt > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintainCount++;
            }
            else if (watt >= 140)
            {
                Console.WriteLine("Normal Operation");
                normalCount++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                efficientCount++;
            }
        }

        double avg = sum / 30.0;

        Console.WriteLine("\nTotal Power = " + sum + " W");
        Console.WriteLine("Average Power = " + avg + " W");
        Console.WriteLine("Maintenance Required Lights = " + maintainCount);
        Console.WriteLine("Normal Operation Lights = " + normalCount);
        Console.WriteLine("Energy Efficient Lights = " + efficientCount);
    }
}