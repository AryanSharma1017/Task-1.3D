using System;

namespace task1_3D
{
    class Student_Data // Base class
    {
        public virtual void name_student()
        {
            Console.WriteLine("The name of student is: XYZ");
        }
    }

    class Student_Data2: Student_Data
    {
        public override void name_student()
        {
            Console.WriteLine("The name of student is: ABC");
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            Student_Data a = new Student_Data();
            Student_Data b = new Student_Data2();
            Student_Data2 c = new Student_Data2();
            Student_Data d = c;  // Upcasting 

            a.name_student();
            b.name_student();
            d.name_student();
        }
    }
}