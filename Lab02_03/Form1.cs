using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //EVENT FOR ACCOUNT FROM INPUT
        private Account GetAccount()
        {
            Account acc = new Account();
            acc.AccountNo = txtAccID.Text;
            acc.AccountName = txtAccName.Text;
            acc.AccountAddress = txtAccAddress.Text;
            acc.Balance = double.Parse(txtAccMoney.Text);
            return acc;
        }
        //List<Account> FROM LISTVIEW
        private List<Account> GetListAccount()
        {
            List<Account> accountList = new List<Account>();
            for (int i = 0; i < lstAccount.Items.Count; i++)
            {
                Account acc = new Account();
                acc.AccountNo = lstAccount.Items[i].SubItems[1].Text; //index 0 là STT
                acc.AccountName = lstAccount.Items[i].SubItems[2].Text;
                acc.AccountAddress = lstAccount.Items[i].SubItems[3].Text;
                acc.Balance = double.Parse(lstAccount.Items[i].SubItems[4].Text);
                accountList.Add(acc);
            }
            return accountList;
        }
        //EVENT FOR BUTTON ADD/UPDATE
        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccID.Text == "" || txtAccName.Text == "" || txtAccAddress.Text == "" || txtAccMoney.Text == "")
                {
                    throw new Exception("Please Enter Full Information!!!");
                    List<Account> listAccount = GetListAccount();
                    Account findAccount = listAccount.FirstOrDefault(p => p.AccountNo == txtAccID.Text);
                    if (findAccount == null) //Trường hợp add dữ liệu
                    {
                        findAccount = GetAccount(); //Lấy giá trị từ form
                        string[] items = new string[]
                        {
                            (listAccount.Count + 1).ToString(),
                                    findAccount.AccountNo, findAccount.AccountName, findAccount.AccountAddress, findAccount.Balance.ToString()
                        };
                        ListView newRow = new ListView();
                        lstAccount.Controls.Add(newRow);
                    }
                    else //Trường hợp update dữ liệu
                    {
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //EVENT FOR BUTTON DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        //EVENT FOR BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
