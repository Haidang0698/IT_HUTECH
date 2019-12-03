using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Apartment:General
    {
        public int Floor { get; set; }
        public Apartment()
        {

        }
        public Apartment(string address, double cost, double acreage, int floor):base(address, cost, acreage)
        {
            Floor = floor;
        }
        public void Input()
        {
            base.Input();
            Console.Write("Floor: ");
            Floor = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("\t\t|\tFloor: " + this.Floor);
        }
    }
}
