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
    public partial class AdminPart : UserControl
    {
        public AdminPart()
        {
            InitializeComponent();
        }

        #region Properties

        private string _gname;
        private Image _profile;
        private string _bname;

        public string GName
        {
            get { return _gname; }
            set { _gname = value; GroupName.Text = value; }
        }

        public Image Profile
        {
            get { return _profile; }
            set { _profile = value; pictureBox1.Image = value; }
        }

        public string BName
        {
            get { return _bname; }
            set { _bname = value; ButtonName.Text = value; }
        }




        #endregion


        AdminForm adminForm = new AdminForm();
        public int MyId { get; set; }

        private void ButtonName_Click(object sender, EventArgs e)
        {
            if (ButtonName.Text == "Add")
            {
                adminForm._studentDal.Add(new Student
                {
                    Name = NameTxt.Text,
                    Surname = SurnameTxt.Text,
                    Mail = MailTxt.Text,
                    Class = ClassTxt.Text
                });
                //Thread.Sleep(1000);
                adminForm.LoadStudents();
                MessageBox.Show("Added");
            }
            else if(ButtonName.Text == "Update")
            {
                //adminForm._studentDal.Update()
                Student student = new Student()
                {
                    //Id=Convert.ToInt32(form.GetTable().CurrentRow.Cells[0].Value)
                    // Id = Convert.ToInt32(form.GetTable().CurrentRow.Cells[0].Value),
                    //Id = Convert.ToInt32(form.GetTable().CurrentRow.Cells[0].Value),
                    Id = MyId,
                    Name = NameTxt.Text,
                    Surname = SurnameTxt.Text,
                    Mail = MailTxt.Text,
                    Class = ClassTxt.Text
                };
                Thread.Sleep(500);
                adminForm._studentDal.Update(student);
                MessageBox.Show("Updated!");
            }
        }







        public void ChangeName(string s)
        {
            NameTxt.Text = s;
        }

        public void ChangeSurname(string s)
        {
            SurnameTxt.Text = s;
        }

        public void ChangeMail(string s)
        {
            MailTxt.Text = s;
        }

        public void ChangeClass(string s)
        {
            ClassTxt.Text = s;
        }


    }
}
