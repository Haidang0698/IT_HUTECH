using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_04
{
    abstract class General
    {
        protected string Address { get; set; }
        public double Cost { get; set; }
        public double Acreage { get; set; }
        protected General()
        {

        }
        protected General(string address, double cost, double acreage)
        {
            Address = address;
            Cost = cost;
            Acreage = acreage;
        }
        protected void Input()
        {
            Console.Write("Address: ");
            Address = Console.ReadLine();
            Console.Write("Cost: ");
            Cost = double.Parse(Console.ReadLine());
            Console.Write("Acreage: ");
            Acreage = double.Parse(Console.ReadLine());
        }
        protected void Show()
        {
            Console.Write("\tAddress: " + this.Address + "\t\t|\tCost: " + this.Cost + " VNĐ\t\t|\tAcreage: " + this.Acreage + " m2");
        }
    }
}
