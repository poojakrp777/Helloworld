﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.csharpBasicprogram
{
    internal class SwapNumber
    {
        public static void SwappingNumber()
        {
            Console.WriteLine("Enter the Number a: ");
            int a = Convert.ToInt32(Console.ReadLine());//5
            Console.WriteLine("Enter the Number b: ");     
            int b = Convert.ToInt32(Console.ReadLine());//10
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a * b; //a=50 (5*10)      
            b = a / b; //b=5 (50/10)      
            a = a / b; //a=10 (50/5)    
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
