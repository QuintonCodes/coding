namespace EduvosStudentRegistrationSystem
{
    partial class AddStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudents));
            this.eduvosPicture = new System.Windows.Forms.PictureBox();
            this.heading_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.sponserName_label = new System.Windows.Forms.Label();
            this.dob_label = new System.Windows.Forms.Label();
            this.joinDate_label = new System.Windows.Forms.Label();
            this.nationality_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.lastName_textBox = new System.Windows.Forms.TextBox();
            this.sponser_textBox = new System.Windows.Forms.TextBox();
            this.dob_textBox = new System.Windows.Forms.TextBox();
            this.joinDate_textBox = new System.Windows.Forms.TextBox();
            this.nationality_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eduvosPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // eduvosPicture
            // 
            this.eduvosPicture.Image = ((System.Drawing.Image)(resources.GetObject("eduvosPicture.Image")));
            this.eduvosPicture.Location = new System.Drawing.Point(0, 0);
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
            this.heading_label.Location = new System.Drawing.Point(286, 109);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(194, 38);
            this.heading_label.TabIndex = 2;
            this.heading_label.Text = "Add Students";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(130, 189);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(77, 28);
            this.name_label.TabIndex = 3;
            this.name_label.Text = "Name :";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName_label.Location = new System.Drawing.Point(130, 265);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(119, 28);
            this.lastName_label.TabIndex = 4;
            this.lastName_label.Text = "Last Name :";
            // 
            // sponserName_label
            // 
            this.sponserName_label.AutoSize = true;
            this.sponserName_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sponserName_label.Location = new System.Drawing.Point(130, 335);
            this.sponserName_label.Name = "sponserName_label";
            this.sponserName_label.Size = new System.Drawing.Size(157, 28);
            this.sponserName_label.TabIndex = 5;
            this.sponserName_label.Text = "Sponser Name :";
            // 
            // dob_label
            // 
            this.dob_label.AutoSize = true;
            this.dob_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob_label.Location = new System.Drawing.Point(130, 411);
            this.dob_label.Name = "dob_label";
            this.dob_label.Size = new System.Drawing.Size(140, 28);
            this.dob_label.TabIndex = 6;
            this.dob_label.Text = "Date of Birth :";
            // 
            // joinDate_label
            // 
            this.joinDate_label.AutoSize = true;
            this.joinDate_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.joinDate_label.Location = new System.Drawing.Point(130, 490);
            this.joinDate_label.Name = "joinDate_label";
            this.joinDate_label.Size = new System.Drawing.Size(108, 28);
            this.joinDate_label.TabIndex = 7;
            this.joinDate_label.Text = "Join Date :";
            // 
            // nationality_label
            // 
            this.nationality_label.AutoSize = true;
            this.nationality_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationality_label.Location = new System.Drawing.Point(130, 574);
            this.nationality_label.Name = "nationality_label";
            this.nationality_label.Size = new System.Drawing.Size(121, 28);
            this.nationality_label.TabIndex = 8;
            this.nationality_label.Text = "Nationality :";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_button.Location = new System.Drawing.Point(97, 673);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(141, 44);
            this.save_button.TabIndex = 9;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.Location = new System.Drawing.Point(498, 673);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(141, 44);
            this.cancel_button.TabIndex = 10;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(293, 196);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(327, 22);
            this.name_textBox.TabIndex = 11;
            // 
            // lastName_textBox
            // 
            this.lastName_textBox.Location = new System.Drawing.Point(293, 272);
            this.lastName_textBox.Name = "lastName_textBox";
            this.lastName_textBox.Size = new System.Drawing.Size(327, 22);
            this.lastName_textBox.TabIndex = 12;
            // 
            // sponser_textBox
            // 
            this.sponser_textBox.Location = new System.Drawing.Point(293, 342);
            this.sponser_textBox.Name = "sponser_textBox";
            this.sponser_textBox.Size = new System.Drawing.Size(327, 22);
            this.sponser_textBox.TabIndex = 13;
            // 
            // dob_textBox
            // 
            this.dob_textBox.Location = new System.Drawing.Point(293, 417);
            this.dob_textBox.Name = "dob_textBox";
            this.dob_textBox.Size = new System.Drawing.Size(327, 22);
            this.dob_textBox.TabIndex = 14;
            // 
            // joinDate_textBox
            // 
            this.joinDate_textBox.Location = new System.Drawing.Point(293, 497);
            this.joinDate_textBox.Name = "joinDate_textBox";
            this.joinDate_textBox.Size = new System.Drawing.Size(327, 22);
            this.joinDate_textBox.TabIndex = 15;
            // 
            // nationality_textBox
            // 
            this.nationality_textBox.Location = new System.Drawing.Point(293, 581);
            this.nationality_textBox.Name = "nationality_textBox";
            this.nationality_textBox.Size = new System.Drawing.Size(327, 22);
            this.nationality_textBox.TabIndex = 16;
            // 
            // AddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 785);
            this.Controls.Add(this.nationality_textBox);
            this.Controls.Add(this.joinDate_textBox);
            this.Controls.Add(this.dob_textBox);
            this.Controls.Add(this.sponser_textBox);
            this.Controls.Add(this.lastName_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.nationality_label);
            this.Controls.Add(this.joinDate_label);
            this.Controls.Add(this.dob_label);
            this.Controls.Add(this.sponserName_label);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.eduvosPicture);
            this.Name = "AddStudents";
            this.Text = "AddStudents";
            ((System.ComponentModel.ISupportInitialize)(this.eduvosPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eduvosPicture;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.Label sponserName_label;
        private System.Windows.Forms.Label dob_label;
        private System.Windows.Forms.Label joinDate_label;
        private System.Windows.Forms.Label nationality_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox lastName_textBox;
        private System.Windows.Forms.TextBox sponser_textBox;
        private System.Windows.Forms.TextBox dob_textBox;
        private System.Windows.Forms.TextBox joinDate_textBox;
        private System.Windows.Forms.TextBox nationality_textBox;
    }
}