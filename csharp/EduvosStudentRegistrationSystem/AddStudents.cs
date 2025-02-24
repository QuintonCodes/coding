using System;
using System.IO;
using System.Windows.Forms;

namespace EduvosStudentRegistrationSystem
{
    public partial class AddStudents : Form
    {
        public AddStudents() => InitializeComponent();
        
        private void Save_button_Click(object sender, EventArgs e)
        {
            string dateFormat = "MM/dd/yyyy";

			bool isDobValid = DateTime.TryParseExact(dob_textBox.Text, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime dob);
			bool isJoinDateValid = DateTime.TryParseExact(joinDate_textBox.Text, dateFormat, null, System.Globalization.DateTimeStyles.None, out DateTime joinDate);

            if (!isDobValid || !isJoinDateValid) 
            {
                MessageBox.Show("Please use Format MM/dd/yyyy");
                return;
            }

            string studentDetails = $"{name_textBox.Text}, {lastName_textBox.Text}, {sponser_textBox.Text}, {dob.ToString("yyyy-MM-dd")}, {joinDate.ToString("yyyy-MM-dd")}, {nationality_textBox.Text}\n";

            try
            {
                File.AppendAllText("ListOfStudents.txt", studentDetails);
                MessageBox.Show("Student registered successfully");

                foreach (Control control in this.Controls)
                    if (control is TextBox box)
                        box.Clear();                   
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
