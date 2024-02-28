namespace CourseDataWarehouse
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
            yearRadioButton = new RadioButton();
            semesterRadioButton = new RadioButton();
            studentMajorRadioButton = new RadioButton();
            studentGenderRadioButton = new RadioButton();
            instructorDepartmentRadioButton = new RadioButton();
            instructorFacultyRadioButton = new RadioButton();
            universityRadioButton = new RadioButton();
            yearCombBox = new ComboBox();
            semesterComboBox = new ComboBox();
            studentGenderComboBox = new ComboBox();
            studentMajorComboBox = new ComboBox();
            instructorDepartmentComboBox = new ComboBox();
            instructorFacultyComboBox = new ComboBox();
            universityComboBox = new ComboBox();
            titleLabel = new Label();
            coursesListView = new ListView();
            listOfCoursesLabel = new Label();
            numberOfCoursesTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // yearRadioButton
            // 
            yearRadioButton.AutoSize = true;
            yearRadioButton.Location = new Point(33, 117);
            yearRadioButton.Name = "yearRadioButton";
            yearRadioButton.Size = new Size(61, 24);
            yearRadioButton.TabIndex = 0;
            yearRadioButton.TabStop = true;
            yearRadioButton.Text = "Year:";
            yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // semesterRadioButton
            // 
            semesterRadioButton.AutoSize = true;
            semesterRadioButton.Location = new Point(33, 164);
            semesterRadioButton.Name = "semesterRadioButton";
            semesterRadioButton.Size = new Size(94, 24);
            semesterRadioButton.TabIndex = 1;
            semesterRadioButton.TabStop = true;
            semesterRadioButton.Text = "Semester:";
            semesterRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentMajorRadioButton
            // 
            studentMajorRadioButton.AutoSize = true;
            studentMajorRadioButton.Location = new Point(324, 117);
            studentMajorRadioButton.Name = "studentMajorRadioButton";
            studentMajorRadioButton.Size = new Size(72, 24);
            studentMajorRadioButton.TabIndex = 2;
            studentMajorRadioButton.TabStop = true;
            studentMajorRadioButton.Text = "Major:";
            studentMajorRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentGenderRadioButton
            // 
            studentGenderRadioButton.AutoSize = true;
            studentGenderRadioButton.Location = new Point(324, 165);
            studentGenderRadioButton.Name = "studentGenderRadioButton";
            studentGenderRadioButton.Size = new Size(81, 24);
            studentGenderRadioButton.TabIndex = 3;
            studentGenderRadioButton.TabStop = true;
            studentGenderRadioButton.Text = "Gender:";
            studentGenderRadioButton.UseVisualStyleBackColor = true;
            studentGenderRadioButton.CheckedChanged += studentGenderRadioButton_CheckedChanged;
            // 
            // instructorDepartmentRadioButton
            // 
            instructorDepartmentRadioButton.AutoSize = true;
            instructorDepartmentRadioButton.Location = new Point(605, 117);
            instructorDepartmentRadioButton.Name = "instructorDepartmentRadioButton";
            instructorDepartmentRadioButton.Size = new Size(113, 24);
            instructorDepartmentRadioButton.TabIndex = 4;
            instructorDepartmentRadioButton.TabStop = true;
            instructorDepartmentRadioButton.Text = "Department:";
            instructorDepartmentRadioButton.UseVisualStyleBackColor = true;
            // 
            // instructorFacultyRadioButton
            // 
            instructorFacultyRadioButton.AutoSize = true;
            instructorFacultyRadioButton.Location = new Point(605, 164);
            instructorFacultyRadioButton.Name = "instructorFacultyRadioButton";
            instructorFacultyRadioButton.Size = new Size(78, 24);
            instructorFacultyRadioButton.TabIndex = 5;
            instructorFacultyRadioButton.TabStop = true;
            instructorFacultyRadioButton.Text = "Faculty:";
            instructorFacultyRadioButton.UseVisualStyleBackColor = true;
            // 
            // universityRadioButton
            // 
            universityRadioButton.AutoSize = true;
            universityRadioButton.Location = new Point(904, 117);
            universityRadioButton.Name = "universityRadioButton";
            universityRadioButton.Size = new Size(97, 24);
            universityRadioButton.TabIndex = 6;
            universityRadioButton.TabStop = true;
            universityRadioButton.Text = "University:";
            universityRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearCombBox
            // 
            yearCombBox.FormattingEnabled = true;
            yearCombBox.Location = new Point(133, 117);
            yearCombBox.Name = "yearCombBox";
            yearCombBox.Size = new Size(151, 28);
            yearCombBox.TabIndex = 7;
            // 
            // semesterComboBox
            // 
            semesterComboBox.FormattingEnabled = true;
            semesterComboBox.Location = new Point(133, 164);
            semesterComboBox.Name = "semesterComboBox";
            semesterComboBox.Size = new Size(151, 28);
            semesterComboBox.TabIndex = 8;
            // 
            // studentGenderComboBox
            // 
            studentGenderComboBox.FormattingEnabled = true;
            studentGenderComboBox.Location = new Point(411, 165);
            studentGenderComboBox.Name = "studentGenderComboBox";
            studentGenderComboBox.Size = new Size(151, 28);
            studentGenderComboBox.TabIndex = 9;
            // 
            // studentMajorComboBox
            // 
            studentMajorComboBox.FormattingEnabled = true;
            studentMajorComboBox.Location = new Point(411, 117);
            studentMajorComboBox.Name = "studentMajorComboBox";
            studentMajorComboBox.Size = new Size(151, 28);
            studentMajorComboBox.TabIndex = 10;
            // 
            // instructorDepartmentComboBox
            // 
            instructorDepartmentComboBox.FormattingEnabled = true;
            instructorDepartmentComboBox.Location = new Point(724, 117);
            instructorDepartmentComboBox.Name = "instructorDepartmentComboBox";
            instructorDepartmentComboBox.Size = new Size(151, 28);
            instructorDepartmentComboBox.TabIndex = 11;
            // 
            // instructorFacultyComboBox
            // 
            instructorFacultyComboBox.FormattingEnabled = true;
            instructorFacultyComboBox.Location = new Point(724, 165);
            instructorFacultyComboBox.Name = "instructorFacultyComboBox";
            instructorFacultyComboBox.Size = new Size(151, 28);
            instructorFacultyComboBox.TabIndex = 12;
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
            coursesListView.Location = new Point(33, 332);
            coursesListView.Name = "coursesListView";
            coursesListView.Size = new Size(1125, 498);
            coursesListView.TabIndex = 15;
            coursesListView.UseCompatibleStateImageBehavior = false;
            // 
            // listOfCoursesLabel
            // 
            listOfCoursesLabel.AutoSize = true;
            listOfCoursesLabel.Location = new Point(44, 309);
            listOfCoursesLabel.Name = "listOfCoursesLabel";
            listOfCoursesLabel.Size = new Size(107, 20);
            listOfCoursesLabel.TabIndex = 16;
            listOfCoursesLabel.Text = "List of Courses:";
            // 
            // numberOfCoursesTextBox
            // 
            numberOfCoursesTextBox.Location = new Point(189, 270);
            numberOfCoursesTextBox.Name = "numberOfCoursesTextBox";
            numberOfCoursesTextBox.Size = new Size(125, 27);
            numberOfCoursesTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 273);
            label1.Name = "label1";
            label1.Size = new Size(139, 20);
            label1.TabIndex = 18;
            label1.Text = "Number of Courses:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1182, 853);
            Controls.Add(label1);
            Controls.Add(numberOfCoursesTextBox);
            Controls.Add(listOfCoursesLabel);
            Controls.Add(coursesListView);
            Controls.Add(titleLabel);
            Controls.Add(universityComboBox);
            Controls.Add(instructorFacultyComboBox);
            Controls.Add(instructorDepartmentComboBox);
            Controls.Add(studentMajorComboBox);
            Controls.Add(studentGenderComboBox);
            Controls.Add(semesterComboBox);
            Controls.Add(yearCombBox);
            Controls.Add(universityRadioButton);
            Controls.Add(instructorFacultyRadioButton);
            Controls.Add(instructorDepartmentRadioButton);
            Controls.Add(studentGenderRadioButton);
            Controls.Add(studentMajorRadioButton);
            Controls.Add(semesterRadioButton);
            Controls.Add(yearRadioButton);
            Name = "Form1";
            Text = "CourseDataWarehouse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton yearRadioButton;
        private RadioButton semesterRadioButton;
        private RadioButton studentMajorRadioButton;
        private RadioButton studentGenderRadioButton;
        private RadioButton instructorDepartmentRadioButton;
        private RadioButton instructorFacultyRadioButton;
        private RadioButton universityRadioButton;
        private ComboBox yearCombBox;
        private ComboBox semesterComboBox;
        private ComboBox studentGenderComboBox;
        private ComboBox studentMajorComboBox;
        private ComboBox instructorDepartmentComboBox;
        private ComboBox instructorFacultyComboBox;
        private ComboBox universityComboBox;
        private Label titleLabel;
        private ListView coursesListView;
        private Label listOfCoursesLabel;
        private TextBox numberOfCoursesTextBox;
        private Label label1;
    }
}