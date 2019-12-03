using System;
using System.Collections.Generic;
using System.Text;

namespace Lab01_03
{
    class KhuDat : QLThongTin
    {
        public KhuDat() : base()
        {

        }
        public KhuDat(string address, long price, float acreage) : base(address,price,acreage)
        {
            Address = address;
            Price = price;
            Acreage = acreage;
        }
        public override void Input()
        {
            base.Input();
        }
        public override void Show()
        {
            base.Show();
        }
        public override float DonGia()
        {
            return (float)Price / Acreage;
        }
    }
}
