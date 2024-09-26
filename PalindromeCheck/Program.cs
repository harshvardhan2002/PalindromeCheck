using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeCheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;
            Console.WriteLine("Enter a number: ");
            int number= Convert.ToInt32(Console.ReadLine());
            int tempNumber = number;
            while (tempNumber > 0)
            {
                value = value * 10;
                int temp = tempNumber % 10;
                value=value + temp;
                
                tempNumber = tempNumber / 10;
            }

            if (value == number)
            {
                Console.WriteLine("Yes, " +number+ " is a Palindrome.");
            }
            else
            {
                Console.WriteLine("No, " +number+ " is not a Palindrome.");
            }
        }
    }
}
