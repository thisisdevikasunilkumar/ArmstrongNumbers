using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumbers_OrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it's an Armstrong number: ");
            int number = int.Parse(Console.ReadLine());
            int sum = 0, temp, rem;
            temp = number;

            while (temp != 0)
            {
                rem = temp % 10;
                sum = sum + rem * rem * rem;
                temp /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is an Armstrong number.");
            }
            else
            {
                Console.WriteLine(number + " is not an Armstrong number.");
            }
            Console.ReadLine();
        }
    }
}
