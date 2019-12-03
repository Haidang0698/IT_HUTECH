using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_03
{
    class Area:General
    {
        public Area() : base()
        {

        }
        public Area(string address, double cost, double acreage) : base(address, cost, acreage)
        {

        }
        public void Input()
        {
            base.Input();
        }
        public void Show()
        {
            base.Show();
            Console.WriteLine();
        }
    }
}