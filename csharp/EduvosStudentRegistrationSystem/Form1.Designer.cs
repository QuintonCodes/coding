namespace EduvosStudentRegistrationSystem
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.eduvosPicture = new System.Windows.Forms.PictureBox();
            this.heading_label = new System.Windows.Forms.Label();
            this.addStudents_button = new System.Windows.Forms.Button();
            this.showStudents_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
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
            this.eduvosPicture.TabIndex = 0;
            this.eduvosPicture.TabStop = false;
            // 
            // heading_label
            // 
            this.heading_label.AutoSize = true;
            this.heading_label.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading_label.Location = new System.Drawing.Point(228, 127);
            this.heading_label.Name = "heading_label";
            this.heading_label.Size = new System.Drawing.Size(385, 38);
            this.heading_label.TabIndex = 1;
            this.heading_label.Text = "Students Data Management";
            // 
            // addStudents_button
            // 
            this.addStudents_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudents_button.Location = new System.Drawing.Point(302, 210);
            this.addStudents_button.Name = "addStudents_button";
            this.addStudents_button.Size = new System.Drawing.Size(227, 67);
            this.addStudents_button.TabIndex = 2;
            this.addStudents_button.Text = "Add Students";
            this.addStudents_button.UseVisualStyleBackColor = true;
            this.addStudents_button.Click += new System.EventHandler(this.AddStudents_button_Click);
            // 
            // showStudents_button
            // 
            this.showStudents_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showStudents_button.Location = new System.Drawing.Point(302, 342);
            this.showStudents_button.Name = "showStudents_button";
            this.showStudents_button.Size = new System.Drawing.Size(227, 67);
            this.showStudents_button.TabIndex = 3;
            this.showStudents_button.Text = "Show Students";
            this.showStudents_button.UseVisualStyleBackColor = true;
            this.showStudents_button.Click += new System.EventHandler(this.ShowStudents_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(302, 490);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(227, 67);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // homePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 706);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.showStudents_button);
            this.Controls.Add(this.addStudents_button);
            this.Controls.Add(this.heading_label);
            this.Controls.Add(this.eduvosPicture);
            this.Name = "homePage";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.eduvosPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox eduvosPicture;
        private System.Windows.Forms.Label heading_label;
        private System.Windows.Forms.Button addStudents_button;
        private System.Windows.Forms.Button showStudents_button;
        private System.Windows.Forms.Button exit_button;
    }
}

