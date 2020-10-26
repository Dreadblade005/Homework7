using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    public class Odometer
    {
        //Instance variables 
        private int miles;
        private double fuelused; //gallons of fuel used

        //constructors 
        public Odometer ()
        {
            miles = 0;
            fuelused = 15;
        }
        public Odometer(int m, double f)
        {
            miles = m;
            fuelused = f;
        }

        //methods
        public void Setmiles(int m)
        {
            miles = m;
        }
        public int Getmiles()
        {
            return miles;
        }
        public void Setfuelused(double f)
        {
            fuelused = f;
        }
        public double Getfuelused()
        {
            return fuelused;
        }

        public void Reset()
        {
            miles = 0;
            fuelused = 0;
        }
        public void Add(int m , double f)
        {
            miles += m;
            fuelused += f; 
        }
        public double mpg()
        {
           return (miles / fuelused);
        }
        public string toString()
        {
            return " " + miles + " Miles driven and " + fuelused + " gallons used.";
        }
 


        public bool equals(Odometer other)
        {
           // return (this.miles == other.miles) && (this.fuelused == other.fuelused);
            return (this.Getmiles() == other.Getmiles()) && (this.Getfuelused() == other.Getfuelused());
        }
    }
}
