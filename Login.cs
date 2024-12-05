using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4._2
{

    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        //lost track

        private void Login_Click(object sender, EventArgs e)
        {
            string userId = txtUserId.Text;
            string password = txtPassword.Text;

            if (userId == "Teacher" && password == "Admin")
            {
                
                TeacherForm teacherForm = new TeacherForm();
                teacherForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials. Please try again.");
            
            }
        }
    }

}
