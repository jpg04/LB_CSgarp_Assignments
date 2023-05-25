//^ 1.Program which accept number from user and display its multiplication of Factors

using System;

class MultiplicationOfFactors
{
    static void Main(string[] jp)
    {
        int iValue = 0;
        int iMul = 1;
        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for(int iCnt = 1; iCnt<=(iValue/2); iCnt++)
        {
            if((iValue % iCnt)==0)
            {
                iMul = iMul * iCnt;
            }
        }
        System.Console.Write("Multiplication Factor of Entered Number is :"+iMul);
    }
}