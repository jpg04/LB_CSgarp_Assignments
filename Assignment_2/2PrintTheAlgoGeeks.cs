// ^2. Program to print 5 times TheAlgoGeeks on screen.
using System;
class DisplayTheAlgoGeeks
{
    static void Main(string[] jp)
    {
        int iValue = 0;
        int i = 0;

        System.Console.WriteLine("Enter Number :");
        iValue = int.Parse(Console.ReadLine());

        for (i = 1; i <= iValue; i++)
        {
            System.Console.WriteLine("TheAlgoGeeks");
        }
    }
}