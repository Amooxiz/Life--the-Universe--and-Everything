using System;
using System.Collections.Generic;

namespace TEST___Life__the_Universe__and_Everything
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (input != 42)
            {
                Console.WriteLine(input);
                input = Convert.ToInt32(Console.ReadLine());
                i++;
            }

        }
    }
}
