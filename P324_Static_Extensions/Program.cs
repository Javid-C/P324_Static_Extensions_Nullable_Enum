using System;

namespace P324_Static_Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Static
            ////Student.count = 1000;
            //Student student = new Student("Shakhrom", "Racabov",30);
            //Student student1 = new Student("Shakhrom1", "Racabov1",40);
            //Student student2 = new Student("Shakhrom1", "Racabov1",50);
            //Student student3 = new Student("Shakhrom1", "Racabov1",80);
            //Console.WriteLine(student.Id);
            //Console.WriteLine(student1.Id);
            //Console.WriteLine(student2.Id);
            ////Console.WriteLine(student3.Name);
            ////Console.WriteLine("Studentlerin sayi: " + Student.count);
            //Student.getName();

            //string name = "xaLIl xalilBeyli";

            //bool result = name.Contains("a");
            //Console.WriteLine(result);

            //int number = 5;

            //student.Id.Add(10, 20);

            //Console.WriteLine(name.toCapitalized());

            //student3.checkPoint();

            //Console.WriteLine(name.Contains("LIL x"));


            //string example = "This is example text";

            //example.customContains("exaMple te");
            #endregion

            #region Nullable
            ////string str = null;

            ////int number = null;

            //Nullable<int> number = null;

            //int? num = null;

            //if(num == null)
            //{
            //    Console.WriteLine("Bu deyer nulldir");
            //}

            ////string str;

            //Student student = new Student("Shakhrom", "Racabov", 30);

            ////student.Points[0] = 18;
            ////student.Points = new int[5];

            //Console.WriteLine(student.Points?.Length);
            #endregion

            //string[] weekdays = { "Monday", "Tuesday" };

            //Console.WriteLine((int)Weekdays.Monday);

            //foreach (var day in Enum.GetNames(typeof(Weekdays)))
            //{
            //    Console.WriteLine(day);
            //}

            //foreach (var day in Enum.GetValues(typeof(Weekdays)))
            //{
            //    Console.WriteLine($"{(int)day}. {day}");
            //}

            object day;

            bool result = Enum.TryParse(typeof(Weekdays), Console.ReadLine(), out day);


            Student student = new Student("Ismayil","Hasanov",10);
            Console.WriteLine((int)day);


            student.Enum((Weekdays)day);
            ////Console.WriteLine(typeof(Weekdays));

        }
    }
}
