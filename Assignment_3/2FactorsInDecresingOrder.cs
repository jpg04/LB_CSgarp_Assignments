//^ 2.Program which accept number from user and display its factors is decreasing order
using System;

class FactorsInDescreasingOrder
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for(int iCnt = iValue; iCnt>=1; iCnt--)
        {
            if((iValue%iCnt)==0)
            {
                System.Console.Write(iCnt+"\t");
            }
        }
    }
}
