using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Assignment_4._2
{
    public partial class TeacherForm : Form
    {
        private List<Student> students;

        public TeacherForm()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        //add student
        private void AddStudent_Click(object sender, EventArgs e)
        {
            string studentId = txtStudentId.Text;
            string studentName = txtStudentName.Text;
            double gpa;

            if (double.TryParse(txtGPA.Text, out gpa))
            {
                Student newStudent = new Student(studentId, studentName, gpa);
                students.Add(newStudent);
                lstStudents.Items.Add(newStudent);
                ClearInputFields();
            }
            else
            {
                MessageBox.Show("Please enter a valid GPA.");
            }
        }

        //delete student
        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedItem != null)
            {
                Student selectedStudent = (Student)lstStudents.SelectedItem;
                students.Remove(selectedStudent);
                lstStudents.Items.Remove(selectedStudent);
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void GPA_Click(object sender, EventArgs e)
        {
            if (students.Count > 0)
            {
                //var topStudent = students.OrderByDescending(s => s.GPA).First();

                //student GPA stuff


            }
            else
            {
                MessageBox.Show("No students available.");
            }
        }
        //txtbox names not lining up?
        private void ClearFields()
        {
            txtStudentId.Clear();
            txtStudentName.Clear();
            txtGPA.Clear();
        }
    }

}
