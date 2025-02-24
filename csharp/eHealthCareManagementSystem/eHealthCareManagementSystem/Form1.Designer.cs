namespace eHealthCareManagementSystem
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.heading_label = new System.Windows.Forms.Label();
			this.topPanel = new System.Windows.Forms.Panel();
			this.province_comboBox = new System.Windows.Forms.ComboBox();
			this.gender_comboBox = new System.Windows.Forms.ComboBox();
			this.patientType_comboBox = new System.Windows.Forms.ComboBox();
			this.dob_textBox = new System.Windows.Forms.TextBox();
			this.search_textBox = new System.Windows.Forms.TextBox();
			this.illness_textBox = new System.Windows.Forms.TextBox();
			this.phoneNo_textBox = new System.Windows.Forms.TextBox();
			this.name_textBox = new System.Windows.Forms.TextBox();
			this.patientNo_textBox = new System.Windows.Forms.TextBox();
			this.delete_button = new System.Windows.Forms.Button();
			this.search_button = new System.Windows.Forms.Button();
			this.displayAll_button = new System.Windows.Forms.Button();
			this.save_button = new System.Windows.Forms.Button();
			this.dob_label = new System.Windows.Forms.Label();
			this.province_label = new System.Windows.Forms.Label();
			this.gender_label = new System.Windows.Forms.Label();
			this.patientType_label = new System.Windows.Forms.Label();
			this.search_label = new System.Windows.Forms.Label();
			this.illness_label = new System.Windows.Forms.Label();
			this.phoneNo_label = new System.Windows.Forms.Label();
			this.name_label = new System.Windows.Forms.Label();
			this.patientNo_label = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.PatientNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PatientType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Illness = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Province = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.topPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// heading_label
			// 
			this.heading_label.AutoSize = true;
			this.heading_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.heading_label.ForeColor = System.Drawing.SystemColors.Control;
			this.heading_label.Location = new System.Drawing.Point(461, 11);
			this.heading_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.heading_label.Name = "heading_label";
			this.heading_label.Size = new System.Drawing.Size(334, 31);
			this.heading_label.TabIndex = 0;
			this.heading_label.Text = "eHealth Care Incorporated";
			this.heading_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// topPanel
			// 
			this.topPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.topPanel.Controls.Add(this.province_comboBox);
			this.topPanel.Controls.Add(this.gender_comboBox);
			this.topPanel.Controls.Add(this.patientType_comboBox);
			this.topPanel.Controls.Add(this.dob_textBox);
			this.topPanel.Controls.Add(this.search_textBox);
			this.topPanel.Controls.Add(this.illness_textBox);
			this.topPanel.Controls.Add(this.phoneNo_textBox);
			this.topPanel.Controls.Add(this.name_textBox);
			this.topPanel.Controls.Add(this.patientNo_textBox);
			this.topPanel.Controls.Add(this.delete_button);
			this.topPanel.Controls.Add(this.search_button);
			this.topPanel.Controls.Add(this.displayAll_button);
			this.topPanel.Controls.Add(this.save_button);
			this.topPanel.Controls.Add(this.dob_label);
			this.topPanel.Controls.Add(this.province_label);
			this.topPanel.Controls.Add(this.gender_label);
			this.topPanel.Controls.Add(this.patientType_label);
			this.topPanel.Controls.Add(this.search_label);
			this.topPanel.Controls.Add(this.illness_label);
			this.topPanel.Controls.Add(this.phoneNo_label);
			this.topPanel.Controls.Add(this.name_label);
			this.topPanel.Controls.Add(this.patientNo_label);
			this.topPanel.Location = new System.Drawing.Point(4, 58);
			this.topPanel.Margin = new System.Windows.Forms.Padding(4);
			this.topPanel.Name = "topPanel";
			this.topPanel.Size = new System.Drawing.Size(1369, 319);
			this.topPanel.TabIndex = 1;
			// 
			// province_comboBox
			// 
			this.province_comboBox.FormattingEnabled = true;
			this.province_comboBox.Items.AddRange(new object[] {
            "Limpopo",
            "Gauteng",
            "North West",
            "Mpumalanga",
            "KwaZulu Natal",
            "Free State",
            "Northern Cape",
            "Western Cape",
            "Eastern Cape"});
			this.province_comboBox.Location = new System.Drawing.Point(1101, 145);
			this.province_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.province_comboBox.Name = "province_comboBox";
			this.province_comboBox.Size = new System.Drawing.Size(237, 24);
			this.province_comboBox.TabIndex = 19;
			// 
			// gender_comboBox
			// 
			this.gender_comboBox.FormattingEnabled = true;
			this.gender_comboBox.Items.AddRange(new object[] {
            "Female",
            "Male"});
			this.gender_comboBox.Location = new System.Drawing.Point(1101, 82);
			this.gender_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.gender_comboBox.Name = "gender_comboBox";
			this.gender_comboBox.Size = new System.Drawing.Size(237, 24);
			this.gender_comboBox.TabIndex = 18;
			// 
			// patientType_comboBox
			// 
			this.patientType_comboBox.FormattingEnabled = true;
			this.patientType_comboBox.Items.AddRange(new object[] {
            "In_Patient",
            "Out_Patient",
            "Emergency"});
			this.patientType_comboBox.Location = new System.Drawing.Point(1101, 17);
			this.patientType_comboBox.Margin = new System.Windows.Forms.Padding(4);
			this.patientType_comboBox.Name = "patientType_comboBox";
			this.patientType_comboBox.Size = new System.Drawing.Size(237, 24);
			this.patientType_comboBox.TabIndex = 17;
			// 
			// dob_textBox
			// 
			this.dob_textBox.Location = new System.Drawing.Point(1101, 207);
			this.dob_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.dob_textBox.Name = "dob_textBox";
			this.dob_textBox.Size = new System.Drawing.Size(237, 22);
			this.dob_textBox.TabIndex = 16;
			// 
			// search_textBox
			// 
			this.search_textBox.Location = new System.Drawing.Point(264, 270);
			this.search_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.search_textBox.Name = "search_textBox";
			this.search_textBox.Size = new System.Drawing.Size(291, 22);
			this.search_textBox.TabIndex = 15;
			// 
			// illness_textBox
			// 
			this.illness_textBox.Location = new System.Drawing.Point(264, 209);
			this.illness_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.illness_textBox.Name = "illness_textBox";
			this.illness_textBox.Size = new System.Drawing.Size(291, 22);
			this.illness_textBox.TabIndex = 14;
			// 
			// phoneNo_textBox
			// 
			this.phoneNo_textBox.Location = new System.Drawing.Point(264, 145);
			this.phoneNo_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.phoneNo_textBox.Name = "phoneNo_textBox";
			this.phoneNo_textBox.Size = new System.Drawing.Size(291, 22);
			this.phoneNo_textBox.TabIndex = 13;
			// 
			// name_textBox
			// 
			this.name_textBox.Location = new System.Drawing.Point(264, 82);
			this.name_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.name_textBox.Name = "name_textBox";
			this.name_textBox.Size = new System.Drawing.Size(291, 22);
			this.name_textBox.TabIndex = 12;
			// 
			// patientNo_textBox
			// 
			this.patientNo_textBox.Location = new System.Drawing.Point(264, 20);
			this.patientNo_textBox.Margin = new System.Windows.Forms.Padding(4);
			this.patientNo_textBox.Name = "patientNo_textBox";
			this.patientNo_textBox.Size = new System.Drawing.Size(291, 22);
			this.patientNo_textBox.TabIndex = 11;
			// 
			// delete_button
			// 
			this.delete_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.delete_button.Location = new System.Drawing.Point(1231, 260);
			this.delete_button.Margin = new System.Windows.Forms.Padding(4);
			this.delete_button.Name = "delete_button";
			this.delete_button.Size = new System.Drawing.Size(109, 46);
			this.delete_button.TabIndex = 10;
			this.delete_button.Text = "Delete";
			this.delete_button.UseVisualStyleBackColor = true;
			this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
			// 
			// search_button
			// 
			this.search_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_button.Location = new System.Drawing.Point(1025, 260);
			this.search_button.Margin = new System.Windows.Forms.Padding(4);
			this.search_button.Name = "search_button";
			this.search_button.Size = new System.Drawing.Size(113, 46);
			this.search_button.TabIndex = 9;
			this.search_button.Text = "Search";
			this.search_button.UseVisualStyleBackColor = true;
			this.search_button.Click += new System.EventHandler(this.search_button_Click);
			// 
			// displayAll_button
			// 
			this.displayAll_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.displayAll_button.Location = new System.Drawing.Point(829, 256);
			this.displayAll_button.Margin = new System.Windows.Forms.Padding(4);
			this.displayAll_button.Name = "displayAll_button";
			this.displayAll_button.Size = new System.Drawing.Size(128, 50);
			this.displayAll_button.TabIndex = 8;
			this.displayAll_button.Text = "Display All";
			this.displayAll_button.UseVisualStyleBackColor = true;
			this.displayAll_button.Click += new System.EventHandler(this.displayAll_button_Click);
			// 
			// save_button
			// 
			this.save_button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.save_button.Location = new System.Drawing.Point(636, 260);
			this.save_button.Margin = new System.Windows.Forms.Padding(4);
			this.save_button.Name = "save_button";
			this.save_button.Size = new System.Drawing.Size(117, 46);
			this.save_button.TabIndex = 2;
			this.save_button.Text = "Save";
			this.save_button.UseVisualStyleBackColor = true;
			this.save_button.Click += new System.EventHandler(this.save_button_Click);
			// 
			// dob_label
			// 
			this.dob_label.AutoSize = true;
			this.dob_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dob_label.Location = new System.Drawing.Point(851, 207);
			this.dob_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.dob_label.Name = "dob_label";
			this.dob_label.Size = new System.Drawing.Size(166, 24);
			this.dob_label.TabIndex = 7;
			this.dob_label.Text = "Date of Birth";
			// 
			// province_label
			// 
			this.province_label.AutoSize = true;
			this.province_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.province_label.Location = new System.Drawing.Point(851, 143);
			this.province_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.province_label.Name = "province_label";
			this.province_label.Size = new System.Drawing.Size(106, 24);
			this.province_label.TabIndex = 6;
			this.province_label.Text = "Province";
			// 
			// gender_label
			// 
			this.gender_label.AutoSize = true;
			this.gender_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gender_label.Location = new System.Drawing.Point(851, 80);
			this.gender_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.gender_label.Name = "gender_label";
			this.gender_label.Size = new System.Drawing.Size(82, 24);
			this.gender_label.TabIndex = 2;
			this.gender_label.Text = "Gender";
			// 
			// patientType_label
			// 
			this.patientType_label.AutoSize = true;
			this.patientType_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patientType_label.Location = new System.Drawing.Point(851, 20);
			this.patientType_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.patientType_label.Name = "patientType_label";
			this.patientType_label.Size = new System.Drawing.Size(154, 24);
			this.patientType_label.TabIndex = 5;
			this.patientType_label.Text = "Patient Type";
			// 
			// search_label
			// 
			this.search_label.AutoSize = true;
			this.search_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.search_label.Location = new System.Drawing.Point(41, 270);
			this.search_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.search_label.Name = "search_label";
			this.search_label.Size = new System.Drawing.Size(250, 24);
			this.search_label.TabIndex = 4;
			this.search_label.Text = "Search by Patient No";
			// 
			// illness_label
			// 
			this.illness_label.AutoSize = true;
			this.illness_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.illness_label.Location = new System.Drawing.Point(41, 207);
			this.illness_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.illness_label.Name = "illness_label";
			this.illness_label.Size = new System.Drawing.Size(214, 24);
			this.illness_label.TabIndex = 3;
			this.illness_label.Text = "Nature of Illness";
			// 
			// phoneNo_label
			// 
			this.phoneNo_label.AutoSize = true;
			this.phoneNo_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.phoneNo_label.Location = new System.Drawing.Point(41, 143);
			this.phoneNo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.phoneNo_label.Name = "phoneNo_label";
			this.phoneNo_label.Size = new System.Drawing.Size(154, 24);
			this.phoneNo_label.TabIndex = 2;
			this.phoneNo_label.Text = "Phone Number";
			// 
			// name_label
			// 
			this.name_label.AutoSize = true;
			this.name_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.name_label.Location = new System.Drawing.Point(41, 80);
			this.name_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.name_label.Name = "name_label";
			this.name_label.Size = new System.Drawing.Size(118, 24);
			this.name_label.TabIndex = 1;
			this.name_label.Text = "Full Name";
			// 
			// patientNo_label
			// 
			this.patientNo_label.AutoSize = true;
			this.patientNo_label.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patientNo_label.Location = new System.Drawing.Point(41, 20);
			this.patientNo_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.patientNo_label.Name = "patientNo_label";
			this.patientNo_label.Size = new System.Drawing.Size(178, 24);
			this.patientNo_label.TabIndex = 0;
			this.patientNo_label.Text = "Patient Number";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeight = 30;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientNo,
            this.FullName,
            this.PatientType,
            this.Gender,
            this.Illness,
            this.PhoneNumber,
            this.Province,
            this.DOB});
			this.dataGridView1.Location = new System.Drawing.Point(4, 385);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 150;
			this.dataGridView1.Size = new System.Drawing.Size(1369, 403);
			this.dataGridView1.TabIndex = 2;
			// 
			// PatientNo
			// 
			this.PatientNo.HeaderText = "PatientNo";
			this.PatientNo.MinimumWidth = 6;
			this.PatientNo.Name = "PatientNo";
			this.PatientNo.Width = 125;
			// 
			// FullName
			// 
			this.FullName.HeaderText = "FullName";
			this.FullName.MinimumWidth = 6;
			this.FullName.Name = "FullName";
			this.FullName.Width = 125;
			// 
			// PatientType
			// 
			this.PatientType.HeaderText = "PatientType";
			this.PatientType.MinimumWidth = 6;
			this.PatientType.Name = "PatientType";
			this.PatientType.Width = 125;
			// 
			// Gender
			// 
			this.Gender.HeaderText = "Gender";
			this.Gender.MinimumWidth = 6;
			this.Gender.Name = "Gender";
			this.Gender.Width = 125;
			// 
			// Illness
			// 
			this.Illness.HeaderText = "Illness";
			this.Illness.MinimumWidth = 6;
			this.Illness.Name = "Illness";
			this.Illness.Width = 125;
			// 
			// PhoneNumber
			// 
			this.PhoneNumber.HeaderText = "PhoneNumber";
			this.PhoneNumber.MinimumWidth = 6;
			this.PhoneNumber.Name = "PhoneNumber";
			this.PhoneNumber.Width = 125;
			// 
			// Province
			// 
			this.Province.HeaderText = "Province";
			this.Province.MinimumWidth = 6;
			this.Province.Name = "Province";
			this.Province.Width = 125;
			// 
			// DOB
			// 
			this.DOB.HeaderText = "DOB";
			this.DOB.MinimumWidth = 6;
			this.DOB.Name = "DOB";
			this.DOB.Width = 125;
			// 
			// mainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1375, 801);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.topPanel);
			this.Controls.Add(this.heading_label);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "mainWindow";
			this.Text = "eHealth Care Hospital Management System";
			this.topPanel.ResumeLayout(false);
			this.topPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label patientNo_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label phoneNo_label;
        private System.Windows.Forms.Label illness_label;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Label patientType_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label province_label;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button displayAll_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox patientNo_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox phoneNo_textBox;
        private System.Windows.Forms.TextBox illness_textBox;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.TextBox dob_textBox;
        private System.Windows.Forms.ComboBox patientType_comboBox;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.ComboBox province_comboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Illness;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Province;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
    }
}

