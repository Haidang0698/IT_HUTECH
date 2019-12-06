using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    class Area:General
    {
        //CONSTRUCTOR WITHOUT PARAMETERS
        public Area():base()
        {

        }
        //CONSTRUCTOR WITH PARAMETERS
        public Area(string address, double cost, double acreage):base(address, cost, acreage)
        {
            
        }
        //INPUT
        public void Input()
        {
            base.Input();
        }
        //SHOW
        public void Show()
        {
            base.Show();
            Console.WriteLine();
        }
    }
}
