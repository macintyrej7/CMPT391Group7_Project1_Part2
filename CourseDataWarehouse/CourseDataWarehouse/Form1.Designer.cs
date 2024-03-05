﻿namespace CourseDataWarehouse
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            yearComboBox = new ComboBox();
            semesterComboBox = new ComboBox();
            genderComboBox = new ComboBox();
            majorComboBox = new ComboBox();
            departmentComboBox = new ComboBox();
            facultyComboBox = new ComboBox();
            universityComboBox = new ComboBox();
            titleLabel = new Label();
            coursesListView = new ListView();
            listOfCoursesLabel = new Label();
            numberOfCoursesTextBox = new TextBox();
            label1 = new Label();
            yearCheckBox = new CheckBox();
            semesterCheckBox = new CheckBox();
            majorCheckBox = new CheckBox();
            genderCheckBox = new CheckBox();
            departmentCheckBox = new CheckBox();
            facultyCheckBox = new CheckBox();
            universityCheckBox = new CheckBox();
            searchBtn = new Button();
            SuspendLayout();
            // 
            // yearComboBox
            // 
            yearComboBox.FormattingEnabled = true;
            yearComboBox.Location = new Point(133, 117);
            yearComboBox.Name = "yearComboBox";
            yearComboBox.Size = new Size(151, 28);
            yearComboBox.TabIndex = 7;
            // 
            // semesterComboBox
            // 
            semesterComboBox.FormattingEnabled = true;
            semesterComboBox.Location = new Point(133, 164);
            semesterComboBox.Name = "semesterComboBox";
            semesterComboBox.Size = new Size(151, 28);
            semesterComboBox.TabIndex = 8;
            // 
            // genderComboBox
            // 
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(411, 165);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(151, 28);
            genderComboBox.TabIndex = 9;
            // 
            // majorComboBox
            // 
            majorComboBox.FormattingEnabled = true;
            majorComboBox.Location = new Point(411, 117);
            majorComboBox.Name = "majorComboBox";
            majorComboBox.Size = new Size(151, 28);
            majorComboBox.TabIndex = 10;
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(724, 117);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(151, 28);
            departmentComboBox.TabIndex = 11;
            // 
            // facultyComboBox
            // 
            facultyComboBox.FormattingEnabled = true;
            facultyComboBox.Location = new Point(724, 165);
            facultyComboBox.Name = "facultyComboBox";
            facultyComboBox.Size = new Size(151, 28);
            facultyComboBox.TabIndex = 12;
            // 
            // universityComboBox
            // 
            universityComboBox.FormattingEnabled = true;
            universityComboBox.Location = new Point(1007, 117);
            universityComboBox.Name = "universityComboBox";
            universityComboBox.Size = new Size(151, 28);
            universityComboBox.TabIndex = 13;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.Location = new Point(411, 23);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(352, 41);
            titleLabel.TabIndex = 14;
            titleLabel.Text = "Course Data Warehouse";
            // 
            // coursesListView
            // 
            coursesListView.Location = new Point(33, 388);
            coursesListView.Name = "coursesListView";
            coursesListView.Size = new Size(1125, 442);
            coursesListView.TabIndex = 15;
            coursesListView.UseCompatibleStateImageBehavior = false;
            // 
            // listOfCoursesLabel
            // 
            listOfCoursesLabel.AutoSize = true;
            listOfCoursesLabel.Location = new Point(44, 365);
            listOfCoursesLabel.Name = "listOfCoursesLabel";
            listOfCoursesLabel.Size = new Size(107, 20);
            listOfCoursesLabel.TabIndex = 16;
            listOfCoursesLabel.Text = "List of Courses:";
            // 
            // numberOfCoursesTextBox
            // 
            numberOfCoursesTextBox.Location = new Point(189, 320);
            numberOfCoursesTextBox.Name = "numberOfCoursesTextBox";
            numberOfCoursesTextBox.Size = new Size(125, 27);
            numberOfCoursesTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 323);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 18;
            label1.Text = "Number of Courses:";
            // 
            // yearCheckBox
            // 
            yearCheckBox.AutoSize = true;
            yearCheckBox.Location = new Point(33, 117);
            yearCheckBox.Name = "yearCheckBox";
            yearCheckBox.Size = new Size(62, 24);
            yearCheckBox.TabIndex = 19;
            yearCheckBox.Text = "Year:";
            yearCheckBox.UseVisualStyleBackColor = true;
            // 
            // semesterCheckBox
            // 
            semesterCheckBox.AutoSize = true;
            semesterCheckBox.Location = new Point(33, 164);
            semesterCheckBox.Name = "semesterCheckBox";
            semesterCheckBox.Size = new Size(95, 24);
            semesterCheckBox.TabIndex = 20;
            semesterCheckBox.Text = "Semester:";
            semesterCheckBox.UseVisualStyleBackColor = true;
            // 
            // majorCheckBox
            // 
            majorCheckBox.AutoSize = true;
            majorCheckBox.Location = new Point(324, 119);
            majorCheckBox.Name = "majorCheckBox";
            majorCheckBox.Size = new Size(73, 24);
            majorCheckBox.TabIndex = 21;
            majorCheckBox.Text = "Major:";
            majorCheckBox.UseVisualStyleBackColor = true;
            // 
            // genderCheckBox
            // 
            genderCheckBox.AutoSize = true;
            genderCheckBox.Location = new Point(324, 165);
            genderCheckBox.Name = "genderCheckBox";
            genderCheckBox.Size = new Size(82, 24);
            genderCheckBox.TabIndex = 22;
            genderCheckBox.Text = "Gender:";
            genderCheckBox.UseVisualStyleBackColor = true;
            // 
            // departmentCheckBox
            // 
            departmentCheckBox.AutoSize = true;
            departmentCheckBox.Location = new Point(604, 119);
            departmentCheckBox.Name = "departmentCheckBox";
            departmentCheckBox.Size = new Size(114, 24);
            departmentCheckBox.TabIndex = 23;
            departmentCheckBox.Text = "Department:";
            departmentCheckBox.UseVisualStyleBackColor = true;
            // 
            // facultyCheckBox
            // 
            facultyCheckBox.AutoSize = true;
            facultyCheckBox.Location = new Point(604, 166);
            facultyCheckBox.Name = "facultyCheckBox";
            facultyCheckBox.Size = new Size(79, 24);
            facultyCheckBox.TabIndex = 24;
            facultyCheckBox.Text = "Faculty:";
            facultyCheckBox.UseVisualStyleBackColor = true;
            // 
            // universityCheckBox
            // 
            universityCheckBox.AutoSize = true;
            universityCheckBox.Location = new Point(903, 117);
            universityCheckBox.Name = "universityCheckBox";
            universityCheckBox.Size = new Size(98, 24);
            universityCheckBox.TabIndex = 25;
            universityCheckBox.Text = "University:";
            universityCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(33, 219);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(94, 29);
            searchBtn.TabIndex = 26;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 853);
            Controls.Add(searchBtn);
            Controls.Add(universityCheckBox);
            Controls.Add(facultyCheckBox);
            Controls.Add(departmentCheckBox);
            Controls.Add(genderCheckBox);
            Controls.Add(majorCheckBox);
            Controls.Add(semesterCheckBox);
            Controls.Add(yearCheckBox);
            Controls.Add(label1);
            Controls.Add(numberOfCoursesTextBox);
            Controls.Add(listOfCoursesLabel);
            Controls.Add(coursesListView);
            Controls.Add(titleLabel);
            Controls.Add(universityComboBox);
            Controls.Add(facultyComboBox);
            Controls.Add(departmentComboBox);
            Controls.Add(majorComboBox);
            Controls.Add(genderComboBox);
            Controls.Add(semesterComboBox);
            Controls.Add(yearComboBox);
            Name = "Form1";
            Text = "CourseDataWarehouse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox yearComboBox;
        private ComboBox semesterComboBox;
        private ComboBox genderComboBox;
        private ComboBox majorComboBox;
        private ComboBox departmentComboBox;
        private ComboBox facultyComboBox;
        private ComboBox universityComboBox;
        private Label titleLabel;
        private ListView coursesListView;
        private Label listOfCoursesLabel;
        private TextBox numberOfCoursesTextBox;
        private Label label1;
        private CheckBox yearCheckBox;
        private CheckBox semesterCheckBox;
        private CheckBox majorCheckBox;
        private CheckBox genderCheckBox;
        private CheckBox departmentCheckBox;
        private CheckBox facultyCheckBox;
        private CheckBox universityCheckBox;
        private Button searchBtn;
    }
}