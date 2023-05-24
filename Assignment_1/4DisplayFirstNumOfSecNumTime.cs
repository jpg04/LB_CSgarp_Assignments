//^  4. Accept two numbers from user and display first number in second number of times.
using System;
class DisplayNum
{
    static void Main(string[] jp)
    {
        int iValue1 = 0;
        int iCount = 0;
        int i =0;

        System.Console.Write("Enter First Number :");
        iValue1 = int.Parse(Console.ReadLine());
        System.Console.Write("Enter Second Number :");
        iCount = int.Parse(Console.ReadLine());

        if(iCount<0)
        {
            iCount = -(iCount);
        }
        for(i=0; i<iCount; i++)
        {
            System.Console.Write(iValue1+"\t");
        }


    }
}