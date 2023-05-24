//^ 1.Accept one number from user and print that number of * on screen.
using System;
class IPFromUser
{
    static void Main(string[] jp)
    {
        int iValue = 0,i;
        System.Console.Write("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for(i=0; i<iValue; i++)
        {
            System.Console.Write("*\t");
        }
    }
}
