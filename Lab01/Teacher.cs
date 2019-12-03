using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher:Person
    {
        public string Address { get; set; }
        public Teacher()
        {

        }
        public Teacher(string iD, string name, string address):base(iD, name)
        {
            Address = address;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Address: ");
            Address = Console.ReadLine();
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("\t\t|\tAddress: " + this.Address);
        }
    }
}
