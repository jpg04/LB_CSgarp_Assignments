// ^ Write a program which accept three numbers from user and print its multiplication

using System;

class DisplayMultiplication
{
    static void Main(string[] jp)
    {
        
        int iValue1 = 0, iValue2= 0 , iValue3 = 0;
        int iMul = 0;
        
        if(iValue1==0)
        {
            iValue1 = 1;
        }
        else if(iValue2==0)
        {
            iValue2=1;
        }
        else if(iValue3==0)
        {
            iValue3=1;
        }

        System.Console.WriteLine("Enter First Numbers : ");
        iValue1 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Second Numbers : ");
        iValue2 = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Third Numbers : ");
        iValue3 = int.Parse(Console.ReadLine());

        iMul = iValue1*iValue2*iValue3;

        System.Console.WriteLine("Multiplication of Three Number is : "+iMul);
    }
}