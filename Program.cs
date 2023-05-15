using System;

namespace Test
{

    public abstract class Student_data
    {
        string _name;
        int _age;
        string _section;


        public Student_data(string name, int age, string section)
        {
            _name = name;
            _age = age;
            _section = section;
        }

        public virtual void printNameSection()
        {
            Console.WriteLine("Name: " + _name + " in Section: " + _section);
        }

        public virtual void increaseage(int inc)
        {
            _age += inc;
            Console.WriteLine("Increased age is: " + _age);
        }
    }

    public class sectionX : Student_data
    {
        public sectionX(string _name, int _age, string _section) : base(_name,_age,_section)
        {
            
        }

        public override void printNameSection()
        {
            base.printNameSection();
        }

        public override void increaseage(int inc)
        {
            base.increaseage(inc);
        }
    }

    public class sectionY: Student_data
    {
        string blood_group;
        public sectionY(string _name,int _age,string _section,string _blood_group) : base(_name,_age,_section)
        {
            blood_group = _blood_group;
        }

        public override void printNameSection()
        {
            base.printNameSection();
        }

        public override void increaseage(int inc)
        {
            base.increaseage(inc);
        }

        public void bloodgroupstudent()
        {
            Console.WriteLine("The blood group is: " + blood_group);
        }
    }
}