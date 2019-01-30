using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int PINCODE = 0000;
            int failCounter = 0;
            do
            {
                Console.WriteLine("Enter your pin code");
                string strValue = Console.ReadLine();
                int theValue = Convert.ToInt32(strValue);

                if (theValue == PINCODE)
                {
                    Console.WriteLine("Thank you very much");
                    Console.ReadLine();
                }
                else
                {
                    failCounter = failCounter + 1;
                    Console.WriteLine("Wrong ping, please try again");
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (failCounter > 3);
        }
    }
}
