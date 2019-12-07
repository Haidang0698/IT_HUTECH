using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class ChungCu:QLThongTin
    {
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                floor = value;
            }
        }

        public ChungCu():base()
        {
        }

        public ChungCu(int floor, string address, long price, float acreage) :base(address,price,acreage)
        {
            Floor = floor;
            Address = address;
            Price = price;
            Acreage = acreage;
        }
        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Floor : ");
            } while (!int.TryParse(Console.ReadLine(), out floor));
            Console.WriteLine();

        }
        public override void Show()
        {
            base.Show();
            Console.Write("Tang : {0}\n", this.Floor);
        }
       
    }
}
