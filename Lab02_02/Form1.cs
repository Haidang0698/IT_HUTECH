using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnChooseASeat(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.BackColor == Color.White)
            {
                btn.BackColor = Color.Blue;
            }
            else if (btn.BackColor == Color.Blue)
            {
                btn.BackColor = Color.White;
            }
            else if (btn.BackColor == Color.Yellow)
            {
                MessageBox.Show("Seat was sold!!!", "Notification");
            }
        }
        private void btnChoose_Click(object sender, EventArgs e)
        {
            int cost = 0;
            foreach (Control ct in this.GroupBox.Controls)
            {
                if (ct.BackColor == Color.Blue)
                {
                    ct.BackColor = Color.Yellow;
                    if (int.Parse(ct.Text) < 6)
                        cost += 5000;
                    else if (int.Parse(ct.Text) < 11)
                        cost += 6500;
                    else
                        cost += 8000;
                }
            }
            txtCost.Text = cost.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            foreach (Control ct in this.GroupBox.Controls)
            {
                if (ct.BackColor == Color.Blue)
                    ct.BackColor = Color.White;
            }
            txtCost.Text = "0";
        }
        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Program?", "Nofication", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
    }
}
