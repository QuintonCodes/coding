namespace EduvosStudentRegistrationSystem
{
    partial class ShowStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowStudents));
            this.eduvosPicture = new System.Windows.Forms.PictureBox();
            this.heading_label = new System.Windows.Forms.Label();
            this.previous_button = new System.Windows.Forms.Button();
            this.next_button = new System.Windows.Forms.Button();
            this.nationality_textBox = new System.Windows.Forms.TextBox();
            this.joinDate_textBox = new System.Windows.Forms.TextBox();
            this.dob_textBox = new System.Windows.Forms.TextBox();
            this.sponser_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.nationality_label = new System.Windows.Forms.Label();
            this.joinDate_label = new System.Windows.Forms.Label();
            this.dob_label = new System.Windows.Forms.Label();
            this.sponserName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.indicator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eduvosPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // eduvosPicture
            // 
            this.eduvosPicture.Image = ((System.Drawing.Image)(resources.GetObject("eduvosPicture.Image")));
            this.eduvosPicture.Location = new System.Drawing.Point(1, 0);
            this.eduvosPicture.Name = "eduvosPicture";
            this.eduvosPicture.Size = new System.Drawing.Size(183, 128);
            this.eduvosPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.eduvosPicture.TabIndex = 1;
            this.eduvosPicture.TabStop = false;
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.Location = new System.Drawing.Point(226, 129);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(367, 38);
            this.heading_label.TabIndex = 2;
            this.heading_label.Text = "List of Registered Students";
            // 
            // previous_button
            // 
            this.previous_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previous_button.Location = new System.Drawing.Point(134, 200);
            this.previous_button.Name = "previous_button";
            this.previous_button.Size = new System.Drawing.Size(61, 54);
            this.previous_button.TabIndex = 3;
            this.previous_button.Text = "<=";
            this.previous_button.UseVisualStyleBackColor = true;
            this.previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // next_button
            // 
            this.next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_button.Location = new System.Drawing.Point(578, 200);
            this.next_button.Name = "next_button";
            this.next_button.Size = new System.Drawing.Size(61, 54);
            this.next_button.TabIndex = 4;
            this.next_button.Text = "=>";
            this.next_button.UseVisualStyleBackColor = true;
            this.next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // nationality_textBox
            // 
            this.nationality_textBox.Location = new System.Drawing.Point(292, 688);
            this.nationality_textBox.Name = "nationality_textBox";
            this.nationality_textBox.Size = new System.Drawing.Size(327, 22);
            this.nationality_textBox.TabIndex = 28;
            // 
            // joinDate_textBox
            // 
            this.joinDate_textBox.Location = new System.Drawing.Point(292, 604);
            this.joinDate_textBox.Name = "joinDate_textBox";
            this.joinDate_textBox.Size = new System.Drawing.Size(327, 22);
            this.joinDate_textBox.TabIndex = 27;
            // 
            // dob_textBox
            // 
            this.dob_textBox.Location = new System.Drawing.Point(292, 524);
            this.dob_textBox.Name = "dob_textBox";
            this.dob_textBox.Size = new System.Drawing.Size(327, 22);
            this.dob_textBox.TabIndex = 26;
            // 
            // sponser_textBox
            // 
            this.sponser_textBox.Location = new System.Drawing.Point(292, 449);
            this.sponser_textBox.Name = "sponser_textBox";
            this.sponser_textBox.Size = new System.Drawing.Size(327, 22);
            this.sponser_textBox.TabIndex = 25;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(292, 379);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(327, 22);
            this.lastName_textBox.TabIndex = 24;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(292, 303);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(327, 22);
            this.name_textBox.TabIndex = 23;
            // 
            // nationality_label
            // 
            this.nationality_label.AutoSize = true;
            this.nationality_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationality_label.Location = new System.Drawing.Point(129, 681);
            this.nationality_label.Name = "nationality_label";
            this.nationality_label.Size = new System.Drawing.Size(121, 28);
            this.nationality_label.TabIndex = 22;
            this.nationality_label.Text = "Nationality :";
            // 
            // joinDate_label
            // 
            this.joinDate_label.AutoSize = true;
            this.joinDate_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinDate_label.Location = new System.Drawing.Point(129, 597);
            this.joinDate_label.Name = "joinDate_label";
            this.joinDate_label.Size = new System.Drawing.Size(108, 28);
            this.joinDate_label.TabIndex = 21;
            this.joinDate_label.Text = "Join Date :";
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_label.Location = new System.Drawing.Point(129, 518);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(140, 28);
            this.dob_label.TabIndex = 20;
            this.dob_label.Text = "Date of Birth :";
            // 
            // sponserName_label
            // 
            this.sponserName_label.AutoSize = true;
            this.sponserName_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sponserName_label.Location = new System.Drawing.Point(129, 442);
            this.sponserName_label.Name = "sponserName_label";
            this.sponserName_label.Size = new System.Drawing.Size(157, 28);
            this.sponserName_label.TabIndex = 19;
            this.sponserName_label.Text = "Sponser Name :";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(129, 372);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(119, 28);
            this.lastName_label.TabIndex = 18;
            this.lastName_label.Text = "Last Name :";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(129, 296);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(77, 28);
            this.name_label.TabIndex = 17;
            this.name_label.Text = "Name :";
            // 
            // delete_button
            // 
            this.delete_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Location = new System.Drawing.Point(508, 775);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(141, 44);
            this.delete_button.TabIndex = 30;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(107, 775);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 44);
            this.back_button.TabIndex = 29;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // indicator
            // 
            this.indicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indicator.Location = new System.Drawing.Point(349, 200);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(61, 54);
            this.indicator.TabIndex = 31;
            this.indicator.Text = "1/4";
            this.indicator.UseVisualStyleBackColor = true;
            this.indicator.Click += new System.EventHandler(this.Indicator_Click);
            // 
            // ShowStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 831);
            this.Controls.Add(this.indicator);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.nationality_textBox);
            this.Controls.Add(this.joinDate_textBox);
            this.Controls.Add(this.dob_textBox);
            this.Controls.Add(this.sponser_textBox);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.nationality_label);
            this.Controls.Add(this.joinDate_label);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.sponserName_label);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.next_button);
            this.Controls.Add(this.previous_button);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.eduvosPicture);
            this.Name = "ShowStudents";
            this.Text = "ShowStudents";
            ((System.ComponentModel.ISupportInitialize)(this.eduvosPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eduvosPicture;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Button previous_button;
        private System.Windows.Forms.Button next_button;
        private System.Windows.Forms.TextBox nationality_textBox;
        private System.Windows.Forms.TextBox joinDate_textBox;
        private System.Windows.Forms.TextBox dob_textBox;
        private System.Windows.Forms.TextBox sponser_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Label nationality_label;
        private System.Windows.Forms.Label joinDate_label;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.Label sponserName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button indicator;
    }
}