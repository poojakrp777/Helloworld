﻿using System;
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

        //methods
        //drive,start,stop
        public void Display()
        {
            Console.WriteLine(color + " " + price + " " + model);
        }
    }
}
