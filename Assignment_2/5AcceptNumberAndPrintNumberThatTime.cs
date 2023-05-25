// 5. Accept one number from user and print that number of * on screen.
using System;
class DisplayNumber
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for(int i =0; i<5; i++)
        {
            System.Console.Write("*\t");
        }
    }
}