﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_03
{
    class Account
    {
        //PROPERTIES
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string AccountAddress { get; set; }
        public double Balance { get; set; }
        //CONSTRUTOR
        public Account()
        {

        }
        public Account(string accountNo, string accountName, string accountAddress, double balance)
        {
            AccountNo = accountNo;
            AccountName = accountName;
            AccountAddress = accountAddress;
            Balance = balance;
        }
    }
}
