/// Homework7
/// File Name: Odometer
/// @author: Dakota Durst
/// Date: October 25, 2020
///
/// Problem Statement: 
/// Define an odometer whose job is to track miles and fuel efficentcy for a car trip.
///
///
/// Overall Plan:
/// 1) create base classes that set miles, fuel efficency with adding and reseting
/// 2) create forsting/boolean check if equal
/// 3) create tester program that runs through the various classes with strings
/// 4) print results to console to make sure everything functions correctly. 
/// 5) 

using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer trip1 = new Odometer();
            trip1.Add(55, 10);
            Console.WriteLine("fuel used for trip1 is: " + trip1.mpg());
            Odometer trip2 = new Odometer(50, 10);
            trip1.Add(100, 20);
            Console.WriteLine("fuel used for trip2 is: " + trip2.mpg());
            Console.WriteLine("This is trip1: " + trip1.toString());
            Console.WriteLine("This is trip2: " + trip2.toString());
            if (trip1.equals(trip2))
            {
                Console.WriteLine("The two objects are the same");
            }
            else
            {
                Console.WriteLine("The two objects are not the same");
            }
            Console.WriteLine("This is the amount of miles per gallen: " + trip1.mpg());
            Console.WriteLine("This is the amount of miles per gallen: " + trip2.mpg());
            trip1.Reset();
            Console.WriteLine(trip1.toString());

        }
        public static int add(int n1, int n2)
        {
            return n1 + n2;
        }

    }
}
