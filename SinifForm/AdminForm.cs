using SinifForm.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinifForm
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        public StudentDal _studentDal = new StudentDal();
        AdminPart[] parts = new AdminPart[2];
        public List<Operation> operations = new List<Operation>();

        private void AdminForm_Load(object sender, EventArgs e)
        {
            dgw_Students.DataSource = _studentDal.GetStudents();
        }


        public void CreatList()
        {
            operations.Add(new Operation
            {
                Gname = "Add a Student",
                Profil = Resources.addenergy,
                BName = "Add"
            });

            operations.Add(new Operation
            {
                Gname = "Update a Student",
                Profil = Resources.updateee,
                BName = "Update"
            });
        }


        public void Populate(int i)
        {
            CreatList();
            parts[i] = new AdminPart();
            parts[i].GName = operations[i].Gname;
            parts[i].Profile = operations[i].Profil;
            parts[i].BName = operations[i].BName;
            flowLayoutPanel1.Controls.Add(parts[i]);
        }



        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearPanelBtn.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            Populate(0);
        }

        public void LoadStudents()
        {
            dgw_Students.DataSource = _studentDal.GetStudents();
        }

        private void ClearPanelBtn_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ClearPanelBtn.Visible = false;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ClearPanelBtn.Visible = true;
            flowLayoutPanel1.Controls.Clear();
            Populate(1);
        }

        private void dgw_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (flowLayoutPanel1.Controls.Count > 0)
            {
                int id = Convert.ToInt32(dgw_Students.CurrentRow.Cells[0].Value);
                parts[1].MyId = id;
                string name = dgw_Students.CurrentRow.Cells[1].Value.ToString();
                parts[1].ChangeName(name);
                string surname = dgw_Students.CurrentRow.Cells[2].Value.ToString();
                parts[1].ChangeSurname(surname);
                string mail = dgw_Students.CurrentRow.Cells[3].Value.ToString();
                parts[1].ChangeMail(mail);
                string sinif = dgw_Students.CurrentRow.Cells[4].Value.ToString();
                parts[1].ChangeClass(sinif);
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            _studentDal.Delete(new Student
            {
                Id = Convert.ToInt32(dgw_Students.CurrentRow.Cells[0].Value)
            });
            LoadStudents();
            MessageBox.Show("Deleted");
        }

        private void SearchTxt_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchTxt.Text != string.Empty)
                dgw_Students.DataSource = _studentDal.GetStudentByName(SearchTxt.Text);
            else
                dgw_Students.DataSource = _studentDal.GetStudents();
        }
    }
}
