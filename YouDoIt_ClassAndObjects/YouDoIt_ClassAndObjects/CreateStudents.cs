/*
 *  Author: Troy Davis
 *  Project: YouDoIt_ClassAndObjects - Console (Chapter 9, You Do It, p370-373)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 9, 2017 
 *  Revision: Original
 */

using System;

namespace YouDoIt_ClassAndObjects
{
    class CreateStudents
    {
        static void Main(string[] args)
        {
            // initialize console
            Console.WriteLine("You Do It - Class and Objects\n");

            Student first = new Student();
            Student second = new Student();

            first.IdNumber = 123;
            first.LastName = "Anderson";
            first.GradePointAverage = 3.5;
            second.IdNumber = 789;
            second.LastName = "Daniels";
            second.GradePointAverage = 4.1;

            Student.Display(first);
            Student.Display(second);

            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
    }
    class Student
    {
        private int idNumber;
        private string lastName;
        private double gradePointAverage;

        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        public int IdNumber
        {
            get
            {
                return idNumber;
            }
            set
            {
                idNumber = value;
            }
        }
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
        public double GradePointAverage
        {
            get
            {
                return gradePointAverage;
            }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }
        public static void Display(Student stu)
        {
            Console.WriteLine("{0, 5} {1, -10}{2, 6}", stu.idNumber, stu.lastName, stu.GradePointAverage.ToString("F1"));
        }
    }
}
