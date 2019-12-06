using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    abstract class General
    {
        //PROPERTIES
        public string Address { get; set; }
        public double Cost { get; set; }
        public double Acreage { get; set; }
        //CONSTRUCTOR WITHOUT PARAMETERS
        protected General()
        {

        }
        //CONSTRUCTOR WITH PARAMETERS
        protected General(string address, double cost, double acreage)
        {
            Address = address;
            Cost = cost;
            Acreage = acreage;
        }
        //INPUT
        protected void Input()
        {
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Cost: ");
            Cost = double.Parse(Console.ReadLine());
            Console.Write("Acreage: ");
            Acreage = double.Parse(Console.ReadLine());
        }
        //SHOW
        protected void Show()
        {
            Console.Write("Address: " + this.Address + "\t|\tCost: " + this.Cost + " VNĐ\t|\tAcreage: " + this.Acreage + " m2");
        }
    }
}
