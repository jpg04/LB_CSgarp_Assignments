//^ 3.write Program which accept number from user and display its Non factors numbers
using System;
class DisplayNonFactors
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.WriteLine("Enter Number :");
        iValue = int.Parse(Console.ReadLine());

        for(int iCnt=1; iCnt<=iValue; iCnt++ )
        {
            if((iValue % iCnt) !=0)
            {
                System.Console.Write(iCnt+"\t");
            }
        }
    }
}