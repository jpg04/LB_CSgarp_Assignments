//^ 3. Program to print 5 to 1 numbers on screen.
using System;
class DisplayNumber
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for (int i = iValue; i >= 1; i--)
        {
            System.Console.Write(i+"\t");
        }
    }
}