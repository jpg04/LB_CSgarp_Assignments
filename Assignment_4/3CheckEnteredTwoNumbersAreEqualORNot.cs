// ^ Write a Program which accept two numbers and check whether numbers are equal or not.

using System;
class CkeckEquality
{
    static void Main(string[] jp)
    {
        int iValue1 = 0, iValue2 = 0;

        System.Console.WriteLine("Enter First Number : ");
        iValue1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter Second Number :");
        iValue2 = int.Parse(Console.ReadLine());

        if(iValue1==iValue2)
        {
            System.Console.WriteLine("Entered Number are Equal...!");
        }
        else
        {
            System.Console.WriteLine("Entered Number are not Equal...!");
        }
    }
}