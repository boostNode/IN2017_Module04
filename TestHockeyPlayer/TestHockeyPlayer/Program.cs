/*
*  Author: Troy Davis
*  Project: TestHockeyPlayer - Console (Chapter 9, Programming Exercise #1, pg417)
*  Class: IN 2017 (Advanced C#)
*  Date: Feb 13, 2017 
*  Revision: Original
*/

using System;

namespace TestHockeyPlayer
{
    class Driver
    {
        static void Main(string[] args)
        {
            // initialize console
            Console.WriteLine("Chapter 9, Programming Exercise #1 - Test Hockey Player\n");

            // instantiate and display HockeyPlayer object
            HockeyPlayer wg = new HockeyPlayer("Wayne Gretzky", 99, 894);
            wg.Display();

            // wait on user to close console
            Console.Write("Press 'Enter' to exit: "); Console.ReadLine();
        }
    }
    class HockeyPlayer
    {
        // constructor
        public HockeyPlayer(string name, int number, int goals_scored)
        {
            this.PlayerName = name;
            this.PlayerNumber = number;
            this.PlayerGoalsScored = goals_scored;
        }

        // setters/getters
        public string PlayerName { get; set; }
        public int PlayerNumber { get; set; }
        public int PlayerGoalsScored { get; set; }

        // methods
        public void Display()
        {
            Console.WriteLine("\tPlayer Name: {0}\n\tJersey Number: {1}\n\tGoals Scored: {2}\n", this.PlayerName, this.PlayerNumber.ToString(), this.PlayerGoalsScored.ToString());
        }
    }
}