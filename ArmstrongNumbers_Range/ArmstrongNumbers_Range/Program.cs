using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumbers_Range
{
    class Armstrong
    {
        static void Main(string[] args)
        {
            int sum, start, end, i, rem, temp;

            Console.Write("Enter the start number: ");
            start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number:");
            end = int.Parse(Console.ReadLine());

            Console.WriteLine("Armstrong Numbers Between " + start + " and " + end + ":");
            for (i = start; i <= end; i++)
            {
                temp = i;
                sum = 0;
                while (temp != 0)
                {
                    rem = temp % 10;
                    sum = sum + rem * rem * rem;
                    temp = temp / 10;
                }
                if (i == sum)
                {
                    Console.WriteLine(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
