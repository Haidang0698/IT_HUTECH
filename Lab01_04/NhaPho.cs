using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class NhaPho : QLThongTin
    {
        private DateTime yearBuilt;
        private int numberFloor;
        public DateTime YearBuilt
        {
            get
            {
                return yearBuilt;
            }
            set
            {
                yearBuilt = value;
            }
        }
        public int NumberFloor
        {
            get
            {
                return numberFloor;
            }
            set
            {
                numberFloor = value;
            }
        }


        public NhaPho() : base()
        {
        }

        public NhaPho(DateTime yearBuilt, int numberFloor, string address, long price, float acreage) : base(address, price, acreage)
        {
            YearBuilt = yearBuilt;
            NumberFloor = numberFloor;
            Address = address;
            Price = price;
            Acreage = acreage;
        }
        public override void Input()
        {
            base.Input();
            do
            {
                Console.Write("Thoi Gian XD : ");
            } while (!DateTime.TryParse(Console.ReadLine(), out yearBuilt));
            do
            {
                Console.Write("So Tang : ");
            } while (!int.TryParse(Console.ReadLine(), out numberFloor));

            Console.WriteLine();

        }
        public override void Show()
        {
            base.Show();
            Console.Write("Thoi Gian XD: {0}\tSo Tang : {1}\n", this.YearBuilt, this.NumberFloor);
           
        }
    }
}