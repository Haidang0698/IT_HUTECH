using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class TownHouse:General
    {
        public int YearBuild { get; set; }
        public int NumFloor { get; set; }
        public TownHouse():base()
        {

        }
        public TownHouse(string address, double cost, double acreage, int yearBuild, int numFloor):base(address, cost, acreage)
        {
            YearBuild = yearBuild;
            NumFloor = numFloor;
        }

        public void Input()
        {
            base.Input();
            Console.Write("Year Build: ");
            YearBuild = int.Parse(Console.ReadLine());
            Console.Write("Number Floor: ");
            NumFloor = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine("\t\t|\tYear Build: " + this.YearBuild + "\t\t|\tNumber Floor: " + this.NumFloor);
        }
    }
}
