//^ 2. Accept one number from user and print that number of * on screen Using while loop.
using System;

class IPFromUser
{
    static void Main(string[] jp)
    {
        int iValue = 0;
        int i = 0;

        System.Console.Write("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        while(i<iValue)
        {
            System.Console.Write("*\t");
            i++;
        }
    }
}