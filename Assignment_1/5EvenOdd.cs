//^ 5. Accept number from user and check whether number is even or odd.

using System;

class EvenOdd
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.Write("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        if((iValue % 2)==0)
        {
            System.Console.WriteLine("Entered Number is Even");
        }
        else
        {
            System.Console.WriteLine("Entered Number is Odd");
        }
    }
}