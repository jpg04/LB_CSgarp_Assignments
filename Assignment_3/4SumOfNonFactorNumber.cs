//^ 4.Write Program which accept number from user and display summation of non factors numbers.

using System;

class SumOfNonFactorNum
{
    static void Main(string[] jp)
    {
        int iValue = 0;
        int iSum = 0;

        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        for(int iCnt=1; iCnt<iValue; iCnt++)
        {
            if((iValue%iCnt)!=0)
            {
                iSum = iSum + iCnt;
            }
        }
        System.Console.WriteLine("Summation of Non Factors Numbers is : "+iSum);
    }
}
