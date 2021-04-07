using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinifForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "admin" && PasswordTxt.Text == "admin12")
            {
               // this.Hide();
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            UsernameTxt.Text = "";
            PasswordTxt.Text = "";
            UsernameTxt.Focus();
        }

        private void ShowCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowCheck.Checked)
                PasswordTxt.PasswordChar = '\0';
            else
                PasswordTxt.PasswordChar = '•';
        }

        private void EndBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
