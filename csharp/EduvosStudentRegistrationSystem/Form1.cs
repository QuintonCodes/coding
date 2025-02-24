using System;
using System.Windows.Forms;

namespace EduvosStudentRegistrationSystem
{
    public partial class HomePage : Form
    {
        public HomePage() => InitializeComponent();

        private void AddStudents_button_Click(object sender, EventArgs e)
        {
            AddStudents addStudentspage = new AddStudents();
            addStudentspage.Show();
            this.Hide();
        }

        private void ShowStudents_button_Click(object sender, EventArgs e)
        {
            ShowStudents showStudentspage = new ShowStudents();
            showStudentspage.Show();
            this.Hide();
        }

        private void Exit_button_Click(object sender, EventArgs e) => Application.Exit();
    }
}
