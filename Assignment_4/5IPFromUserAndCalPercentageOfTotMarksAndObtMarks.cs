// ^ Write a program which accept total marks & obtained marks from user and calculate percentage

using System;

class CalculatePercentage
{
    static void Main(string[] jp)
    {
        int tmarks = 0;
        int omarks = 0;

        float percentage = 0.0f;

        if (tmarks == 0)
        {
            tmarks = 1;
        }
        if (omarks == 0)
        {
            omarks = 1;
        }

        System.Console.WriteLine("Enter Total Marks : ");
        tmarks = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Obtained Marks : ");
        omarks = int.Parse(Console.ReadLine());

        percentage = (omarks / tmarks);

        System.Console.WriteLine("Percentage is : " + (percentage * 100));
    }
}