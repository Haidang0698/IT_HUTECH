using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class TownHouse:General
    {
        //PROPERTIES
        public int YearBuild { get; set; }
        public int NumFloor { get; set; }
        //CONSTRUCTOR WITHOUT PARAMETERS
        public TownHouse():base()
        {

        }
        //CONSTRUCTOR WITH PARAMETERS
        public TownHouse(string address, double cost, double acreage, int yearBuild, int numFloor):base(address, cost, acreage)
        {
            YearBuild = yearBuild;
            NumFloor = numFloor;
        }
        //INPUT
        public void Input()
        {
            base.Input();
            Console.Write("Year Build: ");
            YearBuild = int.Parse(Console.ReadLine());
            Console.Write("Number Floor: ");
            NumFloor = int.Parse(Console.ReadLine());
        }
        //SHOW
        public void Show()
        {
            base.Show();
            Console.WriteLine("\t|\tYear Build: " + this.YearBuild + "\t|\tNumber Floor: " + this.NumFloor);
        }
    }
}
