using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student:Person
    {
        public float Mark { get; set; }
        public string Faculty { get; set; }
        public Student()
        {

        }
        public Student(string iD, string name, float mark, string faculty):base(iD, name)
        {
            Mark = mark;
            Faculty = faculty;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Mark: ");
            Mark = float.Parse(Console.ReadLine());
            Console.Write("Faculty: ");
            Faculty = Console.ReadLine();
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("\t\t|\tMark: " + this.Mark + "\t\t|\tFaculty: " +  this.Faculty);
        }
    }
}