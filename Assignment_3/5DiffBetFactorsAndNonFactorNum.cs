//^ 5.Write Program which accept number from user and display difference between Factors and Non factors numbers.

using System;
class DiffBetFactorsAndNonFactorNum
{
    static void Main(string[] jp)
    {
        int iValue = 0;
        int iSum = 0;
        int iSub = 0;

        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for(int iCnt = 1; iCnt<iValue; iCnt++)
        {
            if((iValue%iCnt)==0)
            {
                iSum = iSum + iCnt;
            }
            else
            {
                iSub = iSub + iCnt;
            }
        }
        System.Console.WriteLine("Difference Between Factor and Non Factor Numbers is : "+(iSum-iSub));
    }
}