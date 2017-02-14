/*
 *  Author: Troy Davis
 *  Project: Overloaded Constructors - Console (Chapter 9, example is Figures 9-25, p384)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 9, 2017 
 *  Revision: Original
 */

using System;

namespace OverloadedConstructors
{
    class Driver
    {
        static void Main(string[] args)
        {
            // initialize console
            Console.WriteLine("Overloaded Constructors\n");

            // using overloaded constructors
            Ball b1 = new Ball();
            Ball b2 = new Ball("Green");
            Ball b3 = new Ball(16.0, "Blue");

            // output showing variations based on overloaded constructors
            b1.Bounce();
            b2.Roll();
            b3.Roll();

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }

    class Ball
    {
        public int id { get; set; }
        public double Diameter { get; set; }
        public String Color { get; set; }

        // constructor variations below
        public Ball()
        {
            // default
            this.Diameter = 10.0;
            this.Color = "Red";
        }
        public Ball(String col)
        {
            // default Diameter, user specified Color
            this.Diameter = 10.0;
            this.Color = col;
        }
        public Ball(double dia, String col)
        {
            // user specified Diameter and Color
            this.Diameter = dia;
            this.Color = col;
        }
        public void Roll()
        {
            Console.WriteLine("\t{0} inch {1} ball rolling, rolling, rolling...\n", this.Diameter, this.Color);
        }
        public void Bounce()
        {
            Console.WriteLine("\t{0} inch {1} ball going up, coming down, going up, coming down.\n", this.Diameter, this.Color);
        }
    }
}
