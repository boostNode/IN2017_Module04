/*
 *  Author: Troy Davis
 *  Project: YouDoIt_ArrayOfObjects - Console (Chapter 9, You Do It, p403-405)
 *  Class: IN 2017 (Advanced C#)
 *  Date: Feb 9, 2017 
 *  Revision: Original
 */

using System;

namespace YouDoIt_ArrayOfObjects
{
    class Driver
    {
        static void Main(string[] args)
        {
            // initialize console
            Console.WriteLine("You Do It - Array of Objects\n");

            Student[] students = new Student[3];
            int x;
            int id;
            string name;
            double gpa;

            // get student data
            for( x = 0 ; x < students.Length ; x++ )
            {
                GetData(out id, out name, out gpa);
                students[x] = new Student(id, name, gpa);
            }

            // sort and diplay student data
            Array.Sort(students);
            Console.WriteLine("\nSorted Student List:");
            for( x = 0 ; x < students.Length ; x++ )
            {
                Student.Display(students[x]);
            }


            // wait on user to close console
            Console.Write("\nPress 'Enter' to exit: "); Console.ReadLine();
        }
        public static void GetData(out int id, out string name, out double gpa)
        {
            string inString;
            Console.WriteLine("\n\tPlease enter student information below:");
            Console.Write("\t\tid number: "); inString = Console.ReadLine(); int.TryParse(inString, out id);
            Console.Write("\t\tlast name: "); inString = Console.ReadLine(); name = inString;
            Console.Write("\t\tgrade point average: "); inString = Console.ReadLine(); double.TryParse(inString, out gpa);
        }
    }
    class Student : IComparable
    {
        private int idNumber;
        private string lastName;
        private double gradePointAverage;

        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        // constructors
        public Student()
        {

        }
        public Student(int id, string last_name, double gpa)
        {
            this.idNumber = id;
            this.lastName = last_name;
            this.GradePointAverage = gpa;
        }

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

        int IComparable.CompareTo(object o)
        {
            int returnVal;

            Student temp = (Student)o;

            if (this.IdNumber > temp.IdNumber)
            {
                returnVal = 1;
            }
            else
            {
                if (this.IdNumber < temp.IdNumber)
                    returnVal = -1;
                else
                    returnVal = 0;
            }
                
            return returnVal;
        }
    }
}
