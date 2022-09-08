﻿using Helloworld.csharpBasicprogram;
using Helloworld.objectandclasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose any one program from below options");
            Console.WriteLine("1:ObjectAndClass concept\n2:Fibonoccie Series\n3.Reverse Number\n4.Palindrome\n5.SumOfDigits\n6.ReverseWord\n7.PrimeNumber\n8.Factorial\n9.Swapping Number\n10.OddorEven");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Welcome to Fellowship");
                    //maruti object
                    Car maruti = new Car();
                    Car.name = "Suzuki";
                    Console.WriteLine("static variable:" + Car.name);
                    maruti.color = "red";
                    maruti.price = 87732;
                    maruti.model = "marutii";
                    maruti.Display();

                    Console.WriteLine("\nDog implementation");
                    //Syntax for object creation of any class
                    //className variable=new classname();
                    Dog dog1 = new Dog();
                    dog1.color = "brown";
                    dog1.breed = "pugBreed";
                    dog1.name = "pug";
                    dog1.DogDetails();
                    break;
                case 2:
                    Console.WriteLine("\nFibonoccie series");
                    Console.WriteLine("Please enter numb to generate n series");
                    int n = Convert.ToInt32(Console.ReadLine());
                    fibonaccieseries.FindSeries(n);
                    break;
                case 3:
                    Console.WriteLine("Enter any number to find reverse");
                    int number = Convert.ToInt32(Console.ReadLine());
                    ReverseNumber.Reverse(number);
                    break;
                case 4:
                    PalindromNumber.FindPolyndrome();
                    break;
                case 5:
                    Console.WriteLine("Enter any number to find sum of its digits");
                    int numb = Convert.ToInt32(Console.ReadLine());
                    SumOfDigits.FindSumOfDigits(numb);
                    break;
                case 6:
                    ReverseWord.ReadInput();
                    break;
                case 7:
                    PrimeNumber.FindPrimes();
                    break;
                case 8:
                    Factorial.FindFactorial();
                    break;
                case 9:
                    SwapNumber.SwappingNumber();
                    break;
                case 10:
                    OddOrEven.Oddreven();
                    break;

                default:
                    Console.WriteLine("Please enter number within range");
                    break;
            }
            Console.ReadLine();
        }
    }
}
