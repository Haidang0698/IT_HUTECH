using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //LOAD FORM 1
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtStudentID.Text = dgvStudent.Rows[row].Cells[0].Value.ToString();
            txtName.Text = dgvStudent.Rows[row].Cells[1].Value.ToString();
            cbFrameSelectList.Text = dgvStudent.Rows[row].Cells[2].Value.ToString();
            if (checkBoxMale.Checked = true)
            {
                checkBoxMale.Text = dgvStudent.Rows[row].Cells[3].Value.ToString();
            }
            else if (checkBoxFemale.Checked = true)
            {
                checkBoxFemale.Text = dgvStudent.Rows[row].Cells[3].Value.ToString();
            }
            int s = lbListSelect.Items.Count;
            s = int.Parse(dgvStudent.Rows[row].Cells[4].Value.ToString());
        }
        //EVENT FOR BUTTON SELECT EACH FILE
        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            lbListSelect.Items.Add(lbList.SelectedItem.ToString());
            lbList.Items.Remove(lbListSelect.SelectedItem.ToString());
        }
        //EVENT FOR BUTTON DISCARD EACH FILE
        private void btnDiscardFile_Click(object sender, EventArgs e)
        {
            lbList.Items.Add(lbListSelect.SelectedItem.ToString());
            lbListSelect.Items.Remove(lbList.SelectedItem.ToString());
        }
        private void cbFrameSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFrameSelectList.Text == "Software Technology")
            {
                lbList.Items.Add("Software Testing");
                lbList.Items.Add("Java Programming");
                lbList.Items.Add("Database");
            }
            else if (cbFrameSelectList.Text == "Safety Information")
            {
                lbList.Items.Add("Hide Information");
                lbList.Items.Add("Encryption Information");
                lbList.Items.Add("Database");
            }
            else if (cbFrameSelectList.Text == "Information System")
            {
                lbList.Items.Add("Anvanced Database");
                lbList.Items.Add("Information System Design Analysis");
                lbList.Items.Add("Database");
            }
        }
        //EVENT FOR BUTTON SAVE
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        //EVENT FOR BUTTON DELETE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}
