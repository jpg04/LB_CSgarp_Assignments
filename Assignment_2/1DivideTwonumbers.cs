//^ 1.Program to divide two numbers

using System;
class Divide
{
    static void Main(string[] jp)
    {
        int iValue1 = 0;
        int iValue2 = 0;

        System.Console.WriteLine("Enter First Number : ");
        iValue1 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter First Number : ");
        iValue2 = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Division is : "+(iValue1/iValue2));

    }
}