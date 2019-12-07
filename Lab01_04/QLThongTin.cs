using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_04
{
    class QLThongTin
    {
        public QLThongTin(string address, long price, float acreage)
        {
            Address = address;
            Price = price;
            Acreage = acreage;
        }

        public QLThongTin()
        {
        }

        protected string address;
        protected long price;
        protected float acreage;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }

        }
        public long Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }
        public float Acreage
        {
            get
            {
                return acreage;
            }
            set
            {
                acreage = value;
            }

        }

        public virtual void Input()
        {
            Console.Write("Dia Diem : ");
            this.Address = Console.ReadLine();
            do
            {
                Console.Write("Gia Ban : ");
            } while (!long.TryParse(Console.ReadLine(), out price));
            do
            {
                Console.Write("Dien Tich : ");
            } while (!float.TryParse(Console.ReadLine(), out acreage));
           
        }
        public virtual void Show()
        {
            Console.Write("Dia Diem : {0}\t\t\t\tGia Ban : {1}VND\t\t\t\tDien Tich : {2}m2\t\t\t\t", this.Address, this.Price, this.Acreage);
        }
    }
}

