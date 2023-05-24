//^ 3. Accept one number from user if number is less than 10 then print "Hello" otherwise print "Demo".

using System;

class IPFromUser
{
    static void Main(string[] jp)
    {
        int iValue = 0;

        System.Console.Write("Enter Number : ");
        iValue = int.Parse(Console.ReadLine());

        if(iValue<10)
        {
            System.Console.WriteLine("Hello");
        }
        else
        {
            System.Console.WriteLine("Demo");
        }
        
    }
}