using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibleby11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);
            int t = 0;
            for (int i = 0; i < input.Length; i++)
            {
                int digit = input[i] - '0';
                if (i % 2 == 0)
                    t += digit;
                else
                    t -= digit;
            }
            if (t % 11 == 0)
                Console.WriteLine(n + " is divisible by 11.");
            else
                Console.WriteLine(n + " is not divisible by 11.");
        }
    }
}
