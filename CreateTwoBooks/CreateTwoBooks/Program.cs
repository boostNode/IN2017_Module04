/*
 *  Author: Troy Davis
 *  Project: Book and Driver Class - Console (Chapter 9, Figures 9-18 - 9-20, p378-9)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 9, 2017 
 *  Revision: Original
 */

using System;

namespace CreateTwoBooks
{
    class Driver
    {
        static void Main(string[] args)
        {
            // initialize console
            Console.WriteLine("Book and Driver Class\n");

            Book myBook = new Book();
            Book yourBook = new Book();

            myBook.Title = "Silas Marner";
            yourBook.Title = "The Time Traveler's Wife";

            myBook.AdvertisingMessage();
            yourBook.AdvertisingMessage();

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }
    class Book
    {
        private string title;
        private int numPages;
        private double price;
        
        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }

        public void AdvertisingMessage()
        {
            Console.WriteLine("Buy it now: {0}", this.Title);
        }
    }
}
