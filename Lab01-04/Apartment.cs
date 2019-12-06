using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Apartment:General
    {
        //PROPERTIES
        public int Floor { get; set; }
        //CONSTRUCTOR WITHOUT PARAMETERS
        public Apartment()
        {

        }
        //CONSTRUCTOR WITH PARAMETERS
        public Apartment(string address, double cost, double acreage, int floor):base(address, cost, acreage)
        {
            Floor = floor;
        }
        //INPUT
        public void Input()
        {
            base.Input();
            Console.Write("Floor: ");
            Floor = int.Parse(Console.ReadLine());
        }
        //SHOW
        public void Show()
        {
            base.Show();
            Console.WriteLine("\t|\tFloor: " + this.Floor);
        }
    }
}
