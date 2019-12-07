﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    abstract class QLThongTin
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
            Console.Write("Address : ");
            this.Address = Console.ReadLine();
            do
            {
                Console.Write("Price : ");
            }while(!long.TryParse(Console.ReadLine(),out price));
            do
            {
                Console.Write("Acreage : ");
            } while (!float.TryParse(Console.ReadLine(), out acreage));
            Console.WriteLine();
        }
        public virtual void Show()
        {
            Console.WriteLine("{0}\t\t\t\t{1}VND\t\t\t\t{2}m2\n",this.Address,this.Price,this.Acreage);
        }

        public abstract float DonGia();
    }
}
