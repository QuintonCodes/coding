using System;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;

namespace eHealthCareManagementSystem
{
    public partial class mainWindow : Form
    {
        private static readonly string DbFileName = "eHealthCareDatabase.db";
        private static readonly string DbFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static readonly string DbPath = Path.Combine(DbFolderPath, DbFileName);
        private static readonly string connectionString = $"Data Source={DbPath};Version=3;";
        public mainWindow()
        {
            InitializeComponent();
            InitializeDatabase();
            DisplayPatientRecords();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists(DbPath))
            {
                SQLiteConnection.CreateFile(DbPath);

                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"CREATE TABLE IF NOT EXISTS Patients (
                        PatientNumber TEXT PRIMARY KEY, 
                        FullName TEXT NOT NULL, 
                        PhoneNumber TEXT NOT NULL, 
                        NatureOfIllness TEXT NOT NULL, 
                        PatientType TEXT NOT NULL, 
                        Gender TEXT NOT NULL, 
                        Province TEXT NOT NULL, 
                        DateOfBirth TEXT NOT NULL
                    );";

                    using (var command = new SQLiteCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string patientNo = patientNo_textBox.Text;
            string fullName = name_textBox.Text;
            string phoneNo = phoneNo_textBox.Text;
            string natureOfIllness = illness_textBox.Text;
            string patientType = patientType_comboBox.Text;
            string gender = gender_comboBox.Text;
            string province = province_comboBox.Text;
            string dateOfBirth = dob_textBox.Text;

            if (string.IsNullOrWhiteSpace(patientNo) || string.IsNullOrWhiteSpace(fullName) ||
                string.IsNullOrWhiteSpace(phoneNo) || string.IsNullOrWhiteSpace(natureOfIllness) ||
                string.IsNullOrWhiteSpace(patientType) || string.IsNullOrWhiteSpace(gender) ||
                string.IsNullOrWhiteSpace(province) || string.IsNullOrWhiteSpace(dateOfBirth))
            {
                MessageBox.Show($"Patient Number is empty", "Error Detected in input", MessageBoxButtons.OK);
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO Patients (PatientNumber, FullName, PhoneNumber, NatureOfIllness, PatientType, Gender, Province, DateOfBirth) " +
                                     "VALUES (@PatientNumber, @FullName, @PhoneNumber, @NatureOfIllness, @PatientType, @Gender, @Province, @DateOfBirth)";

                using(SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@PatientNumber", patientNo);
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNo);
                    command.Parameters.AddWithValue("@NatureOfIllness", natureOfIllness);
                    command.Parameters.AddWithValue("@PatientType", patientType);
                    command.Parameters.AddWithValue("@Gender", gender);
                    command.Parameters.AddWithValue("@Province", province);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);

                    command.ExecuteNonQuery();
                }

                connection.Close();
            }

            ClearFormFields();

            DisplayPatientRecords();
        }

        private void ClearFormFields()
        {
            patientNo_textBox.Clear();
            name_textBox.Clear();
            phoneNo_textBox.Clear();
            illness_textBox.Clear();
            dob_textBox.Clear();
            search_textBox.Clear();

            patientType_comboBox.SelectedIndex = -1;
            gender_comboBox.SelectedIndex = -1;
            province_comboBox.SelectedIndex = -1;
        }

        private void DisplayPatientRecords()
        {
            dataGridView1.Rows.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Patients";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["PatientNumber"], reader["FullName"], reader["PhoneNumber"],
                                reader["NatureOfIllness"], reader["PatientType"], reader["Gender"], reader["Province"],
                                reader["DateOfBirth"]);
                        }
                    }
                }

                search_textBox.Clear();

                connection.Close();
            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            string patientNumber = search_textBox.Text;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectQuery = "SELECT * FROM Patients WHERE PatientNumber = @PatientNumber";

                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@PatientNumber", patientNumber);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            dataGridView1.Rows.Clear();
                            dataGridView1.Rows.Add(reader["PatientNumber"], reader["FullName"], reader["PhoneNumber"],
                                reader["NatureOfIllness"], reader["PatientType"], reader["Gender"], reader["Province"],
                                reader["DateOfBirth"]);
                        } else
                        {
                            MessageBox.Show("Patient not found.");
                        }
                    }
                }

                connection.Close();
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            string patientNumber = search_textBox.Text;

            DialogResult result = MessageBox.Show($"Caution: You are about to delete a record with patient number: {patientNumber}", "Are you sure you want to continue?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM Patients WHERE PatientNumber = @PatientNumber";

                    using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                    {
                        command.Parameters.AddWithValue("@PatientNumber", patientNumber);
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                }

                MessageBox.Show("Record deleted.");

                search_textBox.Clear();

                DisplayPatientRecords();
            }
        }

        private void displayAll_button_Click(object sender, EventArgs e)
        {
            DisplayPatientRecords();
        }
    }
}
