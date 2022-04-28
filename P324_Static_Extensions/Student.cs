using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Static_Extensions
{
    class Student
    {
        public int Id;
        public  string Name;
        public string Surname;
        public byte Point;
        public static int count;
        public int[] Points;

        public Student(string name, string surname,byte point)
        {
            Id = ++count;
            Name = name;
            Surname = surname;
            Point = point;
        }

        static Student()
        {
            count = 0;
        }

        public static void getName()
        {
            Console.WriteLine("Static method" + count);
        }

        public void getCount()
        {
            Console.WriteLine(count);
        }

        public void Enum(Weekdays day)
        {
            switch (day)
            {
                case Weekdays.Monday:
                    Console.WriteLine("1ci");
                    break;
                case Weekdays.Tuesday:
                    Console.WriteLine("2ci");
                    break;
                case Weekdays.Wednesday:
                    break;
                case Weekdays.Thursday:
                    break;
                case Weekdays.Friday:
                    break;
                case Weekdays.Saturday:
                    break;
                case Weekdays.Sunday:
                    break;
                default:
                    break;
            }
        }
    }
}
