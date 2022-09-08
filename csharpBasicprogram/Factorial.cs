using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.csharpBasicprogram
{
    internal class Factorial
    {
        public static void FindFactorial()
        {
            int fact = 1;
            Console.Write("Enter any Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + number + " is: " + fact);
        }
    }
}
