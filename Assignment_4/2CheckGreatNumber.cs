//^ 2.Write a Program which accept one Number from user and check whether Number is Greater Than 100 or Not.

using System;

class CheckGreater
{
    static void Main(string[] jp)
    
    {
        int iValue = 0;

        System.Console.WriteLine("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        if(iValue>100)
        {
            System.Console.WriteLine("Entered Number is Greater Than 100");
        }
        else
        {
            System.Console.WriteLine("Entered Number is Smaller Than 100");
        }
    }
}

// * take one integer user hardcode
/* 
    n=10
    str='aba'
    count a
    but 
    'abaabaabaa'
*/