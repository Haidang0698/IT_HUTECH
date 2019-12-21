using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //EVENT FOR BUTTON ADD NEW
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            FormInputStudent form2 = new FormInputStudent(this);
            if (form2.ShowDialog() != DialogResult.Cancel)
            {
                form2.Show();
            }
        }

        
    }
}
