//^ 4. Accept one number and check whether it is divisible by 5 or not.
using System;
class CheckDivisibility
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.WriteLine("Enter Number");
        iValue = int.Parse(Console.ReadLine());

        if((iValue % 5)==0)
        {
            System.Console.WriteLine("Number is Divisible By 5.");
        }
        else
        {
            System.Console.WriteLine("Number is Not DiviSible By 5.");
        }
    }
}