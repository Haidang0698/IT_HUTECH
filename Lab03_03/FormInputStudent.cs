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
    public partial class FormInputStudent : Form
    {
        Form1 data;
        public FormInputStudent(Form1 dt)
        {
            InitializeComponent();
            this.data = dt;
        }
        //FORM INPUT STUDENT LOAD DATA
        private void FormInputStudent_Load(object sender, EventArgs e)
        {
            ConnectSQL_L0303 context = new ConnectSQL_L0303();
            List<Faculty> listFaculty = context.Faculties.ToList();
            FillFacultyCombobox(listFaculty);
        }
        //GET FACULTY LIST
        private void FillFacultyCombobox(List<Faculty> listFaculty)
        {
            this.cbFaculty.DataSource = listFaculty;
            this.cbFaculty.DisplayMember = "FacultyName";
            this.cbFaculty.ValueMember = "FacultyID";
        }
        //GET STUDENT FROM INPUT A STUDENT
        private Student GetStudent()
        {
            Student st = new Student();
            st.StudentID = txtStudentID.Text;
            st.StudentName = txtStudentName.Text;
            st.Faculty.FacultyName = cbFaculty.Text;
            st.AverageScore = double.Parse(txtAverageScore.Text.ToString());
            return st;
        }
        //GET LIST STUDENT FROMT LIST<STUDENT>
        private List<Student> GetListStudent()
        {
            List<Student> list = new List<Student>();
            for (int i = 0; i < data.dgvStudent.Rows.Count; i++)
            {
                Student st = new Student();
                st.StudentID = data.dgvStudent.Rows[i].Cells[0].Value.ToString();
                st.StudentName = data.dgvStudent.Rows[i].Cells[1].Value.ToString();
                if (st.Faculty != null)
                    data.dgvStudent.Rows[i].Cells[2].Value = st.Faculty.FacultyName;
                st.AverageScore = double.Parse(data.dgvStudent.Rows[i].Cells[3].Value.ToString());
            }
            return list;
        }
        //EVENT FOR BUTTON ADD NEW STUDENT
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStudentID.Text == "" || txtStudentName.Text == "" || txtAverageScore.Text == "")
                    throw new Exception("Please Enter Full Information!!!");
                List<Student> listStudent = GetListStudent();
                Student findStudent = listStudent.FirstOrDefault(p => p.StudentID == txtStudentID.Text);
                if (findStudent != null)
                {
                    findStudent = GetStudent();
                    data.dgvStudent.Rows.Add();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notification");
            }
        }
        //EVENT FOR BUTTON EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You may want to exit ?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        
    }
}
