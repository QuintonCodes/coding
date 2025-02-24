using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EduvosStudentRegistrationSystem
{
    public partial class ShowStudents : Form
    {
        private readonly List<string[]> studentRecords = new List<string[]>();
        private int currentIndex = 0;

        public ShowStudents()
        {
            InitializeComponent();
            LoadStudentRecords();
            DisplayStudentRecord(0);
        }

        private void LoadStudentRecords()
        {
            string[] lines = File.ReadAllLines("ListOfStudents.txt");
            foreach (string line in lines)
            {
                string[] details = line.Split(',');
                studentRecords.Add(details);
            }
        }

        private void DisplayStudentRecord(int index)
        {
            if (index >=0 && index < studentRecords.Count)
            {
                var record = studentRecords[index];

                name_textBox.Text = record[0];
                lastName_textBox.Text = record[1];
                sponser_textBox.Text = record[2];
                dob_textBox.Text = record[3];
                joinDate_textBox.Text = record[4];
                nationality_textBox.Text = record[5];

                indicator.Text = $"{index + 1}/{studentRecords.Count}";
            } else
            {
                ClearTextboxes();
                indicator.Text = "0/0";
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (studentRecords.Count > 0 && currentIndex < studentRecords.Count)
            {
                studentRecords.RemoveAt(currentIndex);
                File.WriteAllLines("ListOfStudents.txt", studentRecords.Select(r => string.Join(",", r)));
                if (currentIndex > 0)
                    currentIndex--;

                if (studentRecords.Count == 0)
                {
                    ClearTextboxes();
                } else
                {
                    DisplayStudentRecord(currentIndex);
                }
            }
        }

        private void ClearTextboxes()
        {
            foreach (Control c in this.Controls)
                if (c is TextBox box)
                    box.Clear();     
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                DisplayStudentRecord(currentIndex);
            }
        }

        private void Indicator_Click(object sender, EventArgs e) => indicator.Enabled = false;

        private void Next_button_Click(object sender, EventArgs e)
        {
            if(currentIndex < studentRecords.Count - 1)
            {
                currentIndex++;
                DisplayStudentRecord(currentIndex);
            }
        }
    }
}
