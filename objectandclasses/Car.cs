using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld.objectandclasses
{
    internal class Car
    {
        public string color;
        public double price;
        public string model;
        //static variable
        public static string name;
        //methods
        //drive,start,stop
        public void Display()
        {
            //local varible
            string location = "Delhi";
            string location1 = "Mumbai";
            string location2 = "Delhi";

            Console.WriteLine(color + " " + price + " " + model);
            Console.WriteLine("location:" + location);
        }
    }
}
