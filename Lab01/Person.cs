using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    abstract class Person
    {
        protected string ID { get; set; }
        public string Name { get; set; }
        protected Person()
        {

        }
        protected Person(string iD, string name)
        {
            ID = iD;
            Name = name;
        }
        protected void Input()
        {
            Console.Write("ID: ");
            ID = Console.ReadLine();
            Console.Write("Name: ");
            Name = Console.ReadLine();
        }
        public void Show()
        {
            Console.Write("ID: " + this.ID + "\t|\tName: " + this.Name);
        }
    }
}
